namespace POS_CHITOS
{
    partial class V_MostrarDetallesCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MostrarDetallesCompras));
            DGV_DetallesCompras = new DataGridView();
            panelSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            TB_Usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TB_IdCompra = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Proveedor = new Label();
            TB_Proveedor = new TextBox();
            panel1 = new Panel();
            TB_TotalCompra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_DetallesCompras
            // 
            DGV_DetallesCompras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesCompras.Dock = DockStyle.Fill;
            DGV_DetallesCompras.Location = new Point(0, 153);
            DGV_DetallesCompras.MultiSelect = false;
            DGV_DetallesCompras.Name = "DGV_DetallesCompras";
            DGV_DetallesCompras.ReadOnly = true;
            DGV_DetallesCompras.RowHeadersWidth = 51;
            DGV_DetallesCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesCompras.Size = new Size(1370, 527);
            DGV_DetallesCompras.TabIndex = 6;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(pictureBox3);
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(TB_Usuario);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(TB_IdCompra);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(Proveedor);
            panelSuperior.Controls.Add(TB_Proveedor);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1370, 153);
            panelSuperior.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.servicio_al_cliente;
            pictureBox1.Location = new Point(17, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.factura;
            pictureBox3.Location = new Point(1087, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.servicio_al_cliente;
            pictureBox2.Location = new Point(17, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(574, 37);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 8;
            label3.Text = "Fecha de la compra:";
            // 
            // TB_Usuario
            // 
            TB_Usuario.Font = new Font("Segoe UI", 12F);
            TB_Usuario.Location = new Point(55, 105);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.ReadOnly = true;
            TB_Usuario.Size = new Size(292, 34);
            TB_Usuario.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(93, 76);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 6;
            label2.Text = "Compra registrada por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1159, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 5;
            label1.Text = "FolioCompra";
            // 
            // TB_IdCompra
            // 
            TB_IdCompra.Font = new Font("Segoe UI", 12F);
            TB_IdCompra.Location = new Point(1125, 40);
            TB_IdCompra.Name = "TB_IdCompra";
            TB_IdCompra.ReadOnly = true;
            TB_IdCompra.Size = new Size(233, 34);
            TB_IdCompra.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Arial", 12F);
            dateTimePicker1.Location = new Point(494, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(368, 30);
            dateTimePicker1.TabIndex = 3;
            // 
            // Proveedor
            // 
            Proveedor.AutoSize = true;
            Proveedor.Font = new Font("Segoe UI", 12F);
            Proveedor.Location = new Point(145, 6);
            Proveedor.Name = "Proveedor";
            Proveedor.Size = new Size(103, 28);
            Proveedor.TabIndex = 2;
            Proveedor.Text = "Proveedor";
            // 
            // TB_Proveedor
            // 
            TB_Proveedor.Font = new Font("Segoe UI", 12F);
            TB_Proveedor.Location = new Point(55, 37);
            TB_Proveedor.Name = "TB_Proveedor";
            TB_Proveedor.ReadOnly = true;
            TB_Proveedor.Size = new Size(292, 34);
            TB_Proveedor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(TB_TotalCompra);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 601);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 79);
            panel1.TabIndex = 7;
            // 
            // TB_TotalCompra
            // 
            TB_TotalCompra.Dock = DockStyle.Right;
            TB_TotalCompra.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalCompra.Location = new Point(1086, 0);
            TB_TotalCompra.Name = "TB_TotalCompra";
            TB_TotalCompra.ReadOnly = true;
            TB_TotalCompra.Size = new Size(284, 77);
            TB_TotalCompra.TabIndex = 0;
            // 
            // V_MostrarDetallesCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 680);
            Controls.Add(panel1);
            Controls.Add(DGV_DetallesCompras);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_MostrarDetallesCompras";
            Text = "Detalles de la compra";
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_DetallesCompras;
        private Panel panelSuperior;
        private TextBox TB_Proveedor;
        private Label label1;
        private TextBox TB_IdCompra;
        private DateTimePicker dateTimePicker1;
        private Label Proveedor;
        private TextBox TB_Usuario;
        private Label label2;
        private Label label3;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_AgregarCompra;
        private Button B_ModificarCompra;
        private Button B_CancelarCompra;
        private TextBox TB_BuscarCompra;
        private Panel panel1;
        private TextBox TB_TotalCompra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}