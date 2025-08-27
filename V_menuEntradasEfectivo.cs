using Microsoft.EntityFrameworkCore;
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
    public partial class V_menuEntradasEfectivo : Form
    {
        private readonly int _idUsuario;


        private readonly EntradaEfectivoService _entradaEfectivoService;
        private readonly DbContext _context;
        private Usuario _usuarioActual;  // Usuario actual
        public V_menuEntradasEfectivo(int idUsuario, DbContext context)
        {
            InitializeComponent();
            _usuarioActual = context.Set<Usuario>().Find(idUsuario);
            _idUsuario = idUsuario;

            POSContext contexto = new POSContext(new DbContextOptions<POSContext>());
            _entradaEfectivoService = new EntradaEfectivoService(contexto);


            // Cargar las entradas de efectivo en el DataGridView al iniciar
            CargarEntradasEfectivo();
            ConfigurarEstiloTabla();

            // Configurar los permisos de acuerdo al rol del usuario
            ConfigurarPermisos();

        }

        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarEntrada.Enabled = false;
                B_CambiarEstado.Enabled = false;
            }
           
        }

        private void ConfigurarEstiloTabla()
        {
            // Aplicar el mismo estilo de colores y formato que has estado utilizando
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_EntradasEfectivo.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_EntradasEfectivo.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_EntradasEfectivo.EnableHeadersVisualStyles = false;
            DGV_EntradasEfectivo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_EntradasEfectivo.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_EntradasEfectivo.ClearSelection();

            // Poner el contenido de la tabla en medio
            DGV_EntradasEfectivo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_EntradasEfectivo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_EntradasEfectivo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_EntradasEfectivo.RowHeadersVisible = false;
        }

        private void CargarEntradasEfectivo()
        {
            // Obtener todas las entradas de efectivo desde el servicio
            var entradas = _entradaEfectivoService.ListarEntradasPorUsuario(_idUsuario);

            // Limpiar el DataSource antes de volver a asignar
            DGV_EntradasEfectivo.DataSource = null;

            // Temporalmente permitir que las columnas se generen automáticamente
            DGV_EntradasEfectivo.AutoGenerateColumns = false; // Deshabilitar generación automática para personalizar

            // Crear columnas personalizadas
            DGV_EntradasEfectivo.Columns.Clear(); // Limpiar las columnas existentes para evitar duplicados

            // Columna de idEntrada
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idEntrada",
                HeaderText = "ID Entrada",
                DataPropertyName = "idEntrada", // Debe coincidir con la propiedad del DTO
                Width = 100
            });

            // Columna de Fecha
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha", // Debe coincidir con la propiedad del DTO
                Width = 250
            });

            // Columna de Concepto
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto",
                DataPropertyName = "Concepto", // Debe coincidir con la propiedad del DTO
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Autoajustar la columna para llenar el espacio restante
            });

            // Columna de Monto
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto", // Debe coincidir con la propiedad del DTO
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato de moneda
            });

            // Columna de Usuario
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario", // Debe coincidir con la propiedad del DTO
                Width = 200
            });

            // Columna de Estado
            DGV_EntradasEfectivo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado", // Debe coincidir con la propiedad del DTO
                Width = 150
            });

            // Asignar el DataSource
            DGV_EntradasEfectivo.DataSource = entradas;

            // Aplicar el estilo personalizado
            ConfigurarEstiloTabla();
        }



        private void B_AgregarEntrada_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar una nueva entrada de efectivo
            var formEntrada = new V_AgregarEntrada(_idUsuario, _entradaEfectivoService);
            formEntrada.ShowDialog();

            // Recargar las entradas después de agregar una nueva
            CargarEntradasEfectivo();
        }

        private void B_ModificarEntrada_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView y obtener el id de la entrada y pasarle el concepto y monto
            if (DGV_EntradasEfectivo.SelectedRows.Count > 0)
            {
                int idEntrada = Convert.ToInt32(DGV_EntradasEfectivo.SelectedRows[0].Cells["idEntrada"].Value);
                string concepto = DGV_EntradasEfectivo.SelectedRows[0].Cells["Concepto"].Value.ToString();
                float monto = Convert.ToSingle(DGV_EntradasEfectivo.SelectedRows[0].Cells["Monto"].Value);

                // Abrir el formulario para modificar la entrada de efectivo
                var formModificarEntrada = new V_ModificarEntrada(idEntrada, concepto, monto, _entradaEfectivoService);
                formModificarEntrada.ShowDialog();

                // Recargar las entradas después de modificar una
                CargarEntradasEfectivo();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una entrada de efectivo para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void B_CambiarEstado_Click(object sender, EventArgs e)
        {
            // Cambiar el estado de una entrada de efectivo de Realizado a Cancelado y viceversa
            if (DGV_EntradasEfectivo.SelectedRows.Count > 0)
            {
                int idEntrada = Convert.ToInt32(DGV_EntradasEfectivo.SelectedRows[0].Cells["idEntrada"].Value);
                string estadoActual = DGV_EntradasEfectivo.SelectedRows[0].Cells["Estado"].Value.ToString();

                if (estadoActual == "Realizado")
                {
                    // Cambiar a Cancelado
                    MessageBox.Show("La entrada de efectivo se cambiará a Cancelado, el monto de esta accion sera reducido del corte.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _entradaEfectivoService.CambiarEstado(idEntrada, "Cancelado");
                }
                else
                {
                    // Cambiar a Realizado
                    // Aquí puedes agregar la lógica para cambiar de Cancelado a Realizado
                    MessageBox.Show("La entrada de efectivo se cambiará a Realizado, el monto de esta accion sera agregado al corte.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _entradaEfectivoService.CambiarEstado(idEntrada, "Realizado");


                }

                // Recargar las entradas después de cambiar el estado
                CargarEntradasEfectivo();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una entrada de efectivo para cambiar su estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            //Recargar las entradas de efectivo
            CargarEntradasEfectivo();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarEntrada.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarEntrada.PerformClick();
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
                DGV_EntradasEfectivo.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
