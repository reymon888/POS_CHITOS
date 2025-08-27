namespace POS_CHITOS
{
    partial class V_CreateVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_CreateVenta));
            panel2 = new Panel();
            label1 = new Label();
            B_CancelarVenta = new Button();
            B_AgregarVenta = new Button();
            TB_TotalVenta = new TextBox();
            DGV_DetallesVenta = new DataGridView();
            panelSuperior = new Panel();
            B_AgregarProductoVario = new Button();
            check_ticket = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            B_EliminarProducto = new Button();
            dateTimePicker1 = new DateTimePicker();
            B_BuscarProducto = new Button();
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
            panel2.Controls.Add(label1);
            panel2.Controls.Add(B_CancelarVenta);
            panel2.Controls.Add(B_AgregarVenta);
            panel2.Controls.Add(TB_TotalVenta);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(1579, 100);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(953, 10);
            label1.Name = "label1";
            label1.Size = new Size(174, 81);
            label1.TabIndex = 6;
            label1.Text = "Total:";
            // 
            // B_CancelarVenta
            // 
            B_CancelarVenta.BackColor = SystemColors.ControlLightLight;
            B_CancelarVenta.Cursor = Cursors.Hand;
            B_CancelarVenta.Dock = DockStyle.Left;
            B_CancelarVenta.FlatAppearance.BorderSize = 0;
            B_CancelarVenta.FlatStyle = FlatStyle.Flat;
            B_CancelarVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            B_CancelarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarVenta.Image = Properties.Resources.rechazar__1_;
            B_CancelarVenta.Location = new Point(95, 0);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(95, 100);
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
            B_AgregarVenta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            B_AgregarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarVenta.Image = Properties.Resources.aceptar__1_;
            B_AgregarVenta.Location = new Point(0, 0);
            B_AgregarVenta.Name = "B_AgregarVenta";
            B_AgregarVenta.Size = new Size(95, 100);
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
            TB_TotalVenta.Location = new Point(1142, 0);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.Size = new Size(437, 91);
            TB_TotalVenta.TabIndex = 1;
            // 
            // DGV_DetallesVenta
            // 
            DGV_DetallesVenta.AllowUserToAddRows = false;
            DGV_DetallesVenta.AllowUserToResizeColumns = false;
            DGV_DetallesVenta.AllowUserToResizeRows = false;
            DGV_DetallesVenta.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesVenta.Dock = DockStyle.Fill;
            DGV_DetallesVenta.Location = new Point(0, 134);
            DGV_DetallesVenta.MultiSelect = false;
            DGV_DetallesVenta.Name = "DGV_DetallesVenta";
            DGV_DetallesVenta.ReadOnly = true;
            DGV_DetallesVenta.RowHeadersWidth = 51;
            DGV_DetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVenta.Size = new Size(1579, 527);
            DGV_DetallesVenta.TabIndex = 14;
            DGV_DetallesVenta.CellDoubleClick += DGV_DetallesVenta_CellDoubleClick;
            DGV_DetallesVenta.SelectionChanged += DGV_DetallesVenta_SelectionChanged;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.WhiteSmoke;
            panelSuperior.Controls.Add(B_AgregarProductoVario);
            panelSuperior.Controls.Add(check_ticket);
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(textBox1);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(B_BuscarProducto);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1579, 134);
            panelSuperior.TabIndex = 13;
            // 
            // B_AgregarProductoVario
            // 
            B_AgregarProductoVario.BackColor = Color.WhiteSmoke;
            B_AgregarProductoVario.Cursor = Cursors.Hand;
            B_AgregarProductoVario.Dock = DockStyle.Right;
            B_AgregarProductoVario.FlatAppearance.BorderSize = 0;
            B_AgregarProductoVario.FlatStyle = FlatStyle.Flat;
            B_AgregarProductoVario.Font = new Font("Segoe UI", 10.2F);
            B_AgregarProductoVario.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarProductoVario.Image = Properties.Resources.herramientas;
            B_AgregarProductoVario.Location = new Point(1302, 0);
            B_AgregarProductoVario.Name = "B_AgregarProductoVario";
            B_AgregarProductoVario.Size = new Size(87, 134);
            B_AgregarProductoVario.TabIndex = 32;
            B_AgregarProductoVario.Text = "Producto Vario (Ctrl + P)";
            B_AgregarProductoVario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProductoVario.UseVisualStyleBackColor = false;
            B_AgregarProductoVario.Click += B_AgregarProductoVario_Click;
            // 
            // check_ticket
            // 
            check_ticket.AutoSize = true;
            check_ticket.Font = new Font("Segoe UI", 12F);
            check_ticket.Image = Properties.Resources.factura;
            check_ticket.Location = new Point(301, 14);
            check_ticket.Name = "check_ticket";
            check_ticket.Size = new Size(275, 32);
            check_ticket.TabIndex = 0;
            check_ticket.Text = "Generar Ticket (Ctrl + K)";
            check_ticket.TextAlign = ContentAlignment.MiddleRight;
            check_ticket.TextImageRelation = TextImageRelation.ImageBeforeText;
            check_ticket.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.servicio_al_cliente;
            pictureBox2.Location = new Point(11, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 37);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(11, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(53, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(227, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Publico en General";
            // 
            // B_EliminarProducto
            // 
            B_EliminarProducto.BackColor = Color.WhiteSmoke;
            B_EliminarProducto.Cursor = Cursors.Hand;
            B_EliminarProducto.Dock = DockStyle.Right;
            B_EliminarProducto.FlatAppearance.BorderSize = 0;
            B_EliminarProducto.FlatStyle = FlatStyle.Flat;
            B_EliminarProducto.Font = new Font("Segoe UI", 10.2F);
            B_EliminarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_EliminarProducto.Image = Properties.Resources.boton_x;
            B_EliminarProducto.Location = new Point(1389, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(95, 134);
            B_EliminarProducto.TabIndex = 0;
            B_EliminarProducto.Text = "Eliminar Producto (Ctrl + E)";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(2079, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // B_BuscarProducto
            // 
            B_BuscarProducto.FlatAppearance.BorderSize = 0;
            B_BuscarProducto.FlatStyle = FlatStyle.Flat;
            B_BuscarProducto.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_BuscarProducto.Image = Properties.Resources.buscar;
            B_BuscarProducto.Location = new Point(612, 51);
            B_BuscarProducto.Name = "B_BuscarProducto";
            B_BuscarProducto.Size = new Size(83, 57);
            B_BuscarProducto.TabIndex = 4;
            B_BuscarProducto.Text = "(Ctrl + S)";
            B_BuscarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_BuscarProducto.UseVisualStyleBackColor = true;
            B_BuscarProducto.Click += B_BuscarProducto_Click;
            // 
            // B_ModificarCantidad
            // 
            B_ModificarCantidad.BackColor = Color.WhiteSmoke;
            B_ModificarCantidad.Cursor = Cursors.Hand;
            B_ModificarCantidad.Dock = DockStyle.Right;
            B_ModificarCantidad.FlatAppearance.BorderSize = 0;
            B_ModificarCantidad.FlatStyle = FlatStyle.Flat;
            B_ModificarCantidad.Font = new Font("Segoe UI", 10.2F);
            B_ModificarCantidad.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCantidad.Image = Properties.Resources.cajas;
            B_ModificarCantidad.Location = new Point(1484, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(95, 134);
            B_ModificarCantidad.TabIndex = 0;
            B_ModificarCantidad.Text = "Cantidad (Ctrl + C)";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Segoe UI", 12F);
            TB_Producto.Location = new Point(53, 59);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(553, 34);
            TB_Producto.TabIndex = 1;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // V_CreateVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 661);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesVenta);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_CreateVenta";
            Text = "Registrar Venta";
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
        private DataGridView DGV_DetallesVenta;
        private Panel panelSuperior;
        private Button B_EliminarProducto;
        private DateTimePicker dateTimePicker1;
        private Button B_BuscarProducto;
        private Button B_ModificarCantidad;
        private TextBox TB_Producto;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox check_ticket;
        private Button B_AgregarProductoVario;
        private Label label1;
    }
}