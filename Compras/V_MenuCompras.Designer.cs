namespace POS_CHITOS
{
    partial class V_MenuCompras
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
            DGV_Compras = new DataGridView();
            panelSuperior = new Panel();
            B_BuscarPorFecha = new Button();
            label2 = new Label();
            label1 = new Label();
            DTP_Hasta = new DateTimePicker();
            pictureBox1 = new PictureBox();
            DTP_Desde = new DateTimePicker();
            B_MostrarDetalles = new Button();
            B_ActualizarTabla = new Button();
            B_ModificarCompra = new Button();
            B_CancelarCompra = new Button();
            TB_BuscarCompra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Compras).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV_Compras
            // 
            DGV_Compras.AllowUserToAddRows = false;
            DGV_Compras.AllowUserToResizeColumns = false;
            DGV_Compras.AllowUserToResizeRows = false;
            DGV_Compras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Compras.Dock = DockStyle.Fill;
            DGV_Compras.Location = new Point(0, 128);
            DGV_Compras.MultiSelect = false;
            DGV_Compras.Name = "DGV_Compras";
            DGV_Compras.ReadOnly = true;
            DGV_Compras.RowHeadersVisible = false;
            DGV_Compras.RowHeadersWidth = 51;
            DGV_Compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Compras.Size = new Size(1633, 554);
            DGV_Compras.TabIndex = 4;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(B_BuscarPorFecha);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(DTP_Hasta);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(DTP_Desde);
            panelSuperior.Controls.Add(B_MostrarDetalles);
            panelSuperior.Controls.Add(B_ActualizarTabla);
            panelSuperior.Controls.Add(B_ModificarCompra);
            panelSuperior.Controls.Add(B_CancelarCompra);
            panelSuperior.Controls.Add(TB_BuscarCompra);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1633, 128);
            panelSuperior.TabIndex = 3;
            // 
            // B_BuscarPorFecha
            // 
            B_BuscarPorFecha.FlatAppearance.BorderSize = 0;
            B_BuscarPorFecha.FlatStyle = FlatStyle.Flat;
            B_BuscarPorFecha.Image = Properties.Resources.calendario;
            B_BuscarPorFecha.Location = new Point(1085, 39);
            B_BuscarPorFecha.Name = "B_BuscarPorFecha";
            B_BuscarPorFecha.Size = new Size(44, 48);
            B_BuscarPorFecha.TabIndex = 25;
            B_BuscarPorFecha.UseVisualStyleBackColor = true;
            B_BuscarPorFecha.Click += B_BuscarPorFecha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(883, 26);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 24;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(576, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 23;
            label1.Text = "Desde";
            // 
            // DTP_Hasta
            // 
            DTP_Hasta.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTP_Hasta.Location = new Point(771, 52);
            DTP_Hasta.Name = "DTP_Hasta";
            DTP_Hasta.Size = new Size(293, 27);
            DTP_Hasta.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.factura;
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // DTP_Desde
            // 
            DTP_Desde.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTP_Desde.Location = new Point(453, 52);
            DTP_Desde.Name = "DTP_Desde";
            DTP_Desde.Size = new Size(293, 27);
            DTP_Desde.TabIndex = 20;
            // 
            // B_MostrarDetalles
            // 
            B_MostrarDetalles.BackColor = SystemColors.ControlLightLight;
            B_MostrarDetalles.Cursor = Cursors.Hand;
            B_MostrarDetalles.Dock = DockStyle.Right;
            B_MostrarDetalles.FlatAppearance.BorderSize = 0;
            B_MostrarDetalles.FlatStyle = FlatStyle.Flat;
            B_MostrarDetalles.Font = new Font("Segoe UI", 10.2F);
            B_MostrarDetalles.ForeColor = Color.FromArgb(44, 140, 153);
            B_MostrarDetalles.Image = Properties.Resources.archivo__1_;
            B_MostrarDetalles.Location = new Point(1256, 0);
            B_MostrarDetalles.Name = "B_MostrarDetalles";
            B_MostrarDetalles.Size = new Size(89, 128);
            B_MostrarDetalles.TabIndex = 6;
            B_MostrarDetalles.Text = "Mostrar (Ctrl + D)";
            B_MostrarDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            B_MostrarDetalles.UseVisualStyleBackColor = false;
            B_MostrarDetalles.Click += B_MostrarDetalles_Click;
            // 
            // B_ActualizarTabla
            // 
            B_ActualizarTabla.BackColor = SystemColors.ControlLightLight;
            B_ActualizarTabla.Cursor = Cursors.Hand;
            B_ActualizarTabla.Dock = DockStyle.Right;
            B_ActualizarTabla.FlatAppearance.BorderSize = 0;
            B_ActualizarTabla.FlatStyle = FlatStyle.Flat;
            B_ActualizarTabla.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarTabla.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTabla.Image = Properties.Resources.recargar;
            B_ActualizarTabla.Location = new Point(1345, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(101, 128);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            B_ActualizarTabla.Click += B_ActualizarTabla_Click;
            // 
            // B_ModificarCompra
            // 
            B_ModificarCompra.BackColor = SystemColors.ControlLightLight;
            B_ModificarCompra.Cursor = Cursors.Hand;
            B_ModificarCompra.Dock = DockStyle.Right;
            B_ModificarCompra.FlatAppearance.BorderSize = 0;
            B_ModificarCompra.FlatStyle = FlatStyle.Flat;
            B_ModificarCompra.Font = new Font("Segoe UI", 10.2F);
            B_ModificarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCompra.Image = Properties.Resources.circulo;
            B_ModificarCompra.Location = new Point(1446, 0);
            B_ModificarCompra.Name = "B_ModificarCompra";
            B_ModificarCompra.Size = new Size(92, 128);
            B_ModificarCompra.TabIndex = 2;
            B_ModificarCompra.Text = "Modificar (Ctrl + M)";
            B_ModificarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCompra.UseVisualStyleBackColor = false;
            B_ModificarCompra.Click += B_ModificarCompra_Click;
            // 
            // B_CancelarCompra
            // 
            B_CancelarCompra.BackColor = SystemColors.ControlLightLight;
            B_CancelarCompra.Cursor = Cursors.Hand;
            B_CancelarCompra.Dock = DockStyle.Right;
            B_CancelarCompra.FlatAppearance.BorderSize = 0;
            B_CancelarCompra.FlatStyle = FlatStyle.Flat;
            B_CancelarCompra.Font = new Font("Segoe UI", 10.2F);
            B_CancelarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarCompra.Image = Properties.Resources.semaforo;
            B_CancelarCompra.Location = new Point(1538, 0);
            B_CancelarCompra.Name = "B_CancelarCompra";
            B_CancelarCompra.Size = new Size(95, 128);
            B_CancelarCompra.TabIndex = 1;
            B_CancelarCompra.Text = "Cambiar Estado (Ctrl + B)";
            B_CancelarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarCompra.UseVisualStyleBackColor = false;
            B_CancelarCompra.Click += B_CancelarCompra_Click;
            // 
            // TB_BuscarCompra
            // 
            TB_BuscarCompra.Font = new Font("Segoe UI", 12F);
            TB_BuscarCompra.Location = new Point(53, 43);
            TB_BuscarCompra.Name = "TB_BuscarCompra";
            TB_BuscarCompra.Size = new Size(341, 34);
            TB_BuscarCompra.TabIndex = 0;
            TB_BuscarCompra.TextChanged += TB_BuscarCompra_TextChanged;
            // 
            // V_MenuCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 682);
            Controls.Add(DGV_Compras);
            Controls.Add(panelSuperior);
            Name = "V_MenuCompras";
            Text = "V_MenuCompras";
            ((System.ComponentModel.ISupportInitialize)DGV_Compras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Compras;
        private Panel panelSuperior;
        private Button B_ActualizarTabla;
        private Button B_ModificarCompra;
        private Button B_CancelarCompra;
        private TextBox TB_BuscarCompra;
        private Button B_MostrarDetalles;
        private Button B_BuscarPorFecha;
        private Label label2;
        private Label label1;
        private DateTimePicker DTP_Hasta;
        private PictureBox pictureBox1;
        private DateTimePicker DTP_Desde;
    }
}