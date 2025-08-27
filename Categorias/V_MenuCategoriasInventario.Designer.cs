namespace POS_CHITOS
{
    partial class V_MenuCategoriasInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MenuCategoriasInventario));
            DGV_CategoriasInventario = new DataGridView();
            panelSuperiorProv = new Panel();
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_AgregarCategoriaInventario = new Button();
            B_ModificarCategoria = new Button();
            B_CambiarEstado = new Button();
            TB_BuscarCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_CategoriasInventario).BeginInit();
            panelSuperiorProv.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_CategoriasInventario
            // 
            DGV_CategoriasInventario.AllowUserToAddRows = false;
            DGV_CategoriasInventario.AllowUserToResizeColumns = false;
            DGV_CategoriasInventario.AllowUserToResizeRows = false;
            DGV_CategoriasInventario.BackgroundColor = SystemColors.ControlLightLight;
            DGV_CategoriasInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CategoriasInventario.Dock = DockStyle.Fill;
            DGV_CategoriasInventario.Location = new Point(0, 124);
            DGV_CategoriasInventario.MultiSelect = false;
            DGV_CategoriasInventario.Name = "DGV_CategoriasInventario";
            DGV_CategoriasInventario.ReadOnly = true;
            DGV_CategoriasInventario.RowHeadersWidth = 51;
            DGV_CategoriasInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_CategoriasInventario.Size = new Size(1281, 625);
            DGV_CategoriasInventario.TabIndex = 4;
            DGV_CategoriasInventario.SelectionChanged += DGV_CategoriasInventario_SelectionChanged;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarCategoriaInventario);
            panelSuperiorProv.Controls.Add(B_ModificarCategoria);
            panelSuperiorProv.Controls.Add(B_CambiarEstado);
            panelSuperiorProv.Controls.Add(TB_BuscarCategoria);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1281, 124);
            panelSuperiorProv.TabIndex = 3;
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
            B_ActualizarTabla.Location = new Point(887, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(97, 124);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            B_ActualizarTabla.Click += B_ActualizarTabla_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(411, 33);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarCategoriaInventario
            // 
            B_AgregarCategoriaInventario.BackColor = Color.WhiteSmoke;
            B_AgregarCategoriaInventario.Cursor = Cursors.Hand;
            B_AgregarCategoriaInventario.Dock = DockStyle.Right;
            B_AgregarCategoriaInventario.FlatAppearance.BorderSize = 0;
            B_AgregarCategoriaInventario.FlatStyle = FlatStyle.Flat;
            B_AgregarCategoriaInventario.Font = new Font("Segoe UI", 10.2F);
            B_AgregarCategoriaInventario.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarCategoriaInventario.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarCategoriaInventario.Location = new Point(984, 0);
            B_AgregarCategoriaInventario.Name = "B_AgregarCategoriaInventario";
            B_AgregarCategoriaInventario.Size = new Size(101, 124);
            B_AgregarCategoriaInventario.TabIndex = 3;
            B_AgregarCategoriaInventario.Text = "Agregar (Ctrl + N)";
            B_AgregarCategoriaInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarCategoriaInventario.UseVisualStyleBackColor = false;
            B_AgregarCategoriaInventario.Click += B_AgregarCategoriaInventario_Click;
            // 
            // B_ModificarCategoria
            // 
            B_ModificarCategoria.BackColor = Color.WhiteSmoke;
            B_ModificarCategoria.Cursor = Cursors.Hand;
            B_ModificarCategoria.Dock = DockStyle.Right;
            B_ModificarCategoria.FlatAppearance.BorderSize = 0;
            B_ModificarCategoria.FlatStyle = FlatStyle.Flat;
            B_ModificarCategoria.Font = new Font("Segoe UI", 10.2F);
            B_ModificarCategoria.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCategoria.Image = Properties.Resources.circulo;
            B_ModificarCategoria.Location = new Point(1085, 0);
            B_ModificarCategoria.Name = "B_ModificarCategoria";
            B_ModificarCategoria.Size = new Size(101, 124);
            B_ModificarCategoria.TabIndex = 2;
            B_ModificarCategoria.Text = "Modificar (Ctrl + M)";
            B_ModificarCategoria.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCategoria.UseVisualStyleBackColor = false;
            B_ModificarCategoria.Click += B_ModificarCategoria_Click;
            // 
            // B_CambiarEstado
            // 
            B_CambiarEstado.BackColor = Color.WhiteSmoke;
            B_CambiarEstado.Cursor = Cursors.Hand;
            B_CambiarEstado.Dock = DockStyle.Right;
            B_CambiarEstado.FlatAppearance.BorderSize = 0;
            B_CambiarEstado.FlatStyle = FlatStyle.Flat;
            B_CambiarEstado.Font = new Font("Segoe UI", 10.2F);
            B_CambiarEstado.ForeColor = Color.FromArgb(44, 140, 153);
            B_CambiarEstado.Image = Properties.Resources.semaforo;
            B_CambiarEstado.Location = new Point(1186, 0);
            B_CambiarEstado.Name = "B_CambiarEstado";
            B_CambiarEstado.Size = new Size(95, 124);
            B_CambiarEstado.TabIndex = 1;
            B_CambiarEstado.Text = "Cambiar Estado (Ctrl + B)";
            B_CambiarEstado.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarEstado.UseVisualStyleBackColor = false;
            B_CambiarEstado.Click += B_CambiarEstado_Click;
            // 
            // TB_BuscarCategoria
            // 
            TB_BuscarCategoria.BackColor = Color.WhiteSmoke;
            TB_BuscarCategoria.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarCategoria.ForeColor = Color.FromArgb(44, 140, 153);
            TB_BuscarCategoria.Location = new Point(34, 44);
            TB_BuscarCategoria.Name = "TB_BuscarCategoria";
            TB_BuscarCategoria.Size = new Size(371, 34);
            TB_BuscarCategoria.TabIndex = 0;
            TB_BuscarCategoria.KeyDown += TB_BuscarCategoria_KeyDown;
            // 
            // V_MenuCategoriasInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 749);
            Controls.Add(DGV_CategoriasInventario);
            Controls.Add(panelSuperiorProv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_MenuCategoriasInventario";
            ShowInTaskbar = false;
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)DGV_CategoriasInventario).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_CategoriasInventario;
        private Panel panelSuperiorProv;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_AgregarCategoriaInventario;
        private Button B_ModificarCategoria;
        private Button B_CambiarEstado;
        private TextBox TB_BuscarCategoria;
    }
}