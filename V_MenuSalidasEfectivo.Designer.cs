namespace POS_CHITOS
{
    partial class V_MenuSalidasEfectivo
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
            DGV_SalidasEfectivo = new DataGridView();
            panelSuperiorProv = new Panel();
            B_ActualizarTabla = new Button();
            B_AgregarSalida = new Button();
            B_ModificarSalida = new Button();
            B_CambiarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_SalidasEfectivo).BeginInit();
            panelSuperiorProv.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_SalidasEfectivo
            // 
            DGV_SalidasEfectivo.AllowUserToAddRows = false;
            DGV_SalidasEfectivo.AllowUserToResizeColumns = false;
            DGV_SalidasEfectivo.AllowUserToResizeRows = false;
            DGV_SalidasEfectivo.BackgroundColor = SystemColors.ControlLightLight;
            DGV_SalidasEfectivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_SalidasEfectivo.Dock = DockStyle.Fill;
            DGV_SalidasEfectivo.Location = new Point(0, 136);
            DGV_SalidasEfectivo.MultiSelect = false;
            DGV_SalidasEfectivo.Name = "DGV_SalidasEfectivo";
            DGV_SalidasEfectivo.ReadOnly = true;
            DGV_SalidasEfectivo.RowHeadersWidth = 51;
            DGV_SalidasEfectivo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_SalidasEfectivo.Size = new Size(1649, 609);
            DGV_SalidasEfectivo.TabIndex = 6;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(B_AgregarSalida);
            panelSuperiorProv.Controls.Add(B_ModificarSalida);
            panelSuperiorProv.Controls.Add(B_CambiarEstado);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1649, 136);
            panelSuperiorProv.TabIndex = 5;
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
            B_ActualizarTabla.Location = new Point(1262, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(94, 136);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            // 
            // B_AgregarSalida
            // 
            B_AgregarSalida.BackColor = SystemColors.ControlLightLight;
            B_AgregarSalida.Cursor = Cursors.Hand;
            B_AgregarSalida.Dock = DockStyle.Right;
            B_AgregarSalida.FlatAppearance.BorderSize = 0;
            B_AgregarSalida.FlatStyle = FlatStyle.Flat;
            B_AgregarSalida.Font = new Font("Segoe UI", 10.2F);
            B_AgregarSalida.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarSalida.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarSalida.Location = new Point(1356, 0);
            B_AgregarSalida.Name = "B_AgregarSalida";
            B_AgregarSalida.Size = new Size(101, 136);
            B_AgregarSalida.TabIndex = 3;
            B_AgregarSalida.Text = "Agregar (Ctrl + N)";
            B_AgregarSalida.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarSalida.UseVisualStyleBackColor = false;
            B_AgregarSalida.Click += B_AgregarSalida_Click;
            // 
            // B_ModificarSalida
            // 
            B_ModificarSalida.BackColor = SystemColors.ControlLightLight;
            B_ModificarSalida.Cursor = Cursors.Hand;
            B_ModificarSalida.Dock = DockStyle.Right;
            B_ModificarSalida.FlatAppearance.BorderSize = 0;
            B_ModificarSalida.FlatStyle = FlatStyle.Flat;
            B_ModificarSalida.Font = new Font("Segoe UI", 10.2F);
            B_ModificarSalida.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarSalida.Image = Properties.Resources.circulo;
            B_ModificarSalida.Location = new Point(1457, 0);
            B_ModificarSalida.Name = "B_ModificarSalida";
            B_ModificarSalida.Size = new Size(101, 136);
            B_ModificarSalida.TabIndex = 2;
            B_ModificarSalida.Text = "Modificar (Ctrl + M)";
            B_ModificarSalida.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarSalida.UseVisualStyleBackColor = false;
            B_ModificarSalida.Click += B_ModificarSalida_Click;
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
            B_CambiarEstado.Location = new Point(1558, 0);
            B_CambiarEstado.Name = "B_CambiarEstado";
            B_CambiarEstado.Size = new Size(91, 136);
            B_CambiarEstado.TabIndex = 1;
            B_CambiarEstado.Text = "Cambiar Estado (Ctrl + B)";
            B_CambiarEstado.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarEstado.UseVisualStyleBackColor = false;
            B_CambiarEstado.Click += B_CambiarEstado_Click;
            // 
            // V_MenuSalidasEfectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 745);
            Controls.Add(DGV_SalidasEfectivo);
            Controls.Add(panelSuperiorProv);
            Name = "V_MenuSalidasEfectivo";
            Text = "V_MenuSalidasEfectivo";
            ((System.ComponentModel.ISupportInitialize)DGV_SalidasEfectivo).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_SalidasEfectivo;
        private Panel panelSuperiorProv;
        private Button B_ActualizarTabla;
        private Button B_AgregarSalida;
        private Button B_ModificarSalida;
        private Button B_CambiarEstado;
    }
}