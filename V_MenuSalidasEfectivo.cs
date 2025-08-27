using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Usuarios;
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
    public partial class V_MenuSalidasEfectivo : Form
    {
        private readonly int _idUsuario;

        private readonly SalidaEfectivo salidaEfectivo;
        private readonly SalidaEfectivoService _salidaEfectivoService;
        private Usuario _usuarioActual;  // Usuario actual
        public V_MenuSalidasEfectivo(int idUsuario, DbContext context)
        {
            InitializeComponent();

            _idUsuario = idUsuario;
            _usuarioActual = context.Set<Usuario>().Find(idUsuario);
            POSContext contexto = new POSContext(new DbContextOptions<POSContext>());
            _salidaEfectivoService = new SalidaEfectivoService(contexto);



            // Configurar los permisos antes de cargar los datos
            ConfigurarPermisos();
            //Cargar las salidas de efectivo en el DataGridView al iniciar
            CargarSalidasEfectivo();
        }


        private void ConfigurarPermisos()
        {
            // Verificar si el usuario es Cajero y deshabilitar botones si es así
            if (_usuarioActual.Rol == "Cajero")
            {
                B_ModificarSalida.Enabled = false;
                B_CambiarEstado.Enabled = false;
            }
           
        }


        // Método para listar todas las salidas, filtrando según el usuario actual
        public void CargarSalidasEfectivo()
        {
            // Obtener todas las salidas de efectivo desde el servicio
            var salidas = _salidaEfectivoService.ListarSalidasPorUsuario(_idUsuario);


            // Limpiar el DataSource antes de volver a asignar
            DGV_SalidasEfectivo.DataSource = null;

            // Temporalmente permitir que las columnas se generen automáticamente
            DGV_SalidasEfectivo.AutoGenerateColumns = false; // Deshabilitar generación automática para personalizar

            // Crear columnas personalizadas
            DGV_SalidasEfectivo.Columns.Clear(); // Limpiar las columnas existentes para evitar duplicados

            // Columna de idSalida
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idSalida",
                HeaderText = "ID Salida",
                DataPropertyName = "idSalida", // Debe coincidir con la propiedad del DTO
                Width = 100
            });

            // Columna de Fecha
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha", // Debe coincidir con la propiedad del DTO
                Width = 250
            });

            // Columna de Concepto
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto",
                DataPropertyName = "Concepto", // Debe coincidir con la propiedad del DTO
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Autoajustar la columna para llenar el espacio restante
            });

            // Columna de Monto
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto", // Debe coincidir con la propiedad del DTO
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato de moneda
            });

            // Columna de Usuario
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario", // Debe coincidir con la propiedad del DTO
                Width = 200
            });

            // Columna de Estado
            DGV_SalidasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado", // Debe coincidir con la propiedad del DTO
                Width = 150
            });

            // Asignar el DataSource
            DGV_SalidasEfectivo.DataSource = salidas;

            // Aplicar el estilo personalizado
            ConfigurarEstiloTabla();
        }

        private void ConfigurarEstiloTabla()
        {
            // Aplicar el mismo estilo de colores y formato que has estado utilizando
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_SalidasEfectivo.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_SalidasEfectivo.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_SalidasEfectivo.EnableHeadersVisualStyles = false;
            DGV_SalidasEfectivo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_SalidasEfectivo.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_SalidasEfectivo.ClearSelection();

            // Poner el contenido de la tabla en medio
            DGV_SalidasEfectivo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SalidasEfectivo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SalidasEfectivo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_SalidasEfectivo.RowHeadersVisible = false;
        }

        private void B_AgregarSalida_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar una nueva entrada de efectivo
            var formSalida = new V_AgregarSalidasEfectivo(_idUsuario, _salidaEfectivoService);
            formSalida.ShowDialog();

            // Recargar las entradas después de agregar una nueva
            CargarSalidasEfectivo();
        }

        private void B_ModificarSalida_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView y obtener el id de la entrada y pasarle el concepto y monto
            if (DGV_SalidasEfectivo.SelectedRows.Count > 0)
            {
                int idSalida = Convert.ToInt32(DGV_SalidasEfectivo.SelectedRows[0].Cells["idSalida"].Value);
                string concepto = DGV_SalidasEfectivo.SelectedRows[0].Cells["Concepto"].Value.ToString();
                float monto = Convert.ToSingle(DGV_SalidasEfectivo.SelectedRows[0].Cells["Monto"].Value);

                // Abrir el formulario para modificar la entrada de efectivo
                var formModificarSalida = new V_ModificarSalidaEfectivo(idSalida, concepto, monto, _salidaEfectivoService);
                formModificarSalida.ShowDialog();

                // Recargar las entradas después de modificar una
                CargarSalidasEfectivo();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una entrada de efectivo para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_CambiarEstado_Click(object sender, EventArgs e)
        {
            //Cambiar el estado de la salida de efectivo seleccionada de Realizado a Cancelado y viceversa y preguntar si esta seguro, eso aectara el corte de caja haciendo useo de mi custommessagebox
            if (DGV_SalidasEfectivo.SelectedRows.Count > 0)
            {
                int idSalida = Convert.ToInt32(DGV_SalidasEfectivo.SelectedRows[0].Cells["idSalida"].Value);
                string estado = DGV_SalidasEfectivo.SelectedRows[0].Cells["Estado"].Value.ToString();

                // Preguntar si está seguro de cambiar el estado
                DialogResult dialogResult = CustomMessageBox.Show("¿Está seguro de cambiar el estado de la salida de efectivo?", "Confirmar");

                if (dialogResult == DialogResult.Yes)
                {
                    // Cambiar el estado de la salida de efectivo
                    if (estado == "Realizado")
                    {
                        _salidaEfectivoService.CambiarEstadoSalida(idSalida, "Cancelado");
                    }
                    else
                    {
                        _salidaEfectivoService.CambiarEstadoSalida(idSalida, "Realizado");
                    }

                    // Recargar las entradas después de cambiar el estado
                    CargarSalidasEfectivo();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una salida de efectivo para cambiar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarSalida.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarSalida.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_CambiarEstado.PerformClick();
                return true;
            }
          
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
           
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_SalidasEfectivo.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
