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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            PanelLateral = new Panel();
            B_Gastos = new Button();
            B_Usuarios = new Button();
            B_Proveedores = new Button();
            B_NuevaCompra = new Button();
            B_Entradas = new Button();
            B_Inventario = new Button();
            B_NuevaVenta = new Button();
            PanelSuperior = new Panel();
            B_Ventas = new Button();
            B_Reportes = new Button();
            B_Cortes = new Button();
            B_Compras = new Button();
            panel1 = new Panel();
            B_Salir = new Button();
            labelCargo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            panelEscritorio = new Panel();
            pictureBox3 = new PictureBox();
            PanelLateral.SuspendLayout();
            PanelSuperior.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = Color.FromArgb(26, 77, 128);
            PanelLateral.Controls.Add(B_Gastos);
            PanelLateral.Controls.Add(B_Usuarios);
            PanelLateral.Controls.Add(B_Proveedores);
            PanelLateral.Controls.Add(B_NuevaCompra);
            PanelLateral.Controls.Add(B_Entradas);
            PanelLateral.Controls.Add(B_Inventario);
            PanelLateral.Controls.Add(B_NuevaVenta);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(106, 993);
            PanelLateral.TabIndex = 0;
            PanelLateral.Paint += menuLateral_Paint;
            // 
            // B_Gastos
            // 
            B_Gastos.AutoSize = true;
            B_Gastos.Dock = DockStyle.Top;
            B_Gastos.FlatAppearance.BorderSize = 0;
            B_Gastos.FlatStyle = FlatStyle.Flat;
            B_Gastos.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Gastos.ForeColor = SystemColors.ButtonFace;
            B_Gastos.Image = Properties.Resources.salir;
            B_Gastos.Location = new Point(0, 840);
            B_Gastos.Name = "B_Gastos";
            B_Gastos.Size = new Size(106, 140);
            B_Gastos.TabIndex = 10;
            B_Gastos.TabStop = false;
            B_Gastos.Text = "Gastos $-  (F7)";
            B_Gastos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Gastos.UseVisualStyleBackColor = true;
            B_Gastos.Click += B_Gastos_Click;
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
            B_Usuarios.TabStop = false;
            B_Usuarios.Text = "Usuarios (F6)";
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
            B_Proveedores.TabStop = false;
            B_Proveedores.Text = "Proveedor  (F5)";
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
            B_NuevaCompra.Text = "Realizar Compra   (F4)";
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
            B_Entradas.TabStop = false;
            B_Entradas.Text = "Ingresos (F3)";
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
            B_Inventario.TabStop = false;
            B_Inventario.Text = "Inventario (F2)";
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
            B_NuevaVenta.TabStop = false;
            B_NuevaVenta.Text = "Realizar Venta (F1)";
            B_NuevaVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_NuevaVenta.UseVisualStyleBackColor = true;
            B_NuevaVenta.Click += B_NuevaVenta_Click;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(26, 77, 128);
            PanelSuperior.Controls.Add(B_Ventas);
            PanelSuperior.Controls.Add(B_Reportes);
            PanelSuperior.Controls.Add(B_Cortes);
            PanelSuperior.Controls.Add(B_Compras);
            PanelSuperior.Controls.Add(panel1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(106, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1342, 113);
            PanelSuperior.TabIndex = 1;
            PanelSuperior.Paint += menuSuperior_Paint;
            // 
            // B_Ventas
            // 
            B_Ventas.AutoSize = true;
            B_Ventas.BackColor = Color.FromArgb(26, 77, 128);
            B_Ventas.Dock = DockStyle.Left;
            B_Ventas.FlatAppearance.BorderSize = 0;
            B_Ventas.FlatStyle = FlatStyle.Flat;
            B_Ventas.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Ventas.ForeColor = SystemColors.ButtonHighlight;
            B_Ventas.Image = Properties.Resources.grafico_de_barras;
            B_Ventas.Location = new Point(227, 0);
            B_Ventas.Name = "B_Ventas";
            B_Ventas.Size = new Size(104, 113);
            B_Ventas.TabIndex = 14;
            B_Ventas.TabStop = false;
            B_Ventas.Text = "Ventas (F10)";
            B_Ventas.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ventas.UseVisualStyleBackColor = false;
            B_Ventas.Click += B_Ventas_Click;
            // 
            // B_Reportes
            // 
            B_Reportes.AutoSize = true;
            B_Reportes.BackColor = Color.FromArgb(26, 77, 128);
            B_Reportes.Dock = DockStyle.Left;
            B_Reportes.FlatAppearance.BorderSize = 0;
            B_Reportes.FlatStyle = FlatStyle.Flat;
            B_Reportes.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Reportes.ForeColor = SystemColors.ButtonHighlight;
            B_Reportes.Image = Properties.Resources.reporte;
            B_Reportes.Location = new Point(112, 0);
            B_Reportes.Name = "B_Reportes";
            B_Reportes.Size = new Size(115, 113);
            B_Reportes.TabIndex = 13;
            B_Reportes.TabStop = false;
            B_Reportes.Text = "Reportes (F9)";
            B_Reportes.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Reportes.UseVisualStyleBackColor = false;
            B_Reportes.Click += B_Reportes_Click_1;
            // 
            // B_Cortes
            // 
            B_Cortes.AutoSize = true;
            B_Cortes.Dock = DockStyle.Right;
            B_Cortes.FlatAppearance.BorderSize = 0;
            B_Cortes.FlatStyle = FlatStyle.Flat;
            B_Cortes.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Cortes.ForeColor = SystemColors.ButtonFace;
            B_Cortes.Image = Properties.Resources.cajero_automatico;
            B_Cortes.Location = new Point(818, 0);
            B_Cortes.Name = "B_Cortes";
            B_Cortes.Size = new Size(111, 113);
            B_Cortes.TabIndex = 4;
            B_Cortes.TabStop = false;
            B_Cortes.Text = "Caja (F11)";
            B_Cortes.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cortes.UseVisualStyleBackColor = true;
            B_Cortes.Click += B_Cortes_Click;
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
            B_Compras.Size = new Size(112, 113);
            B_Compras.TabIndex = 12;
            B_Compras.TabStop = false;
            B_Compras.Text = "Compras (F8)";
            B_Compras.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Compras.UseVisualStyleBackColor = false;
            B_Compras.Click += B_Compras_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(B_Salir);
            panel1.Controls.Add(labelCargo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(929, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 113);
            panel1.TabIndex = 0;
            // 
            // B_Salir
            // 
            B_Salir.AutoSize = true;
            B_Salir.Dock = DockStyle.Right;
            B_Salir.FlatAppearance.BorderSize = 0;
            B_Salir.FlatStyle = FlatStyle.Flat;
            B_Salir.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Salir.ForeColor = SystemColors.ButtonFace;
            B_Salir.Image = Properties.Resources.boton_x;
            B_Salir.Location = new Point(356, 0);
            B_Salir.Name = "B_Salir";
            B_Salir.Size = new Size(57, 113);
            B_Salir.TabIndex = 11;
            B_Salir.TabStop = false;
            B_Salir.Text = " (F12)";
            B_Salir.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Salir.UseVisualStyleBackColor = true;
            B_Salir.Click += B_Salir_Click;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Segoe UI", 12F);
            labelCargo.ForeColor = SystemColors.ButtonHighlight;
            labelCargo.Location = new Point(100, 56);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(65, 28);
            labelCargo.TabIndex = 3;
            labelCargo.Text = "Cargo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoEllipsis = true;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(100, 27);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(99, 28);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Nickname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero;
            pictureBox1.Location = new Point(18, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
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
            panelEscritorio.Size = new Size(1342, 880);
            panelEscritorio.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.Chitos__1_;
            pictureBox3.Location = new Point(3, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1333, 892);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1448, 993);
            Controls.Add(panelEscritorio);
            Controls.Add(PanelSuperior);
            Controls.Add(PanelLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menuPrincipal";
            Text = "Punto de Venta Chito's";
            Load += Form1_Load;
            KeyDown += menuPrincipal_KeyDown;
            PanelLateral.ResumeLayout(false);
            PanelLateral.PerformLayout();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLateral;
        private Panel PanelSuperior;
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
        private Button B_Ventas;
        private Button B_Reportes;
        private Button B_Compras;
        private Button B_Salir;
        private Button B_Gastos;
        private PictureBox pictureBox3;
        private Button B_Cortes;
    }
}
