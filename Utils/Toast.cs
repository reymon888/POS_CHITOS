using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace POS_CHITOS.Utils
{
    public enum ToastType { Info, Success, Warning, Error }
    public enum ToastPosition { TopRight, TopLeft, BottomRight, BottomLeft, Center }

    public class Toast : Form
    {
        private readonly System.Windows.Forms.Timer _timer = new() { Interval = 16 }; // ~60 FPS
        private readonly int _holdticks;
        private int _ticks;
        private int _phase; // 0=fade-in, 1=hold, 2=fade-out
        private readonly Label _lbl;

        public Toast(string text, ToastType type, int durationsMs)
        {
            // Apariencia
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            DoubleBuffered = true;
            Opacity = 0;
            BackColor = Color.White;

            // Label
            _lbl = new Label
            {
                AutoSize = false,
                Text = text,
                Font = new Font("Segoe UI", 10f, FontStyle.Regular),
                Padding = new Padding(14, 10, 14, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };
            Controls.Add(_lbl);

            // Colores por tipo
            Color back, fore, border;
            switch (type)
            {
                default:
                case ToastType.Info: back = Color.FromArgb(234, 244, 255); fore = Color.FromArgb(20, 60, 120); border = Color.FromArgb(180, 210, 255); break;
                case ToastType.Success: back = Color.FromArgb(222, 247, 231); fore = Color.FromArgb(22, 115, 71); border = Color.FromArgb(168, 230, 193); break;
                case ToastType.Warning: back = Color.FromArgb(255, 248, 220); fore = Color.FromArgb(142, 90, 0); border = Color.FromArgb(255, 230, 160); break;
                case ToastType.Error: back = Color.FromArgb(253, 229, 222); fore = Color.FromArgb(160, 29, 19); border = Color.FromArgb(245, 190, 180); break;
            }
            BackColor = back;
            _lbl.ForeColor = fore;

            // Bordes redondeados y borde fino
            Paint += (_, e) =>
            {
                using var pen = new Pen(border);
                var rect = ClientRectangle;
                rect.Width -= 1; rect.Height -= 1;
                using var gp = Rounded(rect, 12);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, gp);
            };

            // Tamaño Minimo
            Size = new Size(Math.Max(280, TextRenderer.MeasureText(Text, _lbl.Font).Width + 40), 40);

            // cLICK PARA CERRAR
            Click += (_, __) => BeginFadeOut();
            _lbl.Click += (_, __) => BeginFadeOut();

            // Temporizador
            _holdticks = Math.Max(1, durationsMs / (int)_timer.Interval);
            _timer.Tick += (_, __) => Animate();
        }

        private static GraphicsPath Rounded(Rectangle r, int radius)
        {
            int d = radius * 2;
            var gp = new GraphicsPath();
            gp.AddArc(r.Left, r.Top, d, d, 180, 90);
            gp.AddArc(r.Right - d, r.Top, d, d, 270, 90);
            gp.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            gp.AddArc(r.Left, r.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Región redondeada
            using var gp = Rounded(ClientRectangle, 12);
            Region = new Region(gp);
            _timer.Start();
        }

        private void Animate()
        {
            const double step = 0.08; // velocidad
            _ticks++;

            if (_phase == 0) // fade-in
            {
                Opacity = Math.Min(1.0, Opacity + step);
                if (Opacity >= 1.0) { _phase = 1; _ticks = 0; }
            }
            else if (_phase == 1) // hold
            {
                if (_ticks >= _holdticks) BeginFadeOut();
            }
            else // fade-out
            {
                Opacity = Math.Max(0.0, Opacity - step);
                if (Opacity <= 0) { _timer.Stop(); Close(); }
            }
        }

        private void BeginFadeOut()
        {
            _phase = 2;
            _ticks = 0;
        }

        // API pública
        public static void Show(Form owner, string text, ToastType type = ToastType.Info,
                                int durationMs = 1600, ToastPosition pos = ToastPosition.TopRight, int margin = 16)
        {
            void showImpl()
            {
                var t = new Toast(text, type, durationMs);
                Rectangle area = owner?.Bounds ?? Screen.PrimaryScreen.WorkingArea;

                // posición
                int x, y;
                switch (pos)
                {
                    case ToastPosition.TopLeft:
                        x = area.Left + margin; y = area.Top + margin; break;
                    case ToastPosition.BottomRight:
                        x = area.Right - t.Width - margin; y = area.Bottom - t.Height - margin; break;
                    case ToastPosition.BottomLeft:
                        x = area.Left + margin; y = area.Bottom - t.Height - margin; break;
                    case ToastPosition.Center:
                        x = area.Left + (area.Width - t.Width) / 2; y = area.Top + (area.Height - t.Height) / 2; break;
                    default:
                        x = area.Right - t.Width - margin; y = area.Top + margin; break;
                }

                t.Location = new Point(x, y);
                t.Show(owner);
            }

            // Asegurar hilo UI
            if (owner != null && owner.InvokeRequired) owner.BeginInvoke((Action)showImpl);
            else showImpl();
        }
    }
}

