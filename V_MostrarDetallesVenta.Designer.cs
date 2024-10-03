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
            panel1 = new Panel();
            TB_TotalVenta = new TextBox();
            DGV_DetallesVentas = new DataGridView();
            panelSuperior = new Panel();
            label3 = new Label();
            TB_Usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TB_FolioVenta = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            TB_Cliente = new TextBox();
            Proveedor = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVentas).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(TB_TotalVenta);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 549);
            panel1.Name = "panel1";
            panel1.Size = new Size(1465, 79);
            panel1.TabIndex = 10;
            // 
            // TB_TotalVenta
            // 
            TB_TotalVenta.Dock = DockStyle.Right;
            TB_TotalVenta.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalVenta.Location = new Point(1062, 0);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.ReadOnly = true;
            TB_TotalVenta.Size = new Size(403, 77);
            TB_TotalVenta.TabIndex = 0;
            // 
            // DGV_DetallesVentas
            // 
            DGV_DetallesVentas.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesVentas.Dock = DockStyle.Fill;
            DGV_DetallesVentas.Location = new Point(0, 153);
            DGV_DetallesVentas.MultiSelect = false;
            DGV_DetallesVentas.Name = "DGV_DetallesVentas";
            DGV_DetallesVentas.ReadOnly = true;
            DGV_DetallesVentas.RowHeadersWidth = 51;
            DGV_DetallesVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVentas.Size = new Size(1465, 475);
            DGV_DetallesVentas.TabIndex = 9;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(TB_Usuario);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(TB_FolioVenta);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(Proveedor);
            panelSuperior.Controls.Add(TB_Cliente);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1465, 153);
            panelSuperior.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(1191, 78);
            label3.Name = "label3";
            label3.Size = new Size(209, 23);
            label3.TabIndex = 8;
            label3.Text = "Fecha de la compra:";
            // 
            // TB_Usuario
            // 
            TB_Usuario.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Usuario.Location = new Point(12, 104);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.ReadOnly = true;
            TB_Usuario.Size = new Size(292, 34);
            TB_Usuario.TabIndex = 7;
            TB_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(35, 78);
            label2.Name = "label2";
            label2.Size = new Size(242, 23);
            label2.TabIndex = 6;
            label2.Text = "Compra registrada por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(1253, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 5;
            label1.Text = "Folio";
            // 
            // TB_FolioVenta
            // 
            TB_FolioVenta.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_FolioVenta.Location = new Point(1102, 31);
            TB_FolioVenta.Name = "TB_FolioVenta";
            TB_FolioVenta.ReadOnly = true;
            TB_FolioVenta.Size = new Size(351, 34);
            TB_FolioVenta.TabIndex = 4;
            TB_FolioVenta.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Arial", 12F);
            dateTimePicker1.Location = new Point(1102, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(351, 30);
            dateTimePicker1.TabIndex = 3;
            // 
            // TB_Cliente
            // 
            TB_Cliente.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cliente.Location = new Point(3, 37);
            TB_Cliente.Name = "TB_Cliente";
            TB_Cliente.ReadOnly = true;
            TB_Cliente.Size = new Size(292, 34);
            TB_Cliente.TabIndex = 1;
            TB_Cliente.Text = "Publico en general";
            TB_Cliente.TextAlign = HorizontalAlignment.Center;
            // 
            // Proveedor
            // 
            Proveedor.AutoSize = true;
            Proveedor.Font = new Font("Arial Rounded MT Bold", 12F);
            Proveedor.Location = new Point(109, 11);
            Proveedor.Name = "Proveedor";
            Proveedor.Size = new Size(78, 23);
            Proveedor.TabIndex = 2;
            Proveedor.Text = "Cliente";
            // 
            // V_MostrarDetallesVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 628);
            Controls.Add(panel1);
            Controls.Add(DGV_DetallesVentas);
            Controls.Add(panelSuperior);
            Name = "V_MostrarDetallesVenta";
            Text = "V_MostrarDetallesVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVentas).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
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
        private TextBox TB_Cliente;
    }
}