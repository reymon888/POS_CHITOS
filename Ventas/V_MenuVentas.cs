using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS
{
    public partial class V_MenuVentas : Form
    {
        private readonly VentasService ventasService;
        private List<VentaDTO> _ventas;  // Lista de ventas completa
        private Usuario _usuarioActual;  // Usuario actual
        public V_MenuVentas(int idusuario, POSContext context)
        {
            InitializeComponent();
            ventasService = new VentasService(context);
            _usuarioActual = context.Usuarios.Find(idusuario);

            CargarVentas();

            // Suscribir eventos de filtros
            TB_BuscarVenta.TextChanged += TB_BuscarVenta_TextChanged;
            ConfigurarPermisos();
        }

        private void VerificarPermisosVentaSeleccionada()
        {
            // Asegurarse de que _ventas está inicializado
            if (_ventas == null)
            {
                _ventas = ventasService.ObtenerVentas();
            }

            B_ModificarVenta.Enabled = false;
            B_CancelarVenta.Enabled = false;

            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                {
                    // Obtener la venta seleccionada y verificar el estado del corte
                    var ventaSeleccionada = _ventas.FirstOrDefault(v => v.FolioVenta == folioVenta);
                    if (ventaSeleccionada != null && ventaSeleccionada.EstadoCorte != "Realizado")
                    {
                        B_ModificarVenta.Enabled = true;
                        B_CancelarVenta.Enabled = true;
                    }
                }
            }
        }



        public void CargarVentas(List<VentaDTO> ventasFiltradas = null)
        {
            // Obtener todas las ventas si no se pasa una lista filtrada
            var ventas = ventasFiltradas ?? ventasService.ObtenerVentas();

            // Filtrar ventas solo para el Cajero normal o Cajero principal
            if (_usuarioActual.Rol == "Cajero")
            {
                ventas = ventas.Where(v => v.NombreUsuario == _usuarioActual.NombreUsuario).ToList();
            }




            // Limpiar el DataSource antes de volver a asignar
            DGV_Ventas.DataSource = ventas;

            // Temporalmente permitir que las columnas se generen automáticamente
            DGV_Ventas.AutoGenerateColumns = false; // Deshabilitar generación automática para personalizar

            // Crear columnas personalizadas
            DGV_Ventas.Columns.Clear(); // Limpiar las columnas existentes para evitar duplicados

            // Columna de FolioVenta
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FolioVenta",
                HeaderText = "Folio",
                DataPropertyName = "FolioVenta", // Debe coincidir con la propiedad del DTO
                Width = 200
            });

            // Columna de FechaVenta
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaVenta",
                HeaderText = "Fecha",
                DataPropertyName = "FechaVenta", // Debe coincidir con la propiedad del DTO
                                                 // La columna toma el tamaño que falta
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            // Columna de TotalVenta
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalVenta",
                HeaderText = "Total",
                DataPropertyName = "TotalVenta", // Debe coincidir con la propiedad del DTO
                Width = 200,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato moneda
            });

            // Columna de Usuario
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Usuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario", // Debe coincidir con la propiedad del DTO
                Width = 350
            });

            // Columna de Estado
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado", // Debe coincidir con la propiedad del DTO
                Width = 300
            });

            // Asignar el DataSource con las ventas filtradas
            DGV_Ventas.DataSource = ventas;

            // Personalizar la tabla
            personalizarTabla();
        }

        public void personalizarTabla()
        {
            // Evitar la selección de encabezados cuando se hace clic en las celdas
            DGV_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Ventas.RowHeadersVisible = false;

            // Configurar la fuente de las celdas y los encabezados
            DGV_Ventas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DGV_Ventas.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Ventas.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DGV_Ventas.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

            // Configurar el fondo y el color de texto de los encabezados
            DGV_Ventas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_Ventas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_Ventas.EnableHeadersVisualStyles = false;

            // Alternar colores de las filas
            DGV_Ventas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_Ventas.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

            //Poner el contenido de la tabla en medio
            DGV_Ventas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Ventas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Eliminar el contorno de las celdas
            DGV_Ventas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Ventas.RowHeadersVisible = false;

            // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
            DGV_Ventas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro
            DGV_Ventas.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco
        }

        private void B_MostrarDetalles_Click(object sender, EventArgs e)
        {
            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];

                    if (filaSeleccionada.Cells["FolioVenta"].Value != null && int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int FolioVenta))
                    {
                        if (FolioVenta > 0)
                        {
                            // Crear el formulario de modificación de compra
                            V_MostrarDetallesVenta MostrarDetallesVentaForm = new V_MostrarDetallesVenta(FolioVenta);

                            // Mostrar el formulario y verificar si se cerró con éxito (DialogResult.OK)
                            if (MostrarDetallesVentaForm.ShowDialog() == DialogResult.OK)
                            {
                                // Recargar la tabla de compras solo si la modificación fue exitosa
                                CargarVentas();
                            }

                        }
                        else // Si el ID de la compra no es válido
                        {
                            CustomMessageBox.Show("El folio de la venta no es válido.", "Error");
                        }

                    }
                    else // Si el ID de la compra no es válido
                    {
                        CustomMessageBox.Show("No se pudo obtener el ID de la compra seleccionada. Asegúrate de que esté correctamente seleccionado.", "Error");
                    }
                }
                catch (Exception ex) // Si no se seleccionó ninguna fila
                {
                    CustomMessageBox.Show($"Error al convertir el ID de la compra: {ex.Message}", "Error");
                }
            }
            else // Si no se seleccionó ninguna fila
            {
                CustomMessageBox.Show("Selecciona una venta para modificar.", "Error");
            }
        }

        private void B_ModificarVenta_Click(object sender, EventArgs e)
        {
            VerificarPermisosVentaSeleccionada();

            // Si el botón está habilitado, procede a abrir el formulario de modificación
            if (B_ModificarVenta.Enabled)
            {
                // Código para abrir el formulario de modificación
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                    if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                    {
                        using (V_ModificarVenta modificarVentaForm = new V_ModificarVenta(folioVenta, new POSContext(new DbContextOptions<POSContext>())))
                        {
                            if (modificarVentaForm.ShowDialog() == DialogResult.OK)
                            {
                                CargarVentas();
                            }
                        }
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede modificar esta venta ya que el corte está realizado.", "Acción no permitida");
                //activar botones
                B_ModificarVenta.Enabled = true;
                B_CancelarVenta.Enabled = true;
            }
        }

        private void TB_BuscarVenta_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        private void AplicarFiltros()
        {
            // Verificar si la lista _ventas está inicializada
            if (_ventas == null)
            {
                _ventas = ventasService.ObtenerVentas();
            }

            string filtro = TB_BuscarVenta.Text.ToLower();

            // Filtrar las ventas por Folio y Usuario
            try
            {
                var ventasFiltradas = _ventas
                    .Where(v =>
                        (v.FolioVenta != null && v.FolioVenta.ToString().Contains(filtro)) ||  // Verificar que FolioVenta no sea null
                        (!string.IsNullOrEmpty(v.Usuario) && v.Usuario.ToLower().Contains(filtro))  // Filtrar por Usuario si no es null
                    )
                    .ToList();

                // Actualizar la tabla con las ventas filtradas
                CargarVentas(ventasFiltradas);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error al filtrar ventas");
            }
        }


        private void B_BuscarPorFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = DTP_Desde.Value.Date;
            DateTime hasta = DTP_Hasta.Value.Date;

            // Obtener ventas filtradas por fechas
            var ventasFiltradas = ventasService.ObtenerVentasPorFecha(desde, hasta);

            // Cargar ventas filtradas en el DataGridView
            CargarVentas(ventasFiltradas);
        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        // Método para configurar los permisos según el rol del usuario
        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarVenta.Enabled = false;
                B_CancelarVenta.Enabled = false;

                B_ModificarVenta.Visible = false;
                B_CancelarVenta.Visible = false;

                DTP_Desde.Enabled = false;
                DTP_Hasta.Enabled = false;

                B_BuscarPorFecha.Enabled = false;

                DTP_Desde.Visible = false;
                DTP_Hasta.Visible = false;

                B_BuscarPorFecha.Visible = false;

                label1.Visible = false;
                label2.Visible = false;


            }
        }

        private void B_CancelarVenta_Click(object sender, EventArgs e)
        {
            VerificarPermisosVentaSeleccionada();

            // Si el botón está habilitado, procede a cambiar el estado de la venta
            if (B_CancelarVenta.Enabled)
            {
                // Código para cambiar el estado de la venta
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                    if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                    {
                        string estadoActual = filaSeleccionada.Cells["Estado"].Value.ToString();
                        string nuevoEstado = estadoActual == "Realizada" ? "Cancelada" : "Realizada";

                        DialogResult result = CustomMessageBox.Show($"¿Está seguro que desea cambiar el estado de la venta a {nuevoEstado}?",
                            "Confirmar cambio de estado");

                        if (result == DialogResult.Yes)
                        {
                            ventasService.CambiarEstadoVenta(folioVenta, nuevoEstado);
                            CargarVentas();
                            CustomMessageBox.Show($"El estado de la venta fue cambiado a {nuevoEstado}.", "Estado actualizado");
                        }
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede cancelar esta venta ya que el corte está realizado.", "Acción no permitida");
                B_ModificarVenta.Enabled = true;
                B_CancelarVenta.Enabled = true;
            }
        }

        private void B_Ticket_Click(object sender, EventArgs e)
        {
            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var filaSeleccionada = DGV_Ventas.SelectedRows[0];

                if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                {
                    try
                    {
                        // Obtener los detalles de la venta seleccionada
                        var ventaSeleccionada = ventasService.ObtenerVentaPorFolio(folioVenta);
                        var detallesVenta = ventasService.ObtenerDetallesVentaPorFolio(folioVenta);

                        if (ventaSeleccionada != null && detallesVenta != null && detallesVenta.Count > 0)
                        {
                            // Generar el ticket
                            TicketGenerator ticketGenerator = new TicketGenerator();
                            ticketGenerator.GenerarTicketPDF(ventaSeleccionada, detallesVenta);

                            MessageBox.Show("El ticket ha sido generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron detalles para esta venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una venta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una venta para reimprimir el ticket.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Metodo de atajos para los botones que no sea keydown y sea con control al incio
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.K))
            {
                B_Ticket.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_ModificarVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                B_MostrarDetalles.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Ventas.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarVenta.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

