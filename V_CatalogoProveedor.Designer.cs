namespace POS_CHITOS
{
    partial class V_CatalogoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_CatalogoProveedor));
            DGV_Catalogo = new DataGridView();
            panelSuperiorProv = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            TB_Correo = new TextBox();
            TB_Telefono = new TextBox();
            TB_Direccion = new TextBox();
            TB_Proveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            B_ActualizarProveedor = new Button();
            button3 = new Button();
            B_AgregarProducto = new Button();
            B_DarBaja = new Button();
            TB_BuscarProveedor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Catalogo).BeginInit();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DGV_Catalogo
            // 
            DGV_Catalogo.AllowUserToAddRows = false;
            DGV_Catalogo.AllowUserToResizeColumns = false;
            DGV_Catalogo.AllowUserToResizeRows = false;
            DGV_Catalogo.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Catalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Catalogo.Dock = DockStyle.Fill;
            DGV_Catalogo.Location = new Point(0, 213);
            DGV_Catalogo.MultiSelect = false;
            DGV_Catalogo.Name = "DGV_Catalogo";
            DGV_Catalogo.ReadOnly = true;
            DGV_Catalogo.RowHeadersVisible = false;
            DGV_Catalogo.RowHeadersWidth = 51;
            DGV_Catalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Catalogo.Size = new Size(1549, 528);
            DGV_Catalogo.TabIndex = 1;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(pictureBox4);
            panelSuperiorProv.Controls.Add(pictureBox3);
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(pictureBox2);
            panelSuperiorProv.Controls.Add(TB_Correo);
            panelSuperiorProv.Controls.Add(TB_Telefono);
            panelSuperiorProv.Controls.Add(TB_Direccion);
            panelSuperiorProv.Controls.Add(TB_Proveedor);
            panelSuperiorProv.Controls.Add(label4);
            panelSuperiorProv.Controls.Add(label3);
            panelSuperiorProv.Controls.Add(label2);
            panelSuperiorProv.Controls.Add(label1);
            panelSuperiorProv.Controls.Add(B_ActualizarProveedor);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarProducto);
            panelSuperiorProv.Controls.Add(B_DarBaja);
            panelSuperiorProv.Controls.Add(TB_BuscarProveedor);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1549, 213);
            panelSuperiorProv.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.correo_electronico;
            pictureBox4.Location = new Point(797, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.llamada_telefonica;
            pictureBox3.Location = new Point(13, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.marcador_de_posicion;
            pictureBox1.Location = new Point(408, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(11, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // TB_Correo
            // 
            TB_Correo.BackColor = Color.WhiteSmoke;
            TB_Correo.Font = new Font("Segoe UI", 12F);
            TB_Correo.ForeColor = Color.FromArgb(44, 140, 153);
            TB_Correo.Location = new Point(846, 53);
            TB_Correo.Name = "TB_Correo";
            TB_Correo.ReadOnly = true;
            TB_Correo.Size = new Size(359, 34);
            TB_Correo.TabIndex = 13;
            // 
            // TB_Telefono
            // 
            TB_Telefono.BackColor = Color.WhiteSmoke;
            TB_Telefono.Font = new Font("Segoe UI", 12F);
            TB_Telefono.ForeColor = Color.FromArgb(44, 140, 153);
            TB_Telefono.Location = new Point(58, 145);
            TB_Telefono.Name = "TB_Telefono";
            TB_Telefono.ReadOnly = true;
            TB_Telefono.Size = new Size(313, 34);
            TB_Telefono.TabIndex = 12;
            // 
            // TB_Direccion
            // 
            TB_Direccion.BackColor = Color.WhiteSmoke;
            TB_Direccion.Font = new Font("Segoe UI", 12F);
            TB_Direccion.ForeColor = Color.FromArgb(44, 140, 153);
            TB_Direccion.Location = new Point(446, 53);
            TB_Direccion.Name = "TB_Direccion";
            TB_Direccion.ReadOnly = true;
            TB_Direccion.Size = new Size(326, 34);
            TB_Direccion.TabIndex = 11;
            // 
            // TB_Proveedor
            // 
            TB_Proveedor.BackColor = Color.WhiteSmoke;
            TB_Proveedor.Font = new Font("Segoe UI", 12F);
            TB_Proveedor.ForeColor = Color.FromArgb(44, 140, 153);
            TB_Proveedor.Location = new Point(58, 53);
            TB_Proveedor.Name = "TB_Proveedor";
            TB_Proveedor.ReadOnly = true;
            TB_Proveedor.Size = new Size(313, 34);
            TB_Proveedor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(982, 9);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 9;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 111);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 7;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 6;
            label1.Text = "Proveedor";
            // 
            // B_ActualizarProveedor
            // 
            B_ActualizarProveedor.BackColor = Color.WhiteSmoke;
            B_ActualizarProveedor.Dock = DockStyle.Right;
            B_ActualizarProveedor.FlatAppearance.BorderSize = 0;
            B_ActualizarProveedor.FlatStyle = FlatStyle.Flat;
            B_ActualizarProveedor.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarProveedor.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarProveedor.Image = Properties.Resources.recargar;
            B_ActualizarProveedor.Location = new Point(1240, 0);
            B_ActualizarProveedor.Name = "B_ActualizarProveedor";
            B_ActualizarProveedor.Size = new Size(108, 213);
            B_ActualizarProveedor.TabIndex = 0;
            B_ActualizarProveedor.Text = "Actualizar (Ctrl + R)";
            B_ActualizarProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarProveedor.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(1074, 155);
            button3.Name = "button3";
            button3.Size = new Size(51, 52);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarProducto
            // 
            B_AgregarProducto.BackColor = Color.WhiteSmoke;
            B_AgregarProducto.Dock = DockStyle.Right;
            B_AgregarProducto.FlatAppearance.BorderSize = 0;
            B_AgregarProducto.FlatStyle = FlatStyle.Flat;
            B_AgregarProducto.Font = new Font("Segoe UI", 10.2F);
            B_AgregarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarProducto.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarProducto.Location = new Point(1348, 0);
            B_AgregarProducto.Name = "B_AgregarProducto";
            B_AgregarProducto.Size = new Size(107, 213);
            B_AgregarProducto.TabIndex = 3;
            B_AgregarProducto.TabStop = false;
            B_AgregarProducto.Text = "Agregar (Ctrl + N)";
            B_AgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProducto.UseVisualStyleBackColor = false;
            B_AgregarProducto.Click += B_AgregarProducto_Click;
            // 
            // B_DarBaja
            // 
            B_DarBaja.BackColor = Color.WhiteSmoke;
            B_DarBaja.Dock = DockStyle.Right;
            B_DarBaja.FlatAppearance.BorderSize = 0;
            B_DarBaja.FlatStyle = FlatStyle.Flat;
            B_DarBaja.Font = new Font("Segoe UI", 10.2F);
            B_DarBaja.ForeColor = Color.FromArgb(44, 140, 153);
            B_DarBaja.Image = Properties.Resources.semaforo;
            B_DarBaja.Location = new Point(1455, 0);
            B_DarBaja.Name = "B_DarBaja";
            B_DarBaja.Size = new Size(94, 213);
            B_DarBaja.TabIndex = 1;
            B_DarBaja.TabStop = false;
            B_DarBaja.Text = "Cambiar estado (Ctrl + B)";
            B_DarBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_DarBaja.UseVisualStyleBackColor = false;
            B_DarBaja.Click += B_DarBaja_Click;
            // 
            // TB_BuscarProveedor
            // 
            TB_BuscarProveedor.BackColor = Color.WhiteSmoke;
            TB_BuscarProveedor.Font = new Font("Segoe UI", 12F);
            TB_BuscarProveedor.ForeColor = Color.FromArgb(44, 140, 153);
            TB_BuscarProveedor.Location = new Point(309, 173);
            TB_BuscarProveedor.Name = "TB_BuscarProveedor";
            TB_BuscarProveedor.Size = new Size(759, 34);
            TB_BuscarProveedor.TabIndex = 1;
            TB_BuscarProveedor.KeyDown += TB_BuscarProveedor_KeyDown;
            // 
            // V_CatalogoProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 741);
            Controls.Add(DGV_Catalogo);
            Controls.Add(panelSuperiorProv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_CatalogoProveedor";
            Text = "Catalogo Proveedor";
            Load += V_CatalogoProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Catalogo).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Catalogo;
        private Panel panelSuperiorProv;
        private Button B_ActualizarProveedor;
        private Button button3;
        private Button B_AgregarProducto;
        private Button B_DarBaja;
        private TextBox TB_BuscarProveedor;
        private TextBox TB_Proveedor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TB_Correo;
        private TextBox TB_Telefono;
        private TextBox TB_Direccion;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}