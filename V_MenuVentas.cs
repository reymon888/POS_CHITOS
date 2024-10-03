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
    public partial class V_MenuVentas : Form
    {
        private readonly VentasService ventasService;
        public V_MenuVentas(POSContext context)
        {
            InitializeComponent();
            ventasService = new VentasService(context);

            CargarVentas();
        }

        public void CargarVentas()
        {
            // Obtener las ventas desde el servicio
            var ventas = ventasService.ObtenerVentas();

            // Limpiar el DataSource antes de volver a asignar
            DGV_Ventas.DataSource = null;

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
                // la columna tome el tamano que falta 
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            // Columna de TotalVenta
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalVenta",
                HeaderText = "Total",
                DataPropertyName = "TotalVenta", // Debe coincidir con la propiedad del DTO
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato moneda
            });

            // Columna de Usuario
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Usuario",
                HeaderText = "Usuario",
                DataPropertyName = "Usuario", // Debe coincidir con la propiedad del DTO
                Width = 200
            });

            // Columna de Estado
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado", // Debe coincidir con la propiedad del DTO
                Width = 200
            });

            // Asignar el DataSource
            DGV_Ventas.DataSource = ventas;

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
                            MessageBox.Show("El folio de la venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else // Si el ID de la compra no es válido
                    {
                        MessageBox.Show("No se pudo obtener el ID de la compra seleccionada. Asegúrate de que esté correctamente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Si no se seleccionó ninguna fila
                {
                    MessageBox.Show($"Error al convertir el ID de la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Si no se seleccionó ninguna fila
            {
                MessageBox.Show("Selecciona una venta para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_ModificarVenta_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];

                    // Verificar que el valor de la celda "FolioVenta" no sea nulo y convertirlo a entero
                    if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                    {
                        // Verificar que el folio de la venta sea mayor a 0
                        if (folioVenta > 0)
                        {
                            // Crear una nueva instancia del formulario de modificación de la venta
                            using (V_ModificarVenta modificarVentaForm = new V_ModificarVenta(folioVenta, new POSContext(new DbContextOptions<POSContext>())))
                            {
                                // Mostrar el formulario y verificar si se cerró con éxito (DialogResult.OK)
                                if (modificarVentaForm.ShowDialog() == DialogResult.OK)
                                {
                                    // Recargar la tabla de ventas solo si la modificación fue exitosa
                                    CargarVentas();
                                }
                            }
                        }
                        else
                        {
                            // Mostrar mensaje de error si el folio de la venta no es válido
                            MessageBox.Show("El folio de la venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Mostrar mensaje de error si no se pudo obtener el folio de la venta
                        MessageBox.Show("No se pudo obtener el folio de la venta seleccionada. Asegúrate de que esté correctamente seleccionado.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error si ocurrió algún problema durante el proceso
                    MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje de advertencia si no se seleccionó ninguna fila
                MessageBox.Show("Selecciona una venta para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

