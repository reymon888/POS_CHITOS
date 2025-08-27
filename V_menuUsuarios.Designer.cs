namespace POS_CHITOS
{
    partial class V_menuUsuarios
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
            panelSuperiorProv = new Panel();
            B_CambiarPW = new Button();
            B_ActualizarTablaUsuarios = new Button();
            button3 = new Button();
            B_AgregarUsuarios = new Button();
            B_ModificarUsuarios = new Button();
            B_CambiarEstadoUsuario = new Button();
            TB_BuscarUsuario = new TextBox();
            DGV_Usuarios = new DataGridView();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(B_CambiarPW);
            panelSuperiorProv.Controls.Add(B_ActualizarTablaUsuarios);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarUsuarios);
            panelSuperiorProv.Controls.Add(B_ModificarUsuarios);
            panelSuperiorProv.Controls.Add(B_CambiarEstadoUsuario);
            panelSuperiorProv.Controls.Add(TB_BuscarUsuario);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1289, 127);
            panelSuperiorProv.TabIndex = 1;
            // 
            // B_CambiarPW
            // 
            B_CambiarPW.BackColor = SystemColors.ControlLightLight;
            B_CambiarPW.Dock = DockStyle.Right;
            B_CambiarPW.FlatAppearance.BorderSize = 0;
            B_CambiarPW.FlatStyle = FlatStyle.Flat;
            B_CambiarPW.Font = new Font("Segoe UI", 10.2F);
            B_CambiarPW.ForeColor = Color.FromArgb(44, 140, 153);
            B_CambiarPW.Image = Properties.Resources.editar__4_;
            B_CambiarPW.Location = new Point(737, 0);
            B_CambiarPW.Name = "B_CambiarPW";
            B_CambiarPW.Size = new Size(121, 127);
            B_CambiarPW.TabIndex = 6;
            B_CambiarPW.Text = "Cambiar Contraseña (Ctrl + P)";
            B_CambiarPW.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarPW.UseVisualStyleBackColor = false;
            B_CambiarPW.Click += B_CambiarPW_Click;
            // 
            // B_ActualizarTablaUsuarios
            // 
            B_ActualizarTablaUsuarios.BackColor = SystemColors.ControlLightLight;
            B_ActualizarTablaUsuarios.Dock = DockStyle.Right;
            B_ActualizarTablaUsuarios.FlatAppearance.BorderSize = 0;
            B_ActualizarTablaUsuarios.FlatStyle = FlatStyle.Flat;
            B_ActualizarTablaUsuarios.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarTablaUsuarios.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTablaUsuarios.Image = Properties.Resources.recargar;
            B_ActualizarTablaUsuarios.Location = new Point(858, 0);
            B_ActualizarTablaUsuarios.Name = "B_ActualizarTablaUsuarios";
            B_ActualizarTablaUsuarios.Size = new Size(113, 127);
            B_ActualizarTablaUsuarios.TabIndex = 5;
            B_ActualizarTablaUsuarios.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTablaUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTablaUsuarios.UseVisualStyleBackColor = false;
            B_ActualizarTablaUsuarios.Click += B_ActualizarTablaUsuarios_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(456, 14);
            button3.Name = "button3";
            button3.Size = new Size(69, 84);
            button3.TabIndex = 4;
            button3.Text = "(Ctrl + S)";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarUsuarios
            // 
            B_AgregarUsuarios.BackColor = SystemColors.ControlLightLight;
            B_AgregarUsuarios.Dock = DockStyle.Right;
            B_AgregarUsuarios.FlatAppearance.BorderSize = 0;
            B_AgregarUsuarios.FlatStyle = FlatStyle.Flat;
            B_AgregarUsuarios.Font = new Font("Segoe UI", 10.2F);
            B_AgregarUsuarios.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarUsuarios.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarUsuarios.Location = new Point(971, 0);
            B_AgregarUsuarios.Name = "B_AgregarUsuarios";
            B_AgregarUsuarios.Size = new Size(110, 127);
            B_AgregarUsuarios.TabIndex = 3;
            B_AgregarUsuarios.Text = "Nuevo (Ctrl+N)";
            B_AgregarUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarUsuarios.UseVisualStyleBackColor = false;
            B_AgregarUsuarios.Click += B_AgregarUsuarios_Click;
            // 
            // B_ModificarUsuarios
            // 
            B_ModificarUsuarios.BackColor = SystemColors.ControlLightLight;
            B_ModificarUsuarios.Dock = DockStyle.Right;
            B_ModificarUsuarios.FlatAppearance.BorderSize = 0;
            B_ModificarUsuarios.FlatStyle = FlatStyle.Flat;
            B_ModificarUsuarios.Font = new Font("Segoe UI", 10.2F);
            B_ModificarUsuarios.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarUsuarios.Image = Properties.Resources.circulo;
            B_ModificarUsuarios.Location = new Point(1081, 0);
            B_ModificarUsuarios.Name = "B_ModificarUsuarios";
            B_ModificarUsuarios.Size = new Size(113, 127);
            B_ModificarUsuarios.TabIndex = 2;
            B_ModificarUsuarios.Text = "Modificar (Ctrl + M)";
            B_ModificarUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarUsuarios.UseVisualStyleBackColor = false;
            B_ModificarUsuarios.Click += B_ModificarUsuarios_Click;
            // 
            // B_CambiarEstadoUsuario
            // 
            B_CambiarEstadoUsuario.BackColor = SystemColors.ControlLightLight;
            B_CambiarEstadoUsuario.Dock = DockStyle.Right;
            B_CambiarEstadoUsuario.FlatAppearance.BorderSize = 0;
            B_CambiarEstadoUsuario.FlatStyle = FlatStyle.Flat;
            B_CambiarEstadoUsuario.Font = new Font("Segoe UI", 10.2F);
            B_CambiarEstadoUsuario.ForeColor = Color.FromArgb(44, 140, 153);
            B_CambiarEstadoUsuario.Image = Properties.Resources.semaforo;
            B_CambiarEstadoUsuario.Location = new Point(1194, 0);
            B_CambiarEstadoUsuario.Name = "B_CambiarEstadoUsuario";
            B_CambiarEstadoUsuario.Size = new Size(95, 127);
            B_CambiarEstadoUsuario.TabIndex = 1;
            B_CambiarEstadoUsuario.Text = "Cambiar Estado (Ctrl + B)";
            B_CambiarEstadoUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarEstadoUsuario.UseVisualStyleBackColor = false;
            B_CambiarEstadoUsuario.Click += B_DarBajaUsuarios_Click;
            // 
            // TB_BuscarUsuario
            // 
            TB_BuscarUsuario.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarUsuario.Location = new Point(18, 37);
            TB_BuscarUsuario.Name = "TB_BuscarUsuario";
            TB_BuscarUsuario.Size = new Size(432, 34);
            TB_BuscarUsuario.TabIndex = 0;
            TB_BuscarUsuario.TextChanged += TB_BuscarUsuario_TextChanged;
            TB_BuscarUsuario.KeyDown += TB_BuscarUsuario_KeyDown;
            // 
            // DGV_Usuarios
            // 
            DGV_Usuarios.AllowUserToAddRows = false;
            DGV_Usuarios.AllowUserToResizeColumns = false;
            DGV_Usuarios.AllowUserToResizeRows = false;
            DGV_Usuarios.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Usuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Usuarios.Dock = DockStyle.Fill;
            DGV_Usuarios.Location = new Point(0, 127);
            DGV_Usuarios.MultiSelect = false;
            DGV_Usuarios.Name = "DGV_Usuarios";
            DGV_Usuarios.ReadOnly = true;
            DGV_Usuarios.RowHeadersVisible = false;
            DGV_Usuarios.RowHeadersWidth = 51;
            DGV_Usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Usuarios.Size = new Size(1289, 570);
            DGV_Usuarios.TabIndex = 3;
            DGV_Usuarios.SelectionChanged += DGV_Usuarios_SelectionChanged;
            // 
            // V_menuUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 697);
            Controls.Add(DGV_Usuarios);
            Controls.Add(panelSuperiorProv);
            Name = "V_menuUsuarios";
            Text = "V_menuUsuarios";
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Usuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperiorProv;
        private Button B_ActualizarTablaUsuarios;
        private Button button3;
        private Button B_AgregarUsuarios;
        private Button B_ModificarUsuarios;
        private Button B_CambiarEstadoUsuario;
        private TextBox TB_BuscarUsuario;
        private DataGridView DGV_Usuarios;
        private Button B_CambiarPW;
    }
}