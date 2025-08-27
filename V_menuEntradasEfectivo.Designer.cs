namespace POS_CHITOS
{
    partial class V_menuEntradasEfectivo
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
            DGV_EntradasEfectivo = new DataGridView();
            panelSuperiorProv = new Panel();
            B_ActualizarTabla = new Button();
            B_AgregarEntrada = new Button();
            B_ModificarEntrada = new Button();
            B_CambiarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_EntradasEfectivo).BeginInit();
            panelSuperiorProv.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_EntradasEfectivo
            // 
            DGV_EntradasEfectivo.AllowUserToAddRows = false;
            DGV_EntradasEfectivo.AllowUserToResizeColumns = false;
            DGV_EntradasEfectivo.AllowUserToResizeRows = false;
            DGV_EntradasEfectivo.BackgroundColor = SystemColors.ControlLightLight;
            DGV_EntradasEfectivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_EntradasEfectivo.Dock = DockStyle.Fill;
            DGV_EntradasEfectivo.Location = new Point(0, 130);
            DGV_EntradasEfectivo.MultiSelect = false;
            DGV_EntradasEfectivo.Name = "DGV_EntradasEfectivo";
            DGV_EntradasEfectivo.ReadOnly = true;
            DGV_EntradasEfectivo.RowHeadersWidth = 51;
            DGV_EntradasEfectivo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_EntradasEfectivo.Size = new Size(1814, 582);
            DGV_EntradasEfectivo.TabIndex = 4;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(B_AgregarEntrada);
            panelSuperiorProv.Controls.Add(B_ModificarEntrada);
            panelSuperiorProv.Controls.Add(B_CambiarEstado);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1814, 130);
            panelSuperiorProv.TabIndex = 3;
            // 
            // B_ActualizarTabla
            // 
            B_ActualizarTabla.BackColor = SystemColors.ControlLightLight;
            B_ActualizarTabla.Cursor = Cursors.Hand;
            B_ActualizarTabla.Dock = DockStyle.Right;
            B_ActualizarTabla.FlatAppearance.BorderSize = 0;
            B_ActualizarTabla.FlatStyle = FlatStyle.Flat;
            B_ActualizarTabla.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarTabla.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTabla.Image = Properties.Resources.recargar;
            B_ActualizarTabla.Location = new Point(1422, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(95, 130);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            B_ActualizarTabla.Click += B_ActualizarTabla_Click;
            // 
            // B_AgregarEntrada
            // 
            B_AgregarEntrada.BackColor = SystemColors.ControlLightLight;
            B_AgregarEntrada.Cursor = Cursors.Hand;
            B_AgregarEntrada.Dock = DockStyle.Right;
            B_AgregarEntrada.FlatAppearance.BorderSize = 0;
            B_AgregarEntrada.FlatStyle = FlatStyle.Flat;
            B_AgregarEntrada.Font = new Font("Segoe UI", 10.2F);
            B_AgregarEntrada.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarEntrada.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarEntrada.Location = new Point(1517, 0);
            B_AgregarEntrada.Name = "B_AgregarEntrada";
            B_AgregarEntrada.Size = new Size(101, 130);
            B_AgregarEntrada.TabIndex = 3;
            B_AgregarEntrada.Text = "Agregar (Ctrl + N)";
            B_AgregarEntrada.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarEntrada.UseVisualStyleBackColor = false;
            B_AgregarEntrada.Click += B_AgregarEntrada_Click;
            // 
            // B_ModificarEntrada
            // 
            B_ModificarEntrada.BackColor = SystemColors.ControlLightLight;
            B_ModificarEntrada.Cursor = Cursors.Hand;
            B_ModificarEntrada.Dock = DockStyle.Right;
            B_ModificarEntrada.FlatAppearance.BorderSize = 0;
            B_ModificarEntrada.FlatStyle = FlatStyle.Flat;
            B_ModificarEntrada.Font = new Font("Segoe UI", 10.2F);
            B_ModificarEntrada.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarEntrada.Image = Properties.Resources.circulo;
            B_ModificarEntrada.Location = new Point(1618, 0);
            B_ModificarEntrada.Name = "B_ModificarEntrada";
            B_ModificarEntrada.Size = new Size(101, 130);
            B_ModificarEntrada.TabIndex = 2;
            B_ModificarEntrada.Text = "Modificar (Ctrl + M)";
            B_ModificarEntrada.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarEntrada.UseVisualStyleBackColor = false;
            B_ModificarEntrada.Click += B_ModificarEntrada_Click;
            // 
            // B_CambiarEstado
            // 
            B_CambiarEstado.BackColor = SystemColors.ControlLightLight;
            B_CambiarEstado.Cursor = Cursors.Hand;
            B_CambiarEstado.Dock = DockStyle.Right;
            B_CambiarEstado.FlatAppearance.BorderSize = 0;
            B_CambiarEstado.FlatStyle = FlatStyle.Flat;
            B_CambiarEstado.Font = new Font("Segoe UI", 10.2F);
            B_CambiarEstado.ForeColor = Color.FromArgb(44, 140, 153);
            B_CambiarEstado.Image = Properties.Resources.semaforo;
            B_CambiarEstado.Location = new Point(1719, 0);
            B_CambiarEstado.Name = "B_CambiarEstado";
            B_CambiarEstado.Size = new Size(95, 130);
            B_CambiarEstado.TabIndex = 1;
            B_CambiarEstado.Text = "Cambiar Estado (Ctrl + B)";
            B_CambiarEstado.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarEstado.UseVisualStyleBackColor = false;
            B_CambiarEstado.Click += B_CambiarEstado_Click;
            // 
            // V_menuEntradasEfectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 712);
            Controls.Add(DGV_EntradasEfectivo);
            Controls.Add(panelSuperiorProv);
            Name = "V_menuEntradasEfectivo";
            Text = "V_menuEntradasEfectivo";
            ((System.ComponentModel.ISupportInitialize)DGV_EntradasEfectivo).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_EntradasEfectivo;
        private Panel panelSuperiorProv;
        private Button B_ActualizarTabla;
        private Button B_AgregarEntrada;
        private Button B_ModificarEntrada;
        private Button B_CambiarEstado;
    }
}