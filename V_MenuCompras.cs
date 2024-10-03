using Microsoft.EntityFrameworkCore;
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

        private readonly ComprasService _comprasService;
        public V_MenuCompras(POSContext context)
        {
            InitializeComponent();

            _comprasService = new ComprasService(context);

            // Cargar las compras al abrir el formulario
            CargarCompras();

            // Configurar el DateTimePicker
            ConfigurarDateTimePicker();
        }

        public void CargarCompras()
        {
            try
            {
                // Forzar la obtención de datos actualizados desde la base de datos
                var compras = _comprasService.ListarCompras();

                // Limpiar el DataSource antes de volver a asignar
                DGV_Compras.DataSource = null;

                // Temporalmente permitir que las columnas se generen automáticamente
                DGV_Compras.AutoGenerateColumns = true; // Habilitar generación automática

                // Asignar el DataSource
                DGV_Compras.DataSource = compras;

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
                    DGV_Compras.Columns["NombreProveedor"].Width = 240;
                }

                // Nombre Usuario
                if (DGV_Compras.Columns["NombreUsuario"] != null)
                {
                    DGV_Compras.Columns["NombreUsuario"].HeaderText = "Nombre Usuario";
                    DGV_Compras.Columns["NombreUsuario"].Width = 200;
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
                    DGV_Compras.Columns["TotalCompra"].Width = 140;
                }

                // Estado
                if (DGV_Compras.Columns["Estado"] != null)
                {
                    DGV_Compras.Columns["Estado"].HeaderText = "Estado";
                    DGV_Compras.Columns["Estado"].Width = 140;
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

                //Poner el contenido de la tabla en medio
                DGV_Compras.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_Compras.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Eliminar el contorno de las celdas
                DGV_Compras.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DGV_Compras.RowHeadersVisible = false;


                // Verificar las columnas presentes en el DataGridView


                // Temporalmente comentar esta parte para evitar confusión con columnas personalizadas
                /*
                DGV_Compras.AutoGenerateColumns = false;

                // Limpiar las columnas anteriores
                DGV_Compras.Columns.Clear();

                // ID Compra
                DataGridViewTextBoxColumn idCompraColumn = new DataGridViewTextBoxColumn();
                idCompraColumn.DataPropertyName = "idCompra"; // Asegúrate de que el nombre sea correcto
                idCompraColumn.HeaderText = "ID Compra";
                idCompraColumn.Width = 100;
                DGV_Compras.Columns.Add(idCompraColumn);

                // Folio Compra Original
                DataGridViewTextBoxColumn folioCompraColumn = new DataGridViewTextBoxColumn();
                folioCompraColumn.DataPropertyName = "FolioCompraOriginal";  // Nombre correcto
                folioCompraColumn.HeaderText = "Folio Compra";
                folioCompraColumn.Width = 160;
                DGV_Compras.Columns.Add(folioCompraColumn);

                // Proveedor
                DataGridViewTextBoxColumn proveedorColumn = new DataGridViewTextBoxColumn();
                proveedorColumn.DataPropertyName = "NombreProveedor";
                proveedorColumn.HeaderText = "Proveedor";
                proveedorColumn.Width = 240;
                DGV_Compras.Columns.Add(proveedorColumn);

                // Nombre Usuario
                DataGridViewTextBoxColumn nombreUsuarioColumn = new DataGridViewTextBoxColumn();
                nombreUsuarioColumn.DataPropertyName = "NombreUsuario";
                nombreUsuarioColumn.HeaderText = "Nombre Usuario";
                nombreUsuarioColumn.Width = 200;
                DGV_Compras.Columns.Add(nombreUsuarioColumn);

                // Fecha de Compra
                DataGridViewTextBoxColumn fechaCompraColumn = new DataGridViewTextBoxColumn();
                fechaCompraColumn.DataPropertyName = "FechaCompra";
                fechaCompraColumn.HeaderText = "Fecha de Compra";
                fechaCompraColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGV_Compras.Columns.Add(fechaCompraColumn);

                // Total Compra
                DataGridViewTextBoxColumn totalCompraColumn = new DataGridViewTextBoxColumn();
                totalCompraColumn.DataPropertyName = "TotalCompra";
                totalCompraColumn.HeaderText = "Total";
                totalCompraColumn.Width = 140;
                DGV_Compras.Columns.Add(totalCompraColumn);

                // Estado
                DataGridViewTextBoxColumn estadoColumn = new DataGridViewTextBoxColumn();
                estadoColumn.DataPropertyName = "Estado";
                estadoColumn.HeaderText = "Estado";
                estadoColumn.Width = 140;
                DGV_Compras.Columns.Add(estadoColumn);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las compras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Seleccione una compra para ver los detalles.");
            }
        }

        private void B_MostrarDetalles_Click(object sender, EventArgs e)
        {
            abrirdetallones();
        }

        private void ConfigurarDateTimePicker()
        {
            // Establecer un rango de un año atrás hasta el día de hoy
            dateTimePicker1.MinDate = DateTime.Now.AddYears(-1);
            dateTimePicker1.MaxDate = DateTime.Now;

            // Formato que incluye hora
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";

        }

        private void B_ModificarCompra_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (DGV_Compras.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    var selectedRow = DGV_Compras.SelectedRows[0];

                    // Verificar si la celda "idCompra" no es nula y contiene un valor válido
                    if (selectedRow.Cells["idCompra"].Value != null && int.TryParse(selectedRow.Cells["idCompra"].Value.ToString(), out int idCompra))
                    {
                        if (idCompra > 0)
                        {
                            // Crear el formulario de modificación de compra
                            V_ModificarCompra modificarCompraForm = new V_ModificarCompra(idCompra);

                            // Mostrar el formulario y verificar si se cerró con éxito (DialogResult.OK)
                            if (modificarCompraForm.ShowDialog() == DialogResult.OK)
                            {
                                // Recargar la tabla de compras solo si la modificación fue exitosa
                                CargarCompras();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El ID de la compra no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el ID de la compra seleccionada. Asegúrate de que esté correctamente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al convertir el ID de la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una compra para modificar.");
            }
        }

        private void B_CancelarCompra_Click(object sender, EventArgs e)
        {
            //Cambiar estado de la compra si esta realizada que se cancele y si esta cancelada que se realice pero que pregunte
            if (DGV_Compras.SelectedRows.Count > 0)
            {
                var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);
                var estado = DGV_Compras.SelectedRows[0].Cells["Estado"].Value.ToString();

                if (estado == "Realizada")
                {
                    var confirmacion = MessageBox.Show("¿Está seguro de cancelar la compra? Los productos de esta compra seran reducidos del stock", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        _comprasService.CambiarEstadoCompra(idCompra, "Cancelada");
                        CargarCompras();
                    }
                }
                else if (estado == "Cancelada")
                {
                    var confirmacion = MessageBox.Show("¿Está seguro de reactivar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        _comprasService.CambiarEstadoCompra(idCompra, "Realizada");
                        CargarCompras();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una compra para cancelar o reactivar.");
            }
        }
    }
}
