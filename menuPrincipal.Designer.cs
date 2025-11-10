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
            B_Reportes = new Button();
            B_Caja = new Button();
            B_Proveedores = new Button();
            B_Egresos = new Button();
            B_Ingresos = new Button();
            B_Inventario = new Button();
            B_Compras = new Button();
            B_Ventas = new Button();
            panel2 = new Panel();
            b_NewCompra = new Button();
            btnNuevaVenta = new Button();
            panel1 = new Panel();
            B_Salir = new Button();
            labelCargo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panelEscritorio.SuspendLayout();
            PanelSuperior.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = SystemColors.ActiveBorder;
            panelEscritorio.Controls.Add(PanelSuperior);
            panelEscritorio.Controls.Add(pictureBox3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(0, 0);
            panelEscritorio.Margin = new Padding(3, 2, 3, 2);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1267, 637);
            panelEscritorio.TabIndex = 2;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(26, 77, 128);
            PanelSuperior.Controls.Add(B_Reportes);
            PanelSuperior.Controls.Add(B_Caja);
            PanelSuperior.Controls.Add(B_Proveedores);
            PanelSuperior.Controls.Add(B_Egresos);
            PanelSuperior.Controls.Add(B_Ingresos);
            PanelSuperior.Controls.Add(B_Inventario);
            PanelSuperior.Controls.Add(B_Compras);
            PanelSuperior.Controls.Add(B_Ventas);
            PanelSuperior.Controls.Add(panel2);
            PanelSuperior.Controls.Add(panel1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Margin = new Padding(3, 2, 3, 2);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1267, 74);
            PanelSuperior.TabIndex = 3;
            // 
            // B_Reportes
            // 
            B_Reportes.AutoSize = true;
            B_Reportes.Dock = DockStyle.Left;
            B_Reportes.FlatAppearance.BorderSize = 0;
            B_Reportes.FlatStyle = FlatStyle.Flat;
            B_Reportes.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Reportes.ForeColor = SystemColors.ButtonFace;
            B_Reportes.Image = Properties.Resources.bar_chart_4_bars_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Reportes.Location = new Point(488, 0);
            B_Reportes.Margin = new Padding(3, 2, 3, 2);
            B_Reportes.Name = "B_Reportes";
            B_Reportes.Size = new Size(69, 74);
            B_Reportes.TabIndex = 14;
            B_Reportes.TabStop = false;
            B_Reportes.Text = "Reportes";
            B_Reportes.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Reportes.UseVisualStyleBackColor = true;
            B_Reportes.Click += B_Reportes_Click_2;
            // 
            // B_Caja
            // 
            B_Caja.AutoSize = true;
            B_Caja.Dock = DockStyle.Left;
            B_Caja.FlatAppearance.BorderSize = 0;
            B_Caja.FlatStyle = FlatStyle.Flat;
            B_Caja.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Caja.ForeColor = SystemColors.ButtonFace;
            B_Caja.Image = Properties.Resources.point_of_sale_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Caja.Location = new Point(427, 0);
            B_Caja.Margin = new Padding(3, 2, 3, 2);
            B_Caja.Name = "B_Caja";
            B_Caja.Size = new Size(61, 74);
            B_Caja.TabIndex = 13;
            B_Caja.TabStop = false;
            B_Caja.Text = "Caja";
            B_Caja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Caja.UseVisualStyleBackColor = true;
            B_Caja.Click += B_Caja_Click_1;
            // 
            // B_Proveedores
            // 
            B_Proveedores.AutoSize = true;
            B_Proveedores.Dock = DockStyle.Left;
            B_Proveedores.FlatAppearance.BorderSize = 0;
            B_Proveedores.FlatStyle = FlatStyle.Flat;
            B_Proveedores.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Proveedores.ForeColor = SystemColors.ButtonFace;
            B_Proveedores.Image = Properties.Resources.delivery_truck_speed_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Proveedores.Location = new Point(337, 0);
            B_Proveedores.Margin = new Padding(3, 2, 3, 2);
            B_Proveedores.Name = "B_Proveedores";
            B_Proveedores.Size = new Size(90, 74);
            B_Proveedores.TabIndex = 12;
            B_Proveedores.TabStop = false;
            B_Proveedores.Text = "Proveedores";
            B_Proveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Proveedores.UseVisualStyleBackColor = true;
            B_Proveedores.Click += B_Proveedores_Click_1;
            // 
            // B_Egresos
            // 
            B_Egresos.AutoSize = true;
            B_Egresos.Dock = DockStyle.Left;
            B_Egresos.FlatAppearance.BorderSize = 0;
            B_Egresos.FlatStyle = FlatStyle.Flat;
            B_Egresos.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Egresos.ForeColor = SystemColors.ButtonFace;
            B_Egresos.Image = Properties.Resources.banknote_arrow_down;
            B_Egresos.Location = new Point(276, 0);
            B_Egresos.Margin = new Padding(3, 2, 3, 2);
            B_Egresos.Name = "B_Egresos";
            B_Egresos.Size = new Size(61, 74);
            B_Egresos.TabIndex = 10;
            B_Egresos.TabStop = false;
            B_Egresos.Text = "Gastos";
            B_Egresos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Egresos.UseVisualStyleBackColor = true;
            B_Egresos.Click += B_Egresos_Click_1;
            // 
            // B_Ingresos
            // 
            B_Ingresos.AutoSize = true;
            B_Ingresos.Dock = DockStyle.Left;
            B_Ingresos.FlatAppearance.BorderSize = 0;
            B_Ingresos.FlatStyle = FlatStyle.Flat;
            B_Ingresos.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Ingresos.ForeColor = SystemColors.ButtonFace;
            B_Ingresos.Image = Properties.Resources.banknote_arrow_up;
            B_Ingresos.Location = new Point(209, 0);
            B_Ingresos.Margin = new Padding(3, 2, 3, 2);
            B_Ingresos.Name = "B_Ingresos";
            B_Ingresos.Size = new Size(67, 74);
            B_Ingresos.TabIndex = 9;
            B_Ingresos.TabStop = false;
            B_Ingresos.Text = "Ingresos";
            B_Ingresos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ingresos.UseVisualStyleBackColor = true;
            B_Ingresos.Click += B_Ingresos_Click_1;
            // 
            // B_Inventario
            // 
            B_Inventario.AutoSize = true;
            B_Inventario.Dock = DockStyle.Left;
            B_Inventario.FlatAppearance.BorderSize = 0;
            B_Inventario.FlatStyle = FlatStyle.Flat;
            B_Inventario.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Inventario.ForeColor = SystemColors.ButtonFace;
            B_Inventario.Image = Properties.Resources.inventory_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Inventario.Location = new Point(136, 0);
            B_Inventario.Margin = new Padding(3, 2, 3, 2);
            B_Inventario.Name = "B_Inventario";
            B_Inventario.Size = new Size(73, 74);
            B_Inventario.TabIndex = 8;
            B_Inventario.TabStop = false;
            B_Inventario.Text = "Inventario";
            B_Inventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Inventario.UseVisualStyleBackColor = true;
            B_Inventario.Click += B_Inventario_Click_1;
            // 
            // B_Compras
            // 
            B_Compras.AutoSize = true;
            B_Compras.BackColor = Color.FromArgb(0, 1, 227, 106);
            B_Compras.Dock = DockStyle.Left;
            B_Compras.FlatAppearance.BorderSize = 0;
            B_Compras.FlatStyle = FlatStyle.Flat;
            B_Compras.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Compras.ForeColor = SystemColors.ButtonFace;
            B_Compras.Image = Properties.Resources.store_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Compras.Location = new Point(67, 0);
            B_Compras.Margin = new Padding(3, 2, 3, 2);
            B_Compras.Name = "B_Compras";
            B_Compras.Size = new Size(69, 74);
            B_Compras.TabIndex = 7;
            B_Compras.TabStop = false;
            B_Compras.Text = "Compras";
            B_Compras.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Compras.UseVisualStyleBackColor = false;
            B_Compras.Click += B_Compras_Click_1;
            // 
            // B_Ventas
            // 
            B_Ventas.AutoSize = true;
            B_Ventas.BackColor = Color.FromArgb(0, 1, 227, 106);
            B_Ventas.Dock = DockStyle.Left;
            B_Ventas.FlatAppearance.BorderSize = 0;
            B_Ventas.FlatStyle = FlatStyle.Flat;
            B_Ventas.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Ventas.ForeColor = SystemColors.ButtonFace;
            B_Ventas.Image = Properties.Resources.payments_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            B_Ventas.Location = new Point(0, 0);
            B_Ventas.Margin = new Padding(3, 2, 3, 2);
            B_Ventas.Name = "B_Ventas";
            B_Ventas.Size = new Size(67, 74);
            B_Ventas.TabIndex = 6;
            B_Ventas.TabStop = false;
            B_Ventas.Text = "Ventas";
            B_Ventas.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ventas.UseVisualStyleBackColor = false;
            B_Ventas.Click += B_Ventas_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(b_NewCompra);
            panel2.Controls.Add(btnNuevaVenta);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(562, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 74);
            panel2.TabIndex = 1;
            // 
            // b_NewCompra
            // 
            b_NewCompra.BackColor = Color.Silver;
            b_NewCompra.FlatAppearance.BorderSize = 0;
            b_NewCompra.FlatStyle = FlatStyle.System;
            b_NewCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b_NewCompra.Image = Properties.Resources.shoppingmode_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            b_NewCompra.ImageAlign = ContentAlignment.MiddleLeft;
            b_NewCompra.Location = new Point(24, 14);
            b_NewCompra.Name = "b_NewCompra";
            b_NewCompra.Size = new Size(147, 43);
            b_NewCompra.TabIndex = 3;
            b_NewCompra.Text = "Nueva Compra";
            b_NewCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_NewCompra.UseVisualStyleBackColor = false;
            b_NewCompra.Click += b_NewCompra_Click;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevaVenta.BackColor = Color.FromArgb(240, 180, 41);
            btnNuevaVenta.FlatAppearance.BorderSize = 0;
            btnNuevaVenta.FlatStyle = FlatStyle.System;
            btnNuevaVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaVenta.Image = Properties.Resources.shoppingmode_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            btnNuevaVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaVenta.Location = new Point(189, 14);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(139, 43);
            btnNuevaVenta.TabIndex = 2;
            btnNuevaVenta.Text = "Nueva Venta ";
            btnNuevaVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaVenta.UseVisualStyleBackColor = false;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(B_Salir);
            panel1.Controls.Add(labelCargo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(919, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 74);
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
            B_Salir.Location = new Point(280, 0);
            B_Salir.Margin = new Padding(3, 2, 3, 2);
            B_Salir.Name = "B_Salir";
            B_Salir.Size = new Size(68, 74);
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
            labelCargo.Location = new Point(88, 42);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(52, 21);
            labelCargo.TabIndex = 3;
            labelCargo.Text = "Cargo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoEllipsis = true;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(88, 20);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(80, 21);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Nickname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero;
            pictureBox1.Location = new Point(18, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.Chitos__1_;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1267, 637);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1267, 637);
            Controls.Add(panelEscritorio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "menuPrincipal";
            Text = "Punto de Venta Chito's";
            Shown += menuPrincipal_Shown;
            KeyDown += menuPrincipal_KeyDown;
            panelEscritorio.ResumeLayout(false);
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelEscritorio;
        private PictureBox pictureBox3;
        private Panel PanelSuperior;
        private Panel panel1;
        private Button B_Salir;
        private Label labelCargo;
        private Label labelUsuario;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNuevaVenta;
        private Button B_Compras;
        private Button B_Ventas;
        private Button B_Reportes;
        private Button B_Caja;
        private Button B_Proveedores;
        private Button B_Egresos;
        private Button B_Ingresos;
        private Button B_Inventario;
        private Button b_NewCompra;
    }
}
