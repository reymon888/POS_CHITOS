using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Clientes
{
    public class V_ClienteDetalle : Form
    {
        private static readonly Color Primary = Color.FromArgb(26, 77, 128);
        private static readonly Color TextDim = Color.DimGray;

        private readonly TableLayoutPanel _grid = new();
        private readonly List<Label> _wrapLabels = new(); // labels que deben envolver (Dirección)

        public V_ClienteDetalle(ClientesDTO c)
        {
            // Ventana estable (no se achica sola)
            Text = "Detalle del cliente";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = MinimizeBox = false;
            ShowInTaskbar = false;
            KeyPreview = true;
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 14f);

            Width = 780;                         // ancho cómodo
            MinimumSize = new Size(640, 420);    // por si alguien reduce
            Padding = new Padding(0);

            KeyDown += (_, e) => { if (e.KeyCode == Keys.Escape) Close(); };

            // Header
            var header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                BackColor = Primary,
                Padding = new Padding(16, 10, 16, 8)
            };
            var title = new Label
            {
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Text = "Detalle del cliente"
            };
            var subtitle = new Label
            {
                AutoSize = true,
                ForeColor = Color.WhiteSmoke,
                Margin = new Padding(0, 4, 0, 0),
                Text = c?.Nombre ?? ""
            };
            header.Controls.Add(title);
            header.Controls.Add(subtitle);
            subtitle.Location = new Point(title.Left, title.Bottom - 2);

            // Body
            var body = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16) };

            _grid.Dock = DockStyle.Top;
            _grid.AutoSize = true;
            _grid.ColumnCount = 2;
            _grid.Padding = new Padding(0, 0, 0, 8);
            _grid.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));        // etiqueta
            _grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));   // valor

            void Row(string label, string value, bool wrap = false)
            {
                var l = new Label
                {
                    AutoSize = true,
                    ForeColor = TextDim,
                    Text = label + ":",
                    Margin = new Padding(0, 6, 16, 6)
                };
                var v = new Label
                {
                    AutoSize = true,
                    Text = value ?? "",
                    Margin = new Padding(0, 6, 0, 6)
                };
                if (wrap) _wrapLabels.Add(v);

                _grid.Controls.Add(l);
                _grid.Controls.Add(v);
            }

            Label EstadoBadge(string estado)
            {
                bool ok = string.Equals(estado, "Habilitado", StringComparison.OrdinalIgnoreCase);
                return new Label
                {
                    AutoSize = true,
                    ForeColor = Color.White,
                    BackColor = ok ? Color.FromArgb(46, 160, 67) : Color.FromArgb(220, 76, 70),
                    Text = string.IsNullOrWhiteSpace(estado) ? "-" : estado,
                    Padding = new Padding(10, 4, 10, 4),
                    Margin = new Padding(0, 6, 0, 6)
                };
            }

            Row("Nombre", c?.Nombre);
            Row("Teléfono", c?.Telefono);
            Row("RFC", c?.RFC);
            Row("Email", c?.Email);
            Row("Dirección", c?.Direccion, wrap: true);   // <- se envuelve
            // Estado con badge
            var lEstado = new Label { AutoSize = true, ForeColor = TextDim, Text = "Estado:", Margin = new Padding(0, 6, 16, 6) };
            var vEstado = EstadoBadge(c?.Estado);
            _grid.Controls.Add(lEstado);
            _grid.Controls.Add(vEstado);

            body.Controls.Add(_grid);

            // Footer
            var footer = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(0, 10, 0, 10),
                AutoSize = true
            };
            var btnCerrar = new Button { Text = "Cerrar", AutoSize = true };
            btnCerrar.Click += (_, __) => Close();
            footer.Controls.Add(btnCerrar);
            AcceptButton = btnCerrar;

            Controls.Add(footer);
            Controls.Add(body);
            Controls.Add(header);

            // Ajusta el ancho máximo de las labels "wrap" cuando se muestre o se redimensione
            Shown += (_, __) => UpdateWrapWidths();
            Resize += (_, __) => UpdateWrapWidths();
        }

        private void UpdateWrapWidths()
        {
            // ancho de la primera columna (etiquetas)
            int leftCol = 0;
            foreach (Control ctl in _grid.Controls)
                if (_grid.GetColumn(ctl) == 0)
                    leftCol = Math.Max(leftCol, ctl.PreferredSize.Width);

            // espacio disponible para valores = ancho del grid menos columna 0 y márgenes
            int available = Math.Max(300, _grid.ClientSize.Width - leftCol - 24);
            foreach (var v in _wrapLabels)
                v.MaximumSize = new Size(available, 0);
        }
    }
}