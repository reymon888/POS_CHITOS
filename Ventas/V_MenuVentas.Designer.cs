namespace POS_CHITOS
{
    partial class V_MenuVentas
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
            DGV_Ventas = new DataGridView();
            panelBotonera = new Panel();
            B_BuscarPlaca = new Button();
            B_VentaEspera = new Button();
            B_Ticket = new Button();
            B_BuscarPorFecha = new Button();
            label2 = new Label();
            label1 = new Label();
            DTP_Hasta = new DateTimePicker();
            pictureBox1 = new PictureBox();
            DTP_Desde = new DateTimePicker();
            B_MostrarDetalles = new Button();
            B_ActualizarTabla = new Button();
            B_ModificarVenta = new Button();
            B_CancelarVenta = new Button();
            TB_BuscarVenta = new TextBox();
            panelHost = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).BeginInit();
            panelBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHost.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Ventas
            // 
            DGV_Ventas.AllowUserToAddRows = false;
            DGV_Ventas.AllowUserToResizeColumns = false;
            DGV_Ventas.AllowUserToResizeRows = false;
            DGV_Ventas.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Ventas.Dock = DockStyle.Fill;
            DGV_Ventas.Location = new Point(0, 0);
            DGV_Ventas.Margin = new Padding(3, 2, 3, 2);
            DGV_Ventas.MultiSelect = false;
            DGV_Ventas.Name = "DGV_Ventas";
            DGV_Ventas.ReadOnly = true;
            DGV_Ventas.RowHeadersVisible = false;
            DGV_Ventas.RowHeadersWidth = 51;
            DGV_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Ventas.Size = new Size(1408, 474);
            DGV_Ventas.TabIndex = 6;
            // 
            // panelBotonera
            // 
            panelBotonera.BackColor = SystemColors.ControlLightLight;
            panelBotonera.Controls.Add(B_BuscarPlaca);
            panelBotonera.Controls.Add(B_VentaEspera);
            panelBotonera.Controls.Add(B_Ticket);
            panelBotonera.Controls.Add(B_BuscarPorFecha);
            panelBotonera.Controls.Add(label2);
            panelBotonera.Controls.Add(label1);
            panelBotonera.Controls.Add(DTP_Hasta);
            panelBotonera.Controls.Add(pictureBox1);
            panelBotonera.Controls.Add(DTP_Desde);
            panelBotonera.Controls.Add(B_MostrarDetalles);
            panelBotonera.Controls.Add(B_ActualizarTabla);
            panelBotonera.Controls.Add(B_ModificarVenta);
            panelBotonera.Controls.Add(B_CancelarVenta);
            panelBotonera.Controls.Add(TB_BuscarVenta);
            panelBotonera.Dock = DockStyle.Top;
            panelBotonera.Location = new Point(0, 0);
            panelBotonera.Margin = new Padding(3, 2, 3, 2);
            panelBotonera.Name = "panelBotonera";
            panelBotonera.Size = new Size(1408, 92);
            panelBotonera.TabIndex = 5;
            // 
            // B_BuscarPlaca
            // 
            B_BuscarPlaca.BackColor = SystemColors.ControlLightLight;
            B_BuscarPlaca.Cursor = Cursors.Hand;
            B_BuscarPlaca.Dock = DockStyle.Right;
            B_BuscarPlaca.FlatAppearance.BorderSize = 0;
            B_BuscarPlaca.FlatStyle = FlatStyle.Flat;
            B_BuscarPlaca.Font = new Font("Segoe UI", 10.2F);
            B_BuscarPlaca.ForeColor = Color.FromArgb(44, 140, 153);
            B_BuscarPlaca.Image = Properties.Resources.placa__1_;
            B_BuscarPlaca.Location = new Point(850, 0);
            B_BuscarPlaca.Margin = new Padding(3, 2, 3, 2);
            B_BuscarPlaca.Name = "B_BuscarPlaca";
            B_BuscarPlaca.Size = new Size(76, 92);
            B_BuscarPlaca.TabIndex = 22;
            B_BuscarPlaca.Text = "Buscar por Placa";
            B_BuscarPlaca.TextImageRelation = TextImageRelation.ImageAboveText;
            B_BuscarPlaca.UseVisualStyleBackColor = false;
            B_BuscarPlaca.Click += B_BuscarPlaca_Click;
            // 
            // B_VentaEspera
            // 
            B_VentaEspera.BackColor = SystemColors.ControlLightLight;
            B_VentaEspera.Cursor = Cursors.Hand;
            B_VentaEspera.Dock = DockStyle.Right;
            B_VentaEspera.FlatAppearance.BorderSize = 0;
            B_VentaEspera.FlatStyle = FlatStyle.Flat;
            B_VentaEspera.Font = new Font("Segoe UI", 10.2F);
            B_VentaEspera.ForeColor = Color.FromArgb(44, 140, 153);
            B_VentaEspera.Image = Properties.Resources.pendiente;
            B_VentaEspera.Location = new Point(926, 0);
            B_VentaEspera.Margin = new Padding(3, 2, 3, 2);
            B_VentaEspera.Name = "B_VentaEspera";
            B_VentaEspera.Size = new Size(76, 92);
            B_VentaEspera.TabIndex = 21;
            B_VentaEspera.Text = "Ventas Espera";
            B_VentaEspera.TextImageRelation = TextImageRelation.ImageAboveText;
            B_VentaEspera.UseVisualStyleBackColor = false;
            B_VentaEspera.Click += B_VentaEspera_Click;
            // 
            // B_Ticket
            // 
            B_Ticket.BackColor = SystemColors.ControlLightLight;
            B_Ticket.Cursor = Cursors.Hand;
            B_Ticket.Dock = DockStyle.Right;
            B_Ticket.FlatAppearance.BorderSize = 0;
            B_Ticket.FlatStyle = FlatStyle.Flat;
            B_Ticket.Font = new Font("Segoe UI", 10.2F);
            B_Ticket.ForeColor = Color.FromArgb(44, 140, 153);
            B_Ticket.Image = Properties.Resources.factura;
            B_Ticket.Location = new Point(1002, 0);
            B_Ticket.Margin = new Padding(3, 2, 3, 2);
            B_Ticket.Name = "B_Ticket";
            B_Ticket.Size = new Size(76, 92);
            B_Ticket.TabIndex = 20;
            B_Ticket.Text = "Ticket (Ctrl + K)";
            B_Ticket.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Ticket.UseVisualStyleBackColor = false;
            B_Ticket.Click += B_Ticket_Click;
            // 
            // B_BuscarPorFecha
            // 
            B_BuscarPorFecha.FlatAppearance.BorderSize = 0;
            B_BuscarPorFecha.FlatStyle = FlatStyle.Flat;
            B_BuscarPorFecha.Image = Properties.Resources.calendario;
            B_BuscarPorFecha.Location = new Point(799, 17);
            B_BuscarPorFecha.Margin = new Padding(3, 2, 3, 2);
            B_BuscarPorFecha.Name = "B_BuscarPorFecha";
            B_BuscarPorFecha.Size = new Size(38, 36);
            B_BuscarPorFecha.TabIndex = 19;
            B_BuscarPorFecha.UseVisualStyleBackColor = true;
            B_BuscarPorFecha.Click += B_BuscarPorFecha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(626, 2);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 18;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(374, 2);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 17;
            label1.Text = "Desde";
            // 
            // DTP_Hasta
            // 
            DTP_Hasta.Font = new Font("Segoe UI", 10.8F);
            DTP_Hasta.Location = new Point(529, 20);
            DTP_Hasta.Margin = new Padding(3, 2, 3, 2);
            DTP_Hasta.Name = "DTP_Hasta";
            DTP_Hasta.Size = new Size(264, 27);
            DTP_Hasta.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.factura;
            pictureBox1.Location = new Point(10, 18);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 28);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // DTP_Desde
            // 
            DTP_Desde.Font = new Font("Segoe UI", 10.8F);
            DTP_Desde.Location = new Point(256, 20);
            DTP_Desde.Margin = new Padding(3, 2, 3, 2);
            DTP_Desde.Name = "DTP_Desde";
            DTP_Desde.Size = new Size(267, 27);
            DTP_Desde.TabIndex = 7;
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
            B_MostrarDetalles.Location = new Point(1078, 0);
            B_MostrarDetalles.Margin = new Padding(3, 2, 3, 2);
            B_MostrarDetalles.Name = "B_MostrarDetalles";
            B_MostrarDetalles.Size = new Size(79, 92);
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
            B_ActualizarTabla.Location = new Point(1157, 0);
            B_ActualizarTabla.Margin = new Padding(3, 2, 3, 2);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(88, 92);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            B_ActualizarTabla.Click += B_ActualizarTabla_Click;
            // 
            // B_ModificarVenta
            // 
            B_ModificarVenta.BackColor = SystemColors.ControlLightLight;
            B_ModificarVenta.Cursor = Cursors.Hand;
            B_ModificarVenta.Dock = DockStyle.Right;
            B_ModificarVenta.FlatAppearance.BorderSize = 0;
            B_ModificarVenta.FlatStyle = FlatStyle.Flat;
            B_ModificarVenta.Font = new Font("Segoe UI", 10.2F);
            B_ModificarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarVenta.Image = Properties.Resources.circulo;
            B_ModificarVenta.Location = new Point(1245, 0);
            B_ModificarVenta.Margin = new Padding(3, 2, 3, 2);
            B_ModificarVenta.Name = "B_ModificarVenta";
            B_ModificarVenta.Size = new Size(80, 92);
            B_ModificarVenta.TabIndex = 2;
            B_ModificarVenta.Text = "Modificar (Ctrl + M)";
            B_ModificarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarVenta.UseVisualStyleBackColor = false;
            B_ModificarVenta.Click += B_ModificarVenta_Click;
            // 
            // B_CancelarVenta
            // 
            B_CancelarVenta.BackColor = SystemColors.ControlLightLight;
            B_CancelarVenta.Cursor = Cursors.Hand;
            B_CancelarVenta.Dock = DockStyle.Right;
            B_CancelarVenta.FlatAppearance.BorderSize = 0;
            B_CancelarVenta.FlatStyle = FlatStyle.Flat;
            B_CancelarVenta.Font = new Font("Segoe UI", 10.2F);
            B_CancelarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarVenta.Image = Properties.Resources.semaforo;
            B_CancelarVenta.Location = new Point(1325, 0);
            B_CancelarVenta.Margin = new Padding(3, 2, 3, 2);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(83, 92);
            B_CancelarVenta.TabIndex = 1;
            B_CancelarVenta.Text = "Cambiar Estado (Ctrl + B)";
            B_CancelarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarVenta.UseVisualStyleBackColor = false;
            B_CancelarVenta.Click += B_CancelarVenta_Click;
            // 
            // TB_BuscarVenta
            // 
            TB_BuscarVenta.Font = new Font("Segoe UI", 12F);
            TB_BuscarVenta.Location = new Point(46, 20);
            TB_BuscarVenta.Margin = new Padding(3, 2, 3, 2);
            TB_BuscarVenta.Name = "TB_BuscarVenta";
            TB_BuscarVenta.Size = new Size(181, 29);
            TB_BuscarVenta.TabIndex = 0;
            TB_BuscarVenta.TextChanged += TB_BuscarVenta_TextChanged;
            // 
            // panelHost
            // 
            panelHost.BackColor = SystemColors.ButtonHighlight;
            panelHost.Controls.Add(DGV_Ventas);
            panelHost.Dock = DockStyle.Fill;
            panelHost.Location = new Point(0, 92);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(1408, 474);
            panelHost.TabIndex = 7;
            // 
            // V_MenuVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 566);
            Controls.Add(panelHost);
            Controls.Add(panelBotonera);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_MenuVentas";
            Text = "V_MenuVentas";
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).EndInit();
            panelBotonera.ResumeLayout(false);
            panelBotonera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHost.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Ventas;
        private Panel panelBotonera;
        private DateTimePicker DTP_Desde;
        private Button B_MostrarDetalles;
        private Button B_ActualizarTabla;
        private Button B_ModificarVenta;
        private Button B_CancelarVenta;
        private TextBox TB_BuscarVenta;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker DTP_Hasta;
        private Button B_BuscarPorFecha;
        private Button B_Ticket;
        private Panel panelHost;
        private Button B_VentaEspera;
        private Button B_BuscarPlaca;
    }
}