using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Compras;
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
    public partial class V_MenuCompras : Form
    {
        private Usuario _usuarioActual;  // Usuario actual
        private readonly ComprasService _comprasService;
        private List<CompraDTO> _compras;
        public V_MenuCompras(int idusuario, POSContext context)
        {
            InitializeComponent();
            _usuarioActual = context.Usuarios.Find(idusuario);
            _comprasService = new ComprasService(context);

            ConfigurarPermisos();
            // Cargar las compras al abrir el formulario
            CargarCompras();


        }
        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarCompra.Enabled = false;
                B_CancelarCompra.Enabled = false;
                B_ModificarCompra.Visible = false;
                B_CancelarCompra.Visible = false;

                DTP_Desde.Visible = false;
                DTP_Hasta.Visible = false;
                B_BuscarPorFecha.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
        private void VerificarPermisosCompraSeleccionada()
        {
            // Asegurarse de que _compras está inicializado
            if (_compras == null)
            {
                _compras = _comprasService.ListarCompras();
            }

            B_ModificarCompra.Enabled = false;
            B_CancelarCompra.Enabled = false;

            if (DGV_Compras.SelectedRows.Count > 0)
            {
                var filaSeleccionada = DGV_Compras.SelectedRows[0];
                if (filaSeleccionada.Cells["idCompra"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["idCompra"].Value.ToString(), out int idCompra))
                {
                    // Obtener la compra seleccionada y verificar el estado del corte
                    var compraSeleccionada = _compras.FirstOrDefault(c => c.idCompra == idCompra);
                    if (compraSeleccionada != null && compraSeleccionada.EstadoCorte != "Realizado")
                    {
                        B_ModificarCompra.Enabled = true;
                        B_CancelarCompra.Enabled = true;
                    }
                }
            }
        }


        public void CargarCompras()
        {
            try
            {
                // Forzar la obtención de datos actualizados desde la base de datos
                var compras = _comprasService.ListarCompras();

                // Filtrar compras solo para el Cajero normal o Cajero Principal
                if (_usuarioActual.Rol == "Cajero" || _usuarioActual.Rol == "Cajero Principal")
                {
                    // Mostrar solo las compras registradas por el cajero actual (basado en el nombre de usuario)
                    compras = compras.Where(v => v.NombreUsuario == _usuarioActual.NombreUsuario).ToList();
                }

                // Limpiar el DataSource antes de volver a asignar
                DGV_Compras.DataSource = null;

                // Temporalmente permitir que las columnas se generen automáticamente
                DGV_Compras.AutoGenerateColumns = true;

                // Asignar el DataSource
                DGV_Compras.DataSource = compras;

                ConfigurarColumnasDGV();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error al cargar las compras: {ex.Message}", "Error");
            }
        }


        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarCompras();
        }

        public void abrirdetallones()
        {
            if (DGV_Compras.SelectedRows.Count > 0)
            {
                var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);
                V_MostrarDetallesCompras detallesForm = new V_MostrarDetallesCompras(idCompra);
                detallesForm.ShowDialog();
            }
            else
            {
                CustomMessageBox.Show("Seleccione una compra para ver los detalles", "Mensaje");
            }
        }

        private void B_MostrarDetalles_Click(object sender, EventArgs e)
        {
            abrirdetallones();
        }


        private void B_ModificarCompra_Click(object sender, EventArgs e)
        {
            VerificarPermisosCompraSeleccionada();

            // Si el botón está habilitado, procede a abrir el formulario de modificación
            if (B_ModificarCompra.Enabled)
            {
                if (DGV_Compras.SelectedRows.Count > 0)
                {
                    try
                    {
                        var selectedRow = DGV_Compras.SelectedRows[0];

                        if (selectedRow.Cells["idCompra"].Value != null &&
                            int.TryParse(selectedRow.Cells["idCompra"].Value.ToString(), out int idCompra))
                        {
                            if (idCompra > 0)
                            {
                                V_ModificarCompra modificarCompraForm = new V_ModificarCompra(idCompra);
                                if (modificarCompraForm.ShowDialog() == DialogResult.OK)
                                {
                                    CargarCompras();
                                }
                            }
                            else
                            {
                                CustomMessageBox.Show("El ID de la compra no es válido.", "Error");
                            }
                        }
                        else
                        {
                            CustomMessageBox.Show("No se pudo obtener el ID de la compra seleccionada.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show($"Error al modificar la compra: {ex.Message}", "Error");
                    }
                }
                else
                {
                    CustomMessageBox.Show("Seleccione una compra para modificar.", "Mensaje");
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede modificar esta compra porque pertenece a un corte realizado.", "Acción no permitida");
                B_ModificarCompra.Enabled = true;
                B_CancelarCompra.Enabled = true;
            }
        }

        private void B_CancelarCompra_Click(object sender, EventArgs e)
        {
            VerificarPermisosCompraSeleccionada();

            // Si el botón está habilitado, procede a cambiar el estado de la compra
            if (B_CancelarCompra.Enabled)
            {
                if (DGV_Compras.SelectedRows.Count > 0)
                {
                    var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);
                    var estado = DGV_Compras.SelectedRows[0].Cells["Estado"].Value.ToString();

                    if (estado == "Realizada")
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro de cancelar la compra? Los productos de esta compra serán reducidos del stock.",
                                                           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmacion == DialogResult.Yes)
                        {
                            _comprasService.CambiarEstadoCompra(idCompra, "Cancelada");
                            CargarCompras();
                        }
                    }
                    else if (estado == "Cancelada")
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro de reactivar la compra?",
                                                           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmacion == DialogResult.Yes)
                        {
                            _comprasService.CambiarEstadoCompra(idCompra, "Realizada");
                            CargarCompras();
                        }
                    }
                }
                else
                {
                    CustomMessageBox.Show("Seleccione una compra para cancelar o reactivar.", "Mensaje");
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede cancelar esta compra porque pertenece a un corte realizado.", "Acción no permitida");
                B_ModificarCompra.Enabled = true;
                B_CancelarCompra.Enabled = true;
            }
        }

        private void TB_BuscarCompra_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string filtro = TB_BuscarCompra.Text.ToLower();

            // Obtener las compras y filtrar por FolioCompraOriginal
            var comprasFiltradas = _comprasService.ListarCompras()
                .Where(c => c.FolioCompraOriginal.ToLower().Contains(filtro)) // Filtrar por FolioCompraOriginal
                .ToList();

            // Asignar las compras filtradas al DataGridView
            DGV_Compras.DataSource = null;
            DGV_Compras.DataSource = comprasFiltradas;
            ConfigurarColumnasDGV();
        }

        private void B_BuscarPorFecha_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas en los DateTimePickers
            DateTime fechaDesde = DTP_Desde.Value.Date;
            DateTime fechaHasta = DTP_Hasta.Value.Date;

            // Verificar que la fecha "Desde" no sea mayor a la fecha "Hasta"
            if (fechaDesde > fechaHasta)
            {
                CustomMessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Error");
                return;
            }

            // Filtrar las compras por el rango de fechas
            var comprasFiltradas = _comprasService.ListarComprasPorFecha(fechaDesde, fechaHasta);

            // Asignar las compras filtradas al DataGridView
            DGV_Compras.DataSource = null;
            DGV_Compras.DataSource = comprasFiltradas;
            ConfigurarColumnasDGV();
        }

        private void ConfigurarColumnasDGV()
        {
            // ID Compra
            if (DGV_Compras.Columns["idCompra"] != null)
            {
                DGV_Compras.Columns["idCompra"].HeaderText = "ID Compra";
                DGV_Compras.Columns["idCompra"].Width = 100;
            }

            // Folio Compra Original
            if (DGV_Compras.Columns["FolioCompraOriginal"] != null)
            {
                DGV_Compras.Columns["FolioCompraOriginal"].HeaderText = "Folio Compra";
                DGV_Compras.Columns["FolioCompraOriginal"].Width = 160;
            }

            // Proveedor
            if (DGV_Compras.Columns["NombreProveedor"] != null)
            {
                DGV_Compras.Columns["NombreProveedor"].HeaderText = "Proveedor";
                DGV_Compras.Columns["NombreProveedor"].Width = 330;
            }

            // Nombre Usuario
            if (DGV_Compras.Columns["NombreUsuario"] != null)
            {
                DGV_Compras.Columns["NombreUsuario"].HeaderText = "Nombre Usuario";
                DGV_Compras.Columns["NombreUsuario"].Width = 350;
            }

            // Fecha de Compra
            if (DGV_Compras.Columns["FechaCompra"] != null)
            {
                DGV_Compras.Columns["FechaCompra"].HeaderText = "Fecha de Compra";
                DGV_Compras.Columns["FechaCompra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Total Compra
            if (DGV_Compras.Columns["TotalCompra"] != null)
            {
                DGV_Compras.Columns["TotalCompra"].HeaderText = "Total";
                DGV_Compras.Columns["TotalCompra"].Width = 200;
            }

            // Estado
            if (DGV_Compras.Columns["Estado"] != null)
            {
                DGV_Compras.Columns["Estado"].HeaderText = "Estado";
                DGV_Compras.Columns["Estado"].Width = 200;
            }
            //Ocultar la columna de estado del corte
            if (DGV_Compras.Columns["EstadoCorte"] != null)
            {
                DGV_Compras.Columns["EstadoCorte"].Visible = false;
            }

            // Evitar la selección de encabezados cuando se hace clic en las celdas
            DGV_Compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Compras.RowHeadersVisible = false;

            // Configurar la fuente de las celdas y los encabezados
            DGV_Compras.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DGV_Compras.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Compras.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DGV_Compras.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

            // Configurar el fondo y el color de texto de los encabezados
            DGV_Compras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_Compras.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_Compras.EnableHeadersVisualStyles = false;

            // Alternar colores de las filas
            DGV_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_Compras.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

            // Poner el contenido de la tabla en medio
            DGV_Compras.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Compras.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Eliminar el contorno de las celdas
            DGV_Compras.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Compras.RowHeadersVisible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarCompra.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_CancelarCompra.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                B_MostrarDetalles.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Compras.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarCompra.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
