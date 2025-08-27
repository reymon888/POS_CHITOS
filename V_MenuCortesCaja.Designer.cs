namespace POS_CHITOS
{
    partial class V_MenuCortesCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_Cortes = new DataGridView();
            panelSuperior = new Panel();
            B_RealizarCorte = new Button();
            B_MostrarDetallesCorte = new Button();
            B_ActualizarTabla = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Cortes).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Cortes
            // 
            DGV_Cortes.AllowUserToAddRows = false;
            DGV_Cortes.AllowUserToResizeColumns = false;
            DGV_Cortes.AllowUserToResizeRows = false;
            DGV_Cortes.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Cortes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Cortes.Dock = DockStyle.Fill;
            DGV_Cortes.Location = new Point(0, 121);
            DGV_Cortes.MultiSelect = false;
            DGV_Cortes.Name = "DGV_Cortes";
            DGV_Cortes.ReadOnly = true;
            DGV_Cortes.RowHeadersVisible = false;
            DGV_Cortes.RowHeadersWidth = 51;
            DGV_Cortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Cortes.Size = new Size(1607, 527);
            DGV_Cortes.TabIndex = 8;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.WhiteSmoke;
            panelSuperior.Controls.Add(B_RealizarCorte);
            panelSuperior.Controls.Add(B_MostrarDetallesCorte);
            panelSuperior.Controls.Add(B_ActualizarTabla);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1607, 121);
            panelSuperior.TabIndex = 7;
            // 
            // B_RealizarCorte
            // 
            B_RealizarCorte.BackColor = Color.WhiteSmoke;
            B_RealizarCorte.Cursor = Cursors.Hand;
            B_RealizarCorte.Dock = DockStyle.Right;
            B_RealizarCorte.FlatAppearance.BorderSize = 0;
            B_RealizarCorte.FlatStyle = FlatStyle.Flat;
            B_RealizarCorte.Font = new Font("Segoe UI", 10.2F);
            B_RealizarCorte.ForeColor = Color.FromArgb(44, 140, 153);
            B_RealizarCorte.Image = Properties.Resources.caja_registradora;
            B_RealizarCorte.Location = new Point(1301, 0);
            B_RealizarCorte.Name = "B_RealizarCorte";
            B_RealizarCorte.Size = new Size(92, 121);
            B_RealizarCorte.TabIndex = 8;
            B_RealizarCorte.Text = "Realizar Corte (Ctrl + F)";
            B_RealizarCorte.TextImageRelation = TextImageRelation.ImageAboveText;
            B_RealizarCorte.UseVisualStyleBackColor = false;
            B_RealizarCorte.Click += B_RealizarCorte_Click;
            // 
            // B_MostrarDetallesCorte
            // 
            B_MostrarDetallesCorte.BackColor = Color.WhiteSmoke;
            B_MostrarDetallesCorte.Cursor = Cursors.Hand;
            B_MostrarDetallesCorte.Dock = DockStyle.Right;
            B_MostrarDetallesCorte.FlatAppearance.BorderSize = 0;
            B_MostrarDetallesCorte.FlatStyle = FlatStyle.Flat;
            B_MostrarDetallesCorte.Font = new Font("Segoe UI", 10.2F);
            B_MostrarDetallesCorte.ForeColor = Color.FromArgb(44, 140, 153);
            B_MostrarDetallesCorte.Image = Properties.Resources.archivo__1_;
            B_MostrarDetallesCorte.Location = new Point(1393, 0);
            B_MostrarDetallesCorte.Name = "B_MostrarDetallesCorte";
            B_MostrarDetallesCorte.Size = new Size(107, 121);
            B_MostrarDetallesCorte.TabIndex = 6;
            B_MostrarDetallesCorte.Text = "Mostrar (Ctrl + D)";
            B_MostrarDetallesCorte.TextImageRelation = TextImageRelation.ImageAboveText;
            B_MostrarDetallesCorte.UseVisualStyleBackColor = false;
            B_MostrarDetallesCorte.Click += B_MostrarDetallesCorte_Click;
            // 
            // B_ActualizarTabla
            // 
            B_ActualizarTabla.BackColor = Color.WhiteSmoke;
            B_ActualizarTabla.Cursor = Cursors.Hand;
            B_ActualizarTabla.Dock = DockStyle.Right;
            B_ActualizarTabla.FlatAppearance.BorderSize = 0;
            B_ActualizarTabla.FlatStyle = FlatStyle.Flat;
            B_ActualizarTabla.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarTabla.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTabla.Image = Properties.Resources.recargar;
            B_ActualizarTabla.Location = new Point(1500, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(107, 121);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            // 
            // V_MenuCortesCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 648);
            Controls.Add(DGV_Cortes);
            Controls.Add(panelSuperior);
            Name = "V_MenuCortesCaja";
            Text = "V_MenuCortesCaja";
            ((System.ComponentModel.ISupportInitialize)DGV_Cortes).EndInit();
            panelSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Cortes;
        private Panel panelSuperior;
        private Button B_MostrarDetallesCorte;
        private Button B_ActualizarTabla;
        private Button B_RealizarCorte;
    }
}