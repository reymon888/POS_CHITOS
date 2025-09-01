using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Utils
{
    using System.Drawing;
    using System.Windows.Forms;
    using System.Reflection;
    public static class dgvExtensions
    {
        // Tema base (no toca las columnas)
        public static void ApplyTheme(this DataGridView dgv, bool compacto = false, Color? headerBack = null, Color? selBack = null)
        {
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 234, 238);

            // Encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBack ?? Color.FromArgb(27, 59, 90);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = compacto ? 32 : 38;

            // Celdas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(34, 48, 60);
            dgv.DefaultCellStyle.SelectionBackColor = selBack ?? Color.FromArgb(44, 140, 153);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", compacto ? 9.5f : 10.5f);

            // Zebra
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = dgv.DefaultCellStyle.SelectionBackColor;

            // Alturas
            dgv.RowTemplate.Height = compacto ? 28 : 34;

            // Anti-flicker (propiedad no pública)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

            // Helpers de formato/alineacion
            
            public static void Right(this DataGridView dgv, params string[] cols) => SetAlign(dgv, DataGridViewContentAlignment.MiddleRight, cols);
            public static void Center(this DataGridView dgv, params string[] cols) => SetAlign(dgv, DataGridViewContentAlignment.MiddleCenter, cols);

            public static void FormatCurrency(this DataGridView dgv, params string[] cols) => SetFormat(dgv, "C2", cols);

            public static void FormatInt(this DataGridView dgv, params string[] cols) => SetFormat(dgv, "N0", cols);

            public static void PillByValue(this DataGridView dgv, string propName,
                string good = "Habilitado", string bad = "Deshabilitado")
        {
            dgv.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                var col = dgv.Columns[e.ColumnIndex];
                // Compara por DataPropertyName
                if (col.DataPropertyName != propName) return;

                var val = e.Value as string;
                var cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (val == good)
                {
                    cell.Style.BackColor = Color.FromArgb(220, 247, 230);
                    cell.Style.ForeColor = Color.FromArgb(22, 115, 71);
                }
                else if (val == bad)
                {
                    cell.Style.BackColor = Color.FromArgb(253, 229, 222);
                    cell.Style.ForeColor = Color.FromArgb(160, 29, 19);
                }
            };
        }

        // ---- privados ----
        static void SetAlign(DataGridView dgv, DataGridViewContentAlignment a, string[] cols)
        {
            foreach (var key in cols)
                if (TryGetColumn(dgv, key, out var c))
                    c.DefaultCellStyle.Alignment = a;
        }

        static void SetFormat(DataGridView dgv, string fmt, string[] cols)
        {
            foreach (var key in cols)
                if (TryGetColumn(dgv, key, out var c))
                    c.DefaultCellStyle.Format = fmt;
        }

        // Busca por Name o por DataPropertyName (para que no truene)
        static bool TryGetColumn(DataGridView dgv, string key, out DataGridViewColumn col)
        {
            col = dgv.Columns[key];
            if (col != null) return true;

            foreach (DataGridViewColumn c in dgv.Columns)
                if (c.DataPropertyName == key) { col = c; return true; }

            return false;
        }
    }

}

