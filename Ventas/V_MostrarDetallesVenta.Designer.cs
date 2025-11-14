namespace POS_CHITOS
{
    partial class V_MostrarDetallesVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MostrarDetallesVenta));
            panel1 = new Panel();
            B_Cerrar = new Button();
            label4 = new Label();
            TB_TotalVenta = new TextBox();
            DGV_DetallesVentas = new DataGridView();
            panelSuperior = new Panel();
            pictureBox2 = new PictureBox();
            TB_Placa = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            TB_Usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TB_FolioVenta = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Proveedor = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVentas).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(B_Cerrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TB_TotalVenta);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 433);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 59);
            panel1.TabIndex = 10;
            // 
            // B_Cerrar
            // 
            B_Cerrar.BackColor = SystemColors.ControlLightLight;
            B_Cerrar.Cursor = Cursors.Hand;
            B_Cerrar.Dock = DockStyle.Left;
            B_Cerrar.FlatAppearance.BorderSize = 0;
            B_Cerrar.FlatStyle = FlatStyle.Flat;
            B_Cerrar.Font = new Font("Segoe UI", 12F);
            B_Cerrar.ForeColor = Color.FromArgb(44, 140, 153);
            B_Cerrar.Image = Properties.Resources.rechazar__1_;
            B_Cerrar.Location = new Point(0, 0);
            B_Cerrar.Margin = new Padding(3, 2, 3, 2);
            B_Cerrar.Name = "B_Cerrar";
            B_Cerrar.Size = new Size(94, 59);
            B_Cerrar.TabIndex = 6;
            B_Cerrar.Text = "Salir";
            B_Cerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cerrar.UseVisualStyleBackColor = false;
            B_Cerrar.Click += B_Cerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(822, 11);
            label4.Name = "label4";
            label4.Size = new Size(83, 37);
            label4.TabIndex = 1;
            label4.Text = "Total:";
            // 
            // TB_TotalVenta
            // 
            TB_TotalVenta.Dock = DockStyle.Right;
            TB_TotalVenta.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalVenta.Location = new Point(929, 0);
            TB_TotalVenta.Margin = new Padding(3, 2, 3, 2);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.ReadOnly = true;
            TB_TotalVenta.Size = new Size(353, 63);
            TB_TotalVenta.TabIndex = 0;
            // 
            // DGV_DetallesVentas
            // 
            DGV_DetallesVentas.AllowUserToAddRows = false;
            DGV_DetallesVentas.AllowUserToResizeColumns = false;
            DGV_DetallesVentas.AllowUserToResizeRows = false;
            DGV_DetallesVentas.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesVentas.Dock = DockStyle.Fill;
            DGV_DetallesVentas.Location = new Point(0, 115);
            DGV_DetallesVentas.Margin = new Padding(3, 2, 3, 2);
            DGV_DetallesVentas.MultiSelect = false;
            DGV_DetallesVentas.Name = "DGV_DetallesVentas";
            DGV_DetallesVentas.ReadOnly = true;
            DGV_DetallesVentas.RowHeadersWidth = 51;
            DGV_DetallesVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVentas.Size = new Size(1282, 377);
            DGV_DetallesVentas.TabIndex = 9;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(TB_Placa);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(pictureBox3);
            panelSuperior.Controls.Add(pictureBox4);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(TB_Usuario);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(TB_FolioVenta);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(Proveedor);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 2, 3, 2);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1282, 115);
            panelSuperior.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.placa;
            pictureBox2.Location = new Point(10, 31);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 28);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // TB_Placa
            // 
            TB_Placa.Font = new Font("Segoe UI", 12F);
            TB_Placa.Location = new Point(46, 31);
            TB_Placa.Margin = new Padding(3, 2, 3, 2);
            TB_Placa.Name = "TB_Placa";
            TB_Placa.PlaceholderText = "Ingresa la placa";
            TB_Placa.ReadOnly = true;
            TB_Placa.Size = new Size(256, 29);
            TB_Placa.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendario;
            pictureBox1.Location = new Point(928, 78);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.factura;
            pictureBox3.Location = new Point(929, 25);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 28);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.servicio_al_cliente;
            pictureBox4.Location = new Point(10, 76);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 28);
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1040, 55);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 8;
            label3.Text = "Fecha de la compra:";
            // 
            // TB_Usuario
            // 
            TB_Usuario.Font = new Font("Segoe UI", 12F);
            TB_Usuario.Location = new Point(46, 78);
            TB_Usuario.Margin = new Padding(3, 2, 3, 2);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.ReadOnly = true;
            TB_Usuario.Size = new Size(256, 29);
            TB_Usuario.TabIndex = 7;
            TB_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(74, 56);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 6;
            label2.Text = "Venta registrada por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1096, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 5;
            label1.Text = "Folio";
            // 
            // TB_FolioVenta
            // 
            TB_FolioVenta.Font = new Font("Segoe UI", 12F);
            TB_FolioVenta.Location = new Point(964, 27);
            TB_FolioVenta.Margin = new Padding(3, 2, 3, 2);
            TB_FolioVenta.Name = "TB_FolioVenta";
            TB_FolioVenta.ReadOnly = true;
            TB_FolioVenta.Size = new Size(308, 29);
            TB_FolioVenta.TabIndex = 4;
            TB_FolioVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(964, 78);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 29);
            dateTimePicker1.TabIndex = 3;
            // 
            // Proveedor
            // 
            Proveedor.AutoSize = true;
            Proveedor.Font = new Font("Segoe UI", 12F);
            Proveedor.Location = new Point(138, 8);
            Proveedor.Name = "Proveedor";
            Proveedor.Size = new Size(58, 21);
            Proveedor.TabIndex = 2;
            Proveedor.Text = "Cliente";
            // 
            // V_MostrarDetallesVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 492);
            Controls.Add(panel1);
            Controls.Add(DGV_DetallesVentas);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_MostrarDetallesVenta";
            Text = "Mostrar Detalles de laVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVentas).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TB_TotalVenta;
        private DataGridView DGV_DetallesVentas;
        private Panel panelSuperior;
        private Label label3;
        private TextBox TB_Usuario;
        private Label label2;
        private Label label1;
        private TextBox TB_FolioVenta;
        private DateTimePicker dateTimePicker1;
        private Label Proveedor;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox TB_Placa;
        private Button B_Cerrar;
    }
}