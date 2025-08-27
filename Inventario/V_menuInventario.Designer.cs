namespace POS_CHITOS
{
    partial class V_menuInventario
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
            B_Eliminar = new Button();
            pictureBox2 = new PictureBox();
            CB_Filtros = new ComboBox();
            B_ProductosBajos = new Button();
            B_CategoriasInventario = new Button();
            pictureBox1 = new PictureBox();
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_AgregarProducto = new Button();
            B_ModificarProducto = new Button();
            B_DarBaja = new Button();
            TB_BuscarProducto = new TextBox();
            DGV_Inventario = new DataGridView();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).BeginInit();
            SuspendLayout();
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(B_Eliminar);
            panelSuperiorProv.Controls.Add(pictureBox2);
            panelSuperiorProv.Controls.Add(CB_Filtros);
            panelSuperiorProv.Controls.Add(B_ProductosBajos);
            panelSuperiorProv.Controls.Add(B_CategoriasInventario);
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarProducto);
            panelSuperiorProv.Controls.Add(B_ModificarProducto);
            panelSuperiorProv.Controls.Add(B_DarBaja);
            panelSuperiorProv.Controls.Add(TB_BuscarProducto);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1405, 140);
            panelSuperiorProv.TabIndex = 1;
            // 
            // B_Eliminar
            // 
            B_Eliminar.BackColor = Color.WhiteSmoke;
            B_Eliminar.Cursor = Cursors.Hand;
            B_Eliminar.Dock = DockStyle.Right;
            B_Eliminar.FlatAppearance.BorderSize = 0;
            B_Eliminar.FlatStyle = FlatStyle.Flat;
            B_Eliminar.Font = new Font("Segoe UI", 10.2F);
            B_Eliminar.ForeColor = Color.FromArgb(44, 140, 153);
            B_Eliminar.Image = Properties.Resources.boton_x;
            B_Eliminar.Location = new Point(720, 0);
            B_Eliminar.Name = "B_Eliminar";
            B_Eliminar.Size = new Size(95, 140);
            B_Eliminar.TabIndex = 19;
            B_Eliminar.Text = "Eliminar Definitivo (Ctrl + X)";
            B_Eliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Eliminar.UseVisualStyleBackColor = false;
            B_Eliminar.Click += B_Eliminar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.filtrar__1_;
            pictureBox2.Location = new Point(15, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // CB_Filtros
            // 
            CB_Filtros.BackColor = Color.WhiteSmoke;
            CB_Filtros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Filtros.ForeColor = Color.FromArgb(44, 140, 153);
            CB_Filtros.FormattingEnabled = true;
            CB_Filtros.Location = new Point(76, 82);
            CB_Filtros.Name = "CB_Filtros";
            CB_Filtros.Size = new Size(258, 36);
            CB_Filtros.TabIndex = 17;
            CB_Filtros.SelectedIndexChanged += CB_Filtros_SelectedIndexChanged;
            // 
            // B_ProductosBajos
            // 
            B_ProductosBajos.BackColor = Color.WhiteSmoke;
            B_ProductosBajos.Cursor = Cursors.Hand;
            B_ProductosBajos.Dock = DockStyle.Right;
            B_ProductosBajos.FlatAppearance.BorderSize = 0;
            B_ProductosBajos.FlatStyle = FlatStyle.Flat;
            B_ProductosBajos.Font = new Font("Segoe UI", 10.2F);
            B_ProductosBajos.ForeColor = Color.FromArgb(44, 140, 153);
            B_ProductosBajos.Image = Properties.Resources.sin_dinero;
            B_ProductosBajos.Location = new Point(815, 0);
            B_ProductosBajos.Name = "B_ProductosBajos";
            B_ProductosBajos.Size = new Size(97, 140);
            B_ProductosBajos.TabIndex = 16;
            B_ProductosBajos.Text = "Precio Bajo (Ctrl + D)";
            B_ProductosBajos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ProductosBajos.UseVisualStyleBackColor = false;
            B_ProductosBajos.Click += B_ProductosBajos_Click;
            // 
            // B_CategoriasInventario
            // 
            B_CategoriasInventario.BackColor = Color.WhiteSmoke;
            B_CategoriasInventario.Cursor = Cursors.Hand;
            B_CategoriasInventario.Dock = DockStyle.Right;
            B_CategoriasInventario.FlatAppearance.BorderSize = 0;
            B_CategoriasInventario.FlatStyle = FlatStyle.Flat;
            B_CategoriasInventario.Font = new Font("Segoe UI", 10.2F);
            B_CategoriasInventario.ForeColor = Color.FromArgb(44, 140, 153);
            B_CategoriasInventario.Image = Properties.Resources.etiqueta;
            B_CategoriasInventario.Location = new Point(912, 0);
            B_CategoriasInventario.Name = "B_CategoriasInventario";
            B_CategoriasInventario.Size = new Size(95, 140);
            B_CategoriasInventario.TabIndex = 15;
            B_CategoriasInventario.Text = "Categoria (Ctrl + C)";
            B_CategoriasInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CategoriasInventario.UseVisualStyleBackColor = false;
            B_CategoriasInventario.Click += B_CategoriasInventario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
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
            B_ActualizarTabla.Location = new Point(1007, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(101, 140);
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
            button3.Location = new Point(597, 17);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarProducto
            // 
            B_AgregarProducto.BackColor = Color.WhiteSmoke;
            B_AgregarProducto.Cursor = Cursors.Hand;
            B_AgregarProducto.Dock = DockStyle.Right;
            B_AgregarProducto.FlatAppearance.BorderSize = 0;
            B_AgregarProducto.FlatStyle = FlatStyle.Flat;
            B_AgregarProducto.Font = new Font("Segoe UI", 10.2F);
            B_AgregarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarProducto.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarProducto.Location = new Point(1108, 0);
            B_AgregarProducto.Name = "B_AgregarProducto";
            B_AgregarProducto.Size = new Size(101, 140);
            B_AgregarProducto.TabIndex = 3;
            B_AgregarProducto.Text = "Agregar (Ctrl + N)";
            B_AgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProducto.UseVisualStyleBackColor = false;
            B_AgregarProducto.Click += B_AgregarProducto_Click;
            // 
            // B_ModificarProducto
            // 
            B_ModificarProducto.BackColor = Color.WhiteSmoke;
            B_ModificarProducto.Cursor = Cursors.Hand;
            B_ModificarProducto.Dock = DockStyle.Right;
            B_ModificarProducto.FlatAppearance.BorderSize = 0;
            B_ModificarProducto.FlatStyle = FlatStyle.Flat;
            B_ModificarProducto.Font = new Font("Segoe UI", 10.2F);
            B_ModificarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarProducto.Image = Properties.Resources.circulo;
            B_ModificarProducto.Location = new Point(1209, 0);
            B_ModificarProducto.Name = "B_ModificarProducto";
            B_ModificarProducto.Size = new Size(101, 140);
            B_ModificarProducto.TabIndex = 2;
            B_ModificarProducto.Text = "Modificar (Ctrl + M)";
            B_ModificarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarProducto.UseVisualStyleBackColor = false;
            B_ModificarProducto.Click += B_ModificarProducto_Click;
            // 
            // B_DarBaja
            // 
            B_DarBaja.BackColor = Color.WhiteSmoke;
            B_DarBaja.Cursor = Cursors.Hand;
            B_DarBaja.Dock = DockStyle.Right;
            B_DarBaja.FlatAppearance.BorderSize = 0;
            B_DarBaja.FlatStyle = FlatStyle.Flat;
            B_DarBaja.Font = new Font("Segoe UI", 10.2F);
            B_DarBaja.ForeColor = Color.FromArgb(44, 140, 153);
            B_DarBaja.Image = Properties.Resources.semaforo;
            B_DarBaja.Location = new Point(1310, 0);
            B_DarBaja.Name = "B_DarBaja";
            B_DarBaja.Size = new Size(95, 140);
            B_DarBaja.TabIndex = 1;
            B_DarBaja.Text = "Cambiar Estado (Ctrl + B)";
            B_DarBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_DarBaja.UseVisualStyleBackColor = false;
            B_DarBaja.Click += B_DarBaja_Click;
            // 
            // TB_BuscarProducto
            // 
            TB_BuscarProducto.BackColor = Color.WhiteSmoke;
            TB_BuscarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            TB_BuscarProducto.Location = new Point(76, 24);
            TB_BuscarProducto.Name = "TB_BuscarProducto";
            TB_BuscarProducto.Size = new Size(515, 34);
            TB_BuscarProducto.TabIndex = 0;
            TB_BuscarProducto.TextChanged += TB_BuscarProducto_TextChanged;
            TB_BuscarProducto.KeyDown += TB_BuscarProducto_KeyDown;
            // 
            // DGV_Inventario
            // 
            DGV_Inventario.AllowUserToAddRows = false;
            DGV_Inventario.AllowUserToResizeColumns = false;
            DGV_Inventario.AllowUserToResizeRows = false;
            DGV_Inventario.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Inventario.Dock = DockStyle.Fill;
            DGV_Inventario.Location = new Point(0, 140);
            DGV_Inventario.MultiSelect = false;
            DGV_Inventario.Name = "DGV_Inventario";
            DGV_Inventario.ReadOnly = true;
            DGV_Inventario.RowHeadersWidth = 51;
            DGV_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Inventario.Size = new Size(1405, 567);
            DGV_Inventario.TabIndex = 2;
            DGV_Inventario.SelectionChanged += DGV_Inventario_SelectionChanged;
            // 
            // V_menuInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 707);
            Controls.Add(DGV_Inventario);
            Controls.Add(panelSuperiorProv);
            Name = "V_menuInventario";
            Text = "V_menuInventario";
            Load += V_menuInventario_Load;
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperiorProv;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_AgregarProducto;
        private Button B_ModificarProducto;
        private Button B_DarBaja;
        private TextBox TB_BuscarProducto;
        private DataGridView DGV_Inventario;
        private Button B_CategoriasInventario;
        private PictureBox pictureBox1;
        private Button B_ProductosBajos;
        private ComboBox CB_Filtros;
        private PictureBox pictureBox2;
        private Button B_Eliminar;
    }
}