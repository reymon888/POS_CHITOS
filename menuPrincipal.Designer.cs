namespace POS_CHITOS
{
    partial class menuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuLateral = new Panel();
            button1 = new Button();
            B_Usuarios = new Button();
            B_Proveedores = new Button();
            B_NuevaCompra = new Button();
            B_Entradas = new Button();
            B_Inventario = new Button();
            B_NuevaVenta = new Button();
            menuSuperior = new Panel();
            panel2 = new Panel();
            B_Ventas = new Button();
            button2 = new Button();
            B_Compras = new Button();
            panel1 = new Panel();
            button6 = new Button();
            labelCargo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            panelEscritorio = new Panel();
            pictureBox3 = new PictureBox();
            menuLateral.SuspendLayout();
            menuSuperior.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuLateral
            // 
            menuLateral.BackColor = Color.FromArgb(51, 51, 51);
            menuLateral.Controls.Add(button1);
            menuLateral.Controls.Add(B_Usuarios);
            menuLateral.Controls.Add(B_Proveedores);
            menuLateral.Controls.Add(B_NuevaCompra);
            menuLateral.Controls.Add(B_Entradas);
            menuLateral.Controls.Add(B_Inventario);
            menuLateral.Controls.Add(B_NuevaVenta);
            menuLateral.Dock = DockStyle.Left;
            menuLateral.Location = new Point(0, 0);
            menuLateral.Name = "menuLateral";
            menuLateral.Size = new Size(106, 936);
            menuLateral.TabIndex = 0;
            menuLateral.Paint += menuLateral_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Properties.Resources.salir;
            button1.Location = new Point(0, 840);
            button1.Name = "button1";
            button1.Size = new Size(106, 140);
            button1.TabIndex = 10;
            button1.Text = "Gastos $-";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // B_Usuarios
            // 
            B_Usuarios.AutoSize = true;
            B_Usuarios.Dock = DockStyle.Top;
            B_Usuarios.FlatAppearance.BorderSize = 0;
            B_Usuarios.FlatStyle = FlatStyle.Flat;
            B_Usuarios.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Usuarios.ForeColor = SystemColors.ButtonFace;
            B_Usuarios.Image = Properties.Resources.seguidores;
            B_Usuarios.Location = new Point(0, 700);
            B_Usuarios.Name = "B_Usuarios";
            B_Usuarios.Size = new Size(106, 140);
            B_Usuarios.TabIndex = 9;
            B_Usuarios.Text = "Usuarios (F1})";
            B_Usuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Usuarios.UseVisualStyleBackColor = true;
            B_Usuarios.Click += B_Usuarios_Click;
            // 
            // B_Proveedores
            // 
            B_Proveedores.AutoSize = true;
            B_Proveedores.Dock = DockStyle.Top;
            B_Proveedores.FlatAppearance.BorderSize = 0;
            B_Proveedores.FlatStyle = FlatStyle.Flat;
            B_Proveedores.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Proveedores.ForeColor = SystemColors.ButtonFace;
            B_Proveedores.Image = Properties.Resources.mensajero;
            B_Proveedores.Location = new Point(0, 560);
            B_Proveedores.Name = "B_Proveedores";
            B_Proveedores.Size = new Size(106, 140);
            B_Proveedores.TabIndex = 5;
            B_Proveedores.Text = "Proveedor (F1)";
            B_Proveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Proveedores.UseVisualStyleBackColor = true;
            B_Proveedores.Click += button4_Click;
            // 
            // B_NuevaCompra
            // 
            B_NuevaCompra.AutoSize = true;
            B_NuevaCompra.Dock = DockStyle.Top;
            B_NuevaCompra.FlatAppearance.BorderSize = 0;
            B_NuevaCompra.FlatStyle = FlatStyle.Flat;
            B_NuevaCompra.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_NuevaCompra.ForeColor = SystemColors.ButtonFace;
            B_NuevaCompra.Image = Properties.Resources.orden__1_;
            B_NuevaCompra.Location = new Point(0, 420);
            B_NuevaCompra.Name = "B_NuevaCompra";
            B_NuevaCompra.Size = new Size(106, 140);
            B_NuevaCompra.TabIndex = 4;
            B_NuevaCompra.Text = "Realizar Compra (F1)";
            B_NuevaCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_NuevaCompra.UseVisualStyleBackColor = true;
            B_NuevaCompra.Click += B_NuevaCompra_Click;
            // 
            // B_Entradas
            // 
            B_Entradas.AutoSize = true;
            B_Entradas.Dock = DockStyle.Top;
            B_Entradas.FlatAppearance.BorderSize = 0;
            B_Entradas.FlatStyle = FlatStyle.Flat;
            B_Entradas.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Entradas.ForeColor = SystemColors.ButtonFace;
            B_Entradas.Image = Properties.Resources.dinero;
            B_Entradas.Location = new Point(0, 280);
            B_Entradas.Name = "B_Entradas";
            B_Entradas.Size = new Size(106, 140);
            B_Entradas.TabIndex = 3;
            B_Entradas.Text = "Ingresos (F1)";
            B_Entradas.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Entradas.UseVisualStyleBackColor = true;
            B_Entradas.Click += B_caja_Click;
            // 
            // B_Inventario
            // 
            B_Inventario.AutoSize = true;
            B_Inventario.Dock = DockStyle.Top;
            B_Inventario.FlatAppearance.BorderSize = 0;
            B_Inventario.FlatStyle = FlatStyle.Flat;
            B_Inventario.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Inventario.ForeColor = SystemColors.ButtonFace;
            B_Inventario.Image = Properties.Resources.en_stock;
            B_Inventario.Location = new Point(0, 140);
            B_Inventario.Name = "B_Inventario";
            B_Inventario.Size = new Size(106, 140);
            B_Inventario.TabIndex = 2;
            B_Inventario.Text = "Inventario (F1)";
            B_Inventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Inventario.UseVisualStyleBackColor = true;
            B_Inventario.Click += B_Inventario_Click;
            // 
            // B_NuevaVenta
            // 
            B_NuevaVenta.AutoSize = true;
            B_NuevaVenta.Dock = DockStyle.Top;
            B_NuevaVenta.FlatAppearance.BorderSize = 0;
            B_NuevaVenta.FlatStyle = FlatStyle.Flat;
            B_NuevaVenta.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_NuevaVenta.ForeColor = SystemColors.ButtonHighlight;
            B_NuevaVenta.Image = Properties.Resources.punto_de_venta__1_;
            B_NuevaVenta.Location = new Point(0, 0);
            B_NuevaVenta.Name = "B_NuevaVenta";
            B_NuevaVenta.Size = new Size(106, 140);
            B_NuevaVenta.TabIndex = 1;
            B_NuevaVenta.Text = "Realizar Venta (F1)";
            B_NuevaVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_NuevaVenta.UseVisualStyleBackColor = true;
            B_NuevaVenta.Click += B_NuevaVenta_Click;
            // 
            // menuSuperior
            // 
            menuSuperior.BackColor = Color.FromArgb(26, 77, 128);
            menuSuperior.Controls.Add(panel2);
            menuSuperior.Controls.Add(panel1);
            menuSuperior.Dock = DockStyle.Top;
            menuSuperior.Location = new Point(106, 0);
            menuSuperior.Name = "menuSuperior";
            menuSuperior.Size = new Size(1342, 113);
            menuSuperior.TabIndex = 1;
            menuSuperior.Paint += menuSuperior_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(B_Ventas);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(B_Compras);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 110);
            panel2.TabIndex = 1;
            // 
            // B_Ventas
            // 
            B_Ventas.AutoSize = true;
            B_Ventas.BackColor = Color.FromArgb(26, 77, 128);
            B_Ventas.Dock = DockStyle.Top;
            B_Ventas.FlatAppearance.BorderSize = 0;
            B_Ventas.FlatStyle = FlatStyle.Flat;
            B_Ventas.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Ventas.ForeColor = SystemColors.ButtonHighlight;
            B_Ventas.Image = Properties.Resources.grafico_de_barras;
            B_Ventas.Location = new Point(227, 0);
            B_Ventas.Name = "B_Ventas";
            B_Ventas.Size = new Size(95, 107);
            B_Ventas.TabIndex = 14;
            B_Ventas.Text = "Ventas (F1)";
            B_Ventas.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ventas.UseVisualStyleBackColor = false;
            B_Ventas.Click += B_Ventas_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(26, 77, 128);
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.reporte;
            button2.Location = new Point(112, 0);
            button2.Name = "button2";
            button2.Size = new Size(115, 110);
            button2.TabIndex = 13;
            button2.Text = "Reportes (F1)";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            // 
            // B_Compras
            // 
            B_Compras.AutoSize = true;
            B_Compras.BackColor = Color.FromArgb(26, 77, 128);
            B_Compras.Dock = DockStyle.Left;
            B_Compras.FlatAppearance.BorderSize = 0;
            B_Compras.FlatStyle = FlatStyle.Flat;
            B_Compras.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Compras.ForeColor = SystemColors.ButtonHighlight;
            B_Compras.Image = Properties.Resources.tienda_online__1_;
            B_Compras.Location = new Point(0, 0);
            B_Compras.Name = "B_Compras";
            B_Compras.Size = new Size(112, 110);
            B_Compras.TabIndex = 12;
            B_Compras.Text = "Compras (F1)";
            B_Compras.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Compras.UseVisualStyleBackColor = false;
            B_Compras.Click += B_Compras_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(labelCargo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(929, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 113);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Dock = DockStyle.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 9F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Image = Properties.Resources.boton_x;
            button6.Location = new Point(265, 0);
            button6.Name = "button6";
            button6.Size = new Size(148, 113);
            button6.TabIndex = 11;
            button6.Text = "Cerrar Sesión (F1)";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Arial Rounded MT Bold", 12F);
            labelCargo.ForeColor = SystemColors.ButtonHighlight;
            labelCargo.Location = new Point(134, 58);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(71, 23);
            labelCargo.TabIndex = 3;
            labelCargo.Text = "Cargo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoEllipsis = true;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial Rounded MT Bold", 12F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(134, 29);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(107, 23);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Nickname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.jugador__1_;
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = SystemColors.ActiveBorder;
            panelEscritorio.Controls.Add(pictureBox3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(106, 113);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1342, 823);
            panelEscritorio.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.logo_chitos_oficial_xd;
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1333, 817);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1448, 936);
            Controls.Add(panelEscritorio);
            Controls.Add(menuSuperior);
            Controls.Add(menuLateral);
            Name = "menuPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            menuLateral.ResumeLayout(false);
            menuLateral.PerformLayout();
            menuSuperior.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuLateral;
        private Panel menuSuperior;
        private Panel panelEscritorio;
        private Button B_NuevaVenta;
        private Panel panel1;
        private Label labelUsuario;
        private PictureBox pictureBox1;
        private Button B_Proveedores;
        private Button B_NuevaCompra;
        private Button B_Entradas;
        private Button B_Inventario;
        private Label labelCargo;
        private Button B_Usuarios;
        private Panel panel2;
        private Button B_Ventas;
        private Button button2;
        private Button B_Compras;
        private Button button6;
        private Button button1;
        private PictureBox pictureBox3;
    }
}
