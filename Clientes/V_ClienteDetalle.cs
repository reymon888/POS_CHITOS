using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Clientes
{
    public class V_ClienteDetalle : Form
    {
        public V_ClienteDetalle(ClientesDTO c)
        {
            Text = "Detalle del cliente";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = MinimizeBox = false;
            Padding = new Padding(16);
            Font = new Font("Segoe UI", 10);

            var grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 6,
                AutoSize = true
            };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            void Row(string label, string value)
            {
                var l = new Label { Text = label + ":", AutoSize = true, ForeColor = Color.DimGray, Margin = new Padding(0, 6, 12, 6) };
                var v = new Label { Text = value ?? "", AutoSize = true, MaximumSize = new Size(520, 0) };
                v.Font = new Font(Font, FontStyle.Regular);
                grid.Controls.Add(l);
                grid.Controls.Add(v);
            }

            Row("Nombre", c.Nombre);
            Row("Teléfono", c.Telefono);
            Row("RFC", c.RFC);
            Row("Email", c.Email);
            Row("Dirección", c.Direccion);
            Row("Estado", c.Estado);

            var panel = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Bottom, Padding = new Padding(0, 12, 0, 0) };
            var btnCerrar = new Button { Text = "Cerrar", AutoSize = true };
            btnCerrar.Click += (_, __) => Close();
            panel.Controls.Add(btnCerrar);

            Controls.Add(panel);
            Controls.Add(grid);
            AcceptButton = btnCerrar; // Enter = Cerrar
            Width = 720; // ancho cómodo
        }
    }
    }

