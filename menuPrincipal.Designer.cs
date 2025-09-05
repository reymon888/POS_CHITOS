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
            panelEscritorio = new Panel();
            PanelSuperior = new Panel();
            panel2 = new Panel();
            btnNuevaVenta = new Button();
            panel1 = new Panel();
            B_Salir = new Button();
            labelCargo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            PanelLateral = new FlowLayoutPanel();
            B_Ventas = new Button();
            B_Compras = new Button();
            B_Inventario = new Button();
            B_Ingresos = new Button();
            B_Egresos = new Button();
            B_Clientes = new Button();
            B_Proveedores = new Button();
            B_Caja = new Button();
            B_Reportes = new Button();
            B_Usuarios = new Button();
            pictureBox3 = new PictureBox();
            panelEscritorio.SuspendLayout();
            PanelSuperior.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = SystemColors.ActiveBorder;
            panelEscritorio.Controls.Add(PanelSuperior);
            panelEscritorio.Controls.Add(PanelLateral);
            panelEscritorio.Controls.Add(pictureBox3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(0, 0);
            panelEscritorio.Margin = new Padding(4, 3, 4, 3);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1810, 1062);
            panelEscritorio.TabIndex = 2;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(26, 77, 128);
            PanelSuperior.Controls.Add(panel2);
            PanelSuperior.Controls.Add(panel1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(92, 0);
            PanelSuperior.Margin = new Padding(4, 3, 4, 3);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1718, 123);
            PanelSuperior.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNuevaVenta);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(902, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 123);
            panel2.TabIndex = 1;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevaVenta.BackColor = Color.FromArgb(240, 180, 41);
            btnNuevaVenta.FlatAppearance.BorderSize = 0;
            btnNuevaVenta.FlatStyle = FlatStyle.Flat;
            btnNuevaVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaVenta.Image = Properties.Resources.shoppingmode_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnNuevaVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaVenta.Location = new Point(26, 23);
            btnNuevaVenta.Margin = new Padding(4, 5, 4, 5);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(244, 71);
            btnNuevaVenta.TabIndex = 2;
            btnNuevaVenta.Text = "Nueva Venta (F12)";
            btnNuevaVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(B_Salir);
            panel1.Controls.Add(labelCargo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1202, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 123);
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
            B_Salir.Location = new Point(419, 0);
            B_Salir.Margin = new Padding(4, 3, 4, 3);
            B_Salir.Name = "B_Salir";
            B_Salir.Size = new Size(97, 123);
            B_Salir.TabIndex = 11;
            B_Salir.TabStop = false;
            B_Salir.Text = " (F12)";
            B_Salir.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Salir.UseVisualStyleBackColor = true;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Segoe UI", 12F);
            labelCargo.ForeColor = SystemColors.ButtonHighlight;
            labelCargo.Location = new Point(126, 70);
            labelCargo.Margin = new Padding(4, 0, 4, 0);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(77, 32);
            labelCargo.TabIndex = 3;
            labelCargo.Text = "Cargo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoEllipsis = true;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(126, 33);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(121, 32);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Nickname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero;
            pictureBox1.Location = new Point(26, 7);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = Color.FromArgb(26, 77, 128);
            PanelLateral.Controls.Add(B_Ventas);
            PanelLateral.Controls.Add(B_Compras);
            PanelLateral.Controls.Add(B_Inventario);
            PanelLateral.Controls.Add(B_Ingresos);
            PanelLateral.Controls.Add(B_Egresos);
            PanelLateral.Controls.Add(B_Clientes);
            PanelLateral.Controls.Add(B_Proveedores);
            PanelLateral.Controls.Add(B_Caja);
            PanelLateral.Controls.Add(B_Reportes);
            PanelLateral.Controls.Add(B_Usuarios);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Margin = new Padding(4, 5, 4, 5);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(92, 1062);
            PanelLateral.TabIndex = 1;
            PanelLateral.Paint += flowLayoutPanel1_Paint;
            PanelLateral.MouseEnter += PanelLateral_MouseEnter;
            PanelLateral.MouseLeave += PanelLateral_MouseLeave;
            PanelLateral.Resize += PanelLateral_Resize;
            // 
            // B_Ventas
            // 
            B_Ventas.AutoSize = true;
            B_Ventas.BackColor = Color.FromArgb(0, 1, 227, 106);
            B_Ventas.Dock = DockStyle.Top;
            B_Ventas.FlatAppearance.BorderSize = 0;
            B_Ventas.FlatStyle = FlatStyle.Flat;
            B_Ventas.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Ventas.ForeColor = SystemColors.ButtonFace;
            B_Ventas.Image = Properties.Resources.payments_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Ventas.Location = new Point(4, 3);
            B_Ventas.Margin = new Padding(4, 3, 4, 3);
            B_Ventas.Name = "B_Ventas";
            B_Ventas.Size = new Size(87, 92);
            B_Ventas.TabIndex = 5;
            B_Ventas.TabStop = false;
            B_Ventas.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Ventas.UseVisualStyleBackColor = false;
            B_Ventas.Click += B_Ventas_Click;
            // 
            // B_Compras
            // 
            B_Compras.AutoSize = true;
            B_Compras.BackColor = Color.FromArgb(0, 1, 227, 106);
            B_Compras.Dock = DockStyle.Top;
            B_Compras.FlatAppearance.BorderSize = 0;
            B_Compras.FlatStyle = FlatStyle.Flat;
            B_Compras.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Compras.ForeColor = SystemColors.ButtonFace;
            B_Compras.Image = Properties.Resources.store_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Compras.Location = new Point(4, 101);
            B_Compras.Margin = new Padding(4, 3, 4, 3);
            B_Compras.Name = "B_Compras";
            B_Compras.Size = new Size(87, 83);
            B_Compras.TabIndex = 6;
            B_Compras.TabStop = false;
            B_Compras.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Compras.UseVisualStyleBackColor = false;
            // 
            // B_Inventario
            // 
            B_Inventario.AutoSize = true;
            B_Inventario.Dock = DockStyle.Top;
            B_Inventario.FlatAppearance.BorderSize = 0;
            B_Inventario.FlatStyle = FlatStyle.Flat;
            B_Inventario.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Inventario.ForeColor = SystemColors.ButtonFace;
            B_Inventario.Image = Properties.Resources.inventory_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Inventario.Location = new Point(4, 190);
            B_Inventario.Margin = new Padding(4, 3, 4, 3);
            B_Inventario.Name = "B_Inventario";
            B_Inventario.Size = new Size(87, 83);
            B_Inventario.TabIndex = 7;
            B_Inventario.TabStop = false;
            B_Inventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Inventario.UseVisualStyleBackColor = true;
            // 
            // B_Ingresos
            // 
            B_Ingresos.AutoSize = true;
            B_Ingresos.Dock = DockStyle.Top;
            B_Ingresos.FlatAppearance.BorderSize = 0;
            B_Ingresos.FlatStyle = FlatStyle.Flat;
            B_Ingresos.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Ingresos.ForeColor = SystemColors.ButtonFace;
            B_Ingresos.Image = Properties.Resources.banknote_arrow_up;
            B_Ingresos.Location = new Point(4, 279);
            B_Ingresos.Margin = new Padding(4, 3, 4, 3);
            B_Ingresos.Name = "B_Ingresos";
            B_Ingresos.Size = new Size(87, 83);
            B_Ingresos.TabIndex = 8;
            B_Ingresos.TabStop = false;
            B_Ingresos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ingresos.UseVisualStyleBackColor = true;
            // 
            // B_Egresos
            // 
            B_Egresos.AutoSize = true;
            B_Egresos.Dock = DockStyle.Top;
            B_Egresos.FlatAppearance.BorderSize = 0;
            B_Egresos.FlatStyle = FlatStyle.Flat;
            B_Egresos.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Egresos.ForeColor = SystemColors.ButtonFace;
            B_Egresos.Image = Properties.Resources.banknote_arrow_down;
            B_Egresos.Location = new Point(4, 368);
            B_Egresos.Margin = new Padding(4, 3, 4, 3);
            B_Egresos.Name = "B_Egresos";
            B_Egresos.Size = new Size(87, 83);
            B_Egresos.TabIndex = 9;
            B_Egresos.TabStop = false;
            B_Egresos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Egresos.UseVisualStyleBackColor = true;
            // 
            // B_Clientes
            // 
            B_Clientes.AutoSize = true;
            B_Clientes.Dock = DockStyle.Top;
            B_Clientes.FlatAppearance.BorderSize = 0;
            B_Clientes.FlatStyle = FlatStyle.Flat;
            B_Clientes.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Clientes.ForeColor = SystemColors.ButtonFace;
            B_Clientes.Image = Properties.Resources.person_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Clientes.Location = new Point(4, 457);
            B_Clientes.Margin = new Padding(4, 3, 4, 3);
            B_Clientes.Name = "B_Clientes";
            B_Clientes.Size = new Size(87, 83);
            B_Clientes.TabIndex = 10;
            B_Clientes.TabStop = false;
            B_Clientes.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Clientes.UseVisualStyleBackColor = true;
            B_Clientes.Click += B_Clientes_Click;
            // 
            // B_Proveedores
            // 
            B_Proveedores.AutoSize = true;
            B_Proveedores.Dock = DockStyle.Top;
            B_Proveedores.FlatAppearance.BorderSize = 0;
            B_Proveedores.FlatStyle = FlatStyle.Flat;
            B_Proveedores.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Proveedores.ForeColor = SystemColors.ButtonFace;
            B_Proveedores.Image = Properties.Resources.delivery_truck_speed_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Proveedores.Location = new Point(4, 546);
            B_Proveedores.Margin = new Padding(4, 3, 4, 3);
            B_Proveedores.Name = "B_Proveedores";
            B_Proveedores.Size = new Size(87, 83);
            B_Proveedores.TabIndex = 11;
            B_Proveedores.TabStop = false;
            B_Proveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Proveedores.UseVisualStyleBackColor = true;
            // 
            // B_Caja
            // 
            B_Caja.AutoSize = true;
            B_Caja.Dock = DockStyle.Top;
            B_Caja.FlatAppearance.BorderSize = 0;
            B_Caja.FlatStyle = FlatStyle.Flat;
            B_Caja.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Caja.ForeColor = SystemColors.ButtonFace;
            B_Caja.Image = Properties.Resources.point_of_sale_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Caja.Location = new Point(4, 635);
            B_Caja.Margin = new Padding(4, 3, 4, 3);
            B_Caja.Name = "B_Caja";
            B_Caja.Size = new Size(87, 83);
            B_Caja.TabIndex = 12;
            B_Caja.TabStop = false;
            B_Caja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Caja.UseVisualStyleBackColor = true;
            // 
            // B_Reportes
            // 
            B_Reportes.AutoSize = true;
            B_Reportes.Dock = DockStyle.Top;
            B_Reportes.FlatAppearance.BorderSize = 0;
            B_Reportes.FlatStyle = FlatStyle.Flat;
            B_Reportes.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Reportes.ForeColor = SystemColors.ButtonFace;
            B_Reportes.Image = Properties.Resources.bar_chart_4_bars_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Reportes.Location = new Point(4, 724);
            B_Reportes.Margin = new Padding(4, 3, 4, 3);
            B_Reportes.Name = "B_Reportes";
            B_Reportes.Size = new Size(87, 83);
            B_Reportes.TabIndex = 13;
            B_Reportes.TabStop = false;
            B_Reportes.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Reportes.UseVisualStyleBackColor = true;
            // 
            // B_Usuarios
            // 
            B_Usuarios.AutoSize = true;
            B_Usuarios.Dock = DockStyle.Top;
            B_Usuarios.FlatAppearance.BorderSize = 0;
            B_Usuarios.FlatStyle = FlatStyle.Flat;
            B_Usuarios.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Usuarios.ForeColor = SystemColors.ButtonFace;
            B_Usuarios.Image = Properties.Resources.manage_accounts_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Usuarios.Location = new Point(4, 813);
            B_Usuarios.Margin = new Padding(4, 3, 4, 3);
            B_Usuarios.Name = "B_Usuarios";
            B_Usuarios.Size = new Size(87, 83);
            B_Usuarios.TabIndex = 14;
            B_Usuarios.TabStop = false;
            B_Usuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Usuarios.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.Chitos__1_;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1810, 1062);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1810, 1062);
            Controls.Add(panelEscritorio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "menuPrincipal";
            Text = "Punto de Venta Chito's";
            Load += Form1_Load;
            KeyDown += menuPrincipal_KeyDown;
            panelEscritorio.ResumeLayout(false);
            PanelSuperior.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelLateral.ResumeLayout(false);
            PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelEscritorio;
        private PictureBox pictureBox3;
        private FlowLayoutPanel PanelLateral;
        private Button B_Ventas;
        private Button B_Compras;
        private Button B_Inventario;
        private Button B_Ingresos;
        private Button B_Egresos;
        private Button B_Clientes;
        private Button B_Proveedores;
        private Button B_Caja;
        private Button B_Reportes;
        private Button B_Usuarios;
        private Panel PanelSuperior;
        private Panel panel1;
        private Button B_Salir;
        private Label labelCargo;
        private Label labelUsuario;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNuevaVenta;
    }
}
