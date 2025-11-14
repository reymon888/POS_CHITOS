namespace POS_CHITOS
{
    partial class V_ModificarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ModificarVenta));
            panel2 = new Panel();
            B_EnEspera = new Button();
            B_CancelarVenta = new Button();
            B_AgregarVenta = new Button();
            TB_TotalVenta = new TextBox();
            label1 = new Label();
            DGV_DetallesVenta = new DataGridView();
            panelSuperior = new Panel();
            pictureBox2 = new PictureBox();
            TB_Placa = new TextBox();
            pictureBox1 = new PictureBox();
            B_Servicio = new Button();
            B_EliminarProducto = new Button();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            B_ModificarCantidad = new Button();
            TB_Producto = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVenta).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(B_EnEspera);
            panel2.Controls.Add(B_CancelarVenta);
            panel2.Controls.Add(B_AgregarVenta);
            panel2.Controls.Add(TB_TotalVenta);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 465);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1362, 77);
            panel2.TabIndex = 18;
            // 
            // B_EnEspera
            // 
            B_EnEspera.BackColor = SystemColors.ControlLightLight;
            B_EnEspera.Cursor = Cursors.Hand;
            B_EnEspera.Dock = DockStyle.Left;
            B_EnEspera.FlatAppearance.BorderSize = 0;
            B_EnEspera.FlatStyle = FlatStyle.Flat;
            B_EnEspera.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            B_EnEspera.ForeColor = Color.FromArgb(44, 140, 153);
            B_EnEspera.Image = Properties.Resources.esperando;
            B_EnEspera.Location = new Point(188, 0);
            B_EnEspera.Margin = new Padding(3, 2, 3, 2);
            B_EnEspera.Name = "B_EnEspera";
            B_EnEspera.Size = new Size(83, 77);
            B_EnEspera.TabIndex = 8;
            B_EnEspera.Text = "En Espera";
            B_EnEspera.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EnEspera.UseVisualStyleBackColor = false;
            B_EnEspera.Click += B_EnEspera_Click;
            // 
            // B_CancelarVenta
            // 
            B_CancelarVenta.BackColor = SystemColors.ControlLightLight;
            B_CancelarVenta.Cursor = Cursors.Hand;
            B_CancelarVenta.Dock = DockStyle.Left;
            B_CancelarVenta.FlatAppearance.BorderSize = 0;
            B_CancelarVenta.FlatStyle = FlatStyle.Flat;
            B_CancelarVenta.Font = new Font("Segoe UI", 12F);
            B_CancelarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarVenta.Image = Properties.Resources.rechazar__1_;
            B_CancelarVenta.Location = new Point(94, 0);
            B_CancelarVenta.Margin = new Padding(3, 2, 3, 2);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(94, 77);
            B_CancelarVenta.TabIndex = 5;
            B_CancelarVenta.Text = "Cancelar (Esc)";
            B_CancelarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarVenta.UseVisualStyleBackColor = false;
            B_CancelarVenta.Click += B_CancelarVenta_Click;
            // 
            // B_AgregarVenta
            // 
            B_AgregarVenta.BackColor = SystemColors.ControlLightLight;
            B_AgregarVenta.Cursor = Cursors.Hand;
            B_AgregarVenta.Dock = DockStyle.Left;
            B_AgregarVenta.FlatAppearance.BorderSize = 0;
            B_AgregarVenta.FlatStyle = FlatStyle.Flat;
            B_AgregarVenta.Font = new Font("Segoe UI", 12F);
            B_AgregarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarVenta.Image = Properties.Resources.aceptar__1_;
            B_AgregarVenta.Location = new Point(0, 0);
            B_AgregarVenta.Margin = new Padding(3, 2, 3, 2);
            B_AgregarVenta.Name = "B_AgregarVenta";
            B_AgregarVenta.Size = new Size(94, 77);
            B_AgregarVenta.TabIndex = 4;
            B_AgregarVenta.Text = "Confirmar (Ctrl + N)";
            B_AgregarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarVenta.UseVisualStyleBackColor = false;
            B_AgregarVenta.Click += B_AgregarVenta_Click;
            // 
            // TB_TotalVenta
            // 
            TB_TotalVenta.Dock = DockStyle.Right;
            TB_TotalVenta.Font = new Font("Arial Rounded MT Bold", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalVenta.Location = new Point(1055, 0);
            TB_TotalVenta.Margin = new Padding(3, 2, 3, 2);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.Size = new Size(307, 74);
            TB_TotalVenta.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(898, 4);
            label1.Name = "label1";
            label1.Size = new Size(138, 65);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // DGV_DetallesVenta
            // 
            DGV_DetallesVenta.AllowUserToAddRows = false;
            DGV_DetallesVenta.AllowUserToResizeColumns = false;
            DGV_DetallesVenta.AllowUserToResizeRows = false;
            DGV_DetallesVenta.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesVenta.Dock = DockStyle.Fill;
            DGV_DetallesVenta.Location = new Point(0, 104);
            DGV_DetallesVenta.Margin = new Padding(3, 2, 3, 2);
            DGV_DetallesVenta.MultiSelect = false;
            DGV_DetallesVenta.Name = "DGV_DetallesVenta";
            DGV_DetallesVenta.ReadOnly = true;
            DGV_DetallesVenta.RowHeadersWidth = 51;
            DGV_DetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVenta.Size = new Size(1362, 438);
            DGV_DetallesVenta.TabIndex = 17;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(TB_Placa);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(B_Servicio);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 2, 3, 2);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1362, 104);
            panelSuperior.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.placa;
            pictureBox2.Location = new Point(0, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 28);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // TB_Placa
            // 
            TB_Placa.Font = new Font("Segoe UI", 12F);
            TB_Placa.Location = new Point(36, 11);
            TB_Placa.Margin = new Padding(3, 2, 3, 2);
            TB_Placa.Name = "TB_Placa";
            TB_Placa.PlaceholderText = "Ingresa la placa";
            TB_Placa.Size = new Size(199, 29);
            TB_Placa.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(3, 59);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 28);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // B_Servicio
            // 
            B_Servicio.BackColor = SystemColors.ControlLightLight;
            B_Servicio.Cursor = Cursors.Hand;
            B_Servicio.Dock = DockStyle.Right;
            B_Servicio.FlatAppearance.BorderSize = 0;
            B_Servicio.FlatStyle = FlatStyle.Flat;
            B_Servicio.Font = new Font("Segoe UI", 12F);
            B_Servicio.ForeColor = Color.FromArgb(44, 140, 153);
            B_Servicio.Image = Properties.Resources.herramientas;
            B_Servicio.Location = new Point(1096, 0);
            B_Servicio.Margin = new Padding(3, 2, 3, 2);
            B_Servicio.Name = "B_Servicio";
            B_Servicio.Size = new Size(88, 104);
            B_Servicio.TabIndex = 11;
            B_Servicio.Text = "Producto Vario (Ctrl + P)";
            B_Servicio.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Servicio.UseVisualStyleBackColor = false;
            B_Servicio.Click += B_Servicio_Click;
            // 
            // B_EliminarProducto
            // 
            B_EliminarProducto.BackColor = SystemColors.ControlLightLight;
            B_EliminarProducto.Cursor = Cursors.Hand;
            B_EliminarProducto.Dock = DockStyle.Right;
            B_EliminarProducto.FlatAppearance.BorderSize = 0;
            B_EliminarProducto.FlatStyle = FlatStyle.Flat;
            B_EliminarProducto.Font = new Font("Segoe UI", 12F);
            B_EliminarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_EliminarProducto.Image = Properties.Resources.boton_x;
            B_EliminarProducto.Location = new Point(1184, 0);
            B_EliminarProducto.Margin = new Padding(3, 2, 3, 2);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(90, 104);
            B_EliminarProducto.TabIndex = 9;
            B_EliminarProducto.Text = "Eliminar Producto (Ctrl + E)";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(2832, 49);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 24);
            dateTimePicker1.TabIndex = 7;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(331, 44);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(74, 61);
            button3.TabIndex = 4;
            button3.Text = "(Ctrl + S)";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // B_ModificarCantidad
            // 
            B_ModificarCantidad.BackColor = SystemColors.ControlLightLight;
            B_ModificarCantidad.Cursor = Cursors.Hand;
            B_ModificarCantidad.Dock = DockStyle.Right;
            B_ModificarCantidad.FlatAppearance.BorderSize = 0;
            B_ModificarCantidad.FlatStyle = FlatStyle.Flat;
            B_ModificarCantidad.Font = new Font("Segoe UI", 12F);
            B_ModificarCantidad.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCantidad.Image = Properties.Resources.cajas;
            B_ModificarCantidad.Location = new Point(1274, 0);
            B_ModificarCantidad.Margin = new Padding(3, 2, 3, 2);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(88, 104);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad (Ctrl + C)";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Segoe UI", 12F);
            TB_Producto.Location = new Point(36, 59);
            TB_Producto.Margin = new Padding(3, 2, 3, 2);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(304, 29);
            TB_Producto.TabIndex = 0;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // V_ModificarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 542);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesVenta);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_ModificarVenta";
            Text = "Modificar Venta";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVenta).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_CancelarVenta;
        private Button B_AgregarVenta;
        private TextBox TB_TotalVenta;
        private Label label1;
        private DataGridView DGV_DetallesVenta;
        private Panel panelSuperior;
        private Button B_Servicio;
        private Button B_EliminarProducto;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button B_ModificarCantidad;
        private TextBox TB_Producto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TB_Placa;
        private Button B_EnEspera;
    }
}