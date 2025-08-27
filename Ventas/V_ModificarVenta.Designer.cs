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
            B_CancelarVenta = new Button();
            B_AgregarVenta = new Button();
            TB_TotalVenta = new TextBox();
            label1 = new Label();
            DGV_DetallesVenta = new DataGridView();
            panelSuperior = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            B_Servicio = new Button();
            textBox1 = new TextBox();
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
            panel2.Controls.Add(B_CancelarVenta);
            panel2.Controls.Add(B_AgregarVenta);
            panel2.Controls.Add(TB_TotalVenta);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 619);
            panel2.Name = "panel2";
            panel2.Size = new Size(1556, 103);
            panel2.TabIndex = 18;
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
            B_CancelarVenta.Location = new Point(107, 0);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(107, 103);
            B_CancelarVenta.TabIndex = 5;
            B_CancelarVenta.Text = "Cancelar (Esc)";
            B_CancelarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarVenta.UseVisualStyleBackColor = false;
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
            B_AgregarVenta.Name = "B_AgregarVenta";
            B_AgregarVenta.Size = new Size(107, 103);
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
            TB_TotalVenta.Location = new Point(1206, 0);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.Size = new Size(350, 91);
            TB_TotalVenta.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1026, 6);
            label1.Name = "label1";
            label1.Size = new Size(174, 81);
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
            DGV_DetallesVenta.Location = new Point(0, 139);
            DGV_DetallesVenta.MultiSelect = false;
            DGV_DetallesVenta.Name = "DGV_DetallesVenta";
            DGV_DetallesVenta.ReadOnly = true;
            DGV_DetallesVenta.RowHeadersWidth = 51;
            DGV_DetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVenta.Size = new Size(1556, 583);
            DGV_DetallesVenta.TabIndex = 17;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Controls.Add(B_Servicio);
            panelSuperior.Controls.Add(textBox1);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1556, 139);
            panelSuperior.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.servicio_al_cliente;
            pictureBox2.Location = new Point(3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 37);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(3, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
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
            B_Servicio.Location = new Point(1252, 0);
            B_Servicio.Name = "B_Servicio";
            B_Servicio.Size = new Size(100, 139);
            B_Servicio.TabIndex = 11;
            B_Servicio.Text = "Producto Vario (Ctrl + P)";
            B_Servicio.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Servicio.UseVisualStyleBackColor = false;
            B_Servicio.Click += B_Servicio_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(44, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 34);
            textBox1.TabIndex = 10;
            textBox1.Text = "Publico en General";
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
            B_EliminarProducto.Location = new Point(1352, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(103, 139);
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
            dateTimePicker1.Location = new Point(3236, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(378, 58);
            button3.Name = "button3";
            button3.Size = new Size(85, 81);
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
            B_ModificarCantidad.Location = new Point(1455, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(101, 139);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad (Ctrl + C)";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Segoe UI", 12F);
            TB_Producto.Location = new Point(41, 79);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(347, 34);
            TB_Producto.TabIndex = 0;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // V_ModificarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1556, 722);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesVenta);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox textBox1;
        private Button B_EliminarProducto;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button B_ModificarCantidad;
        private TextBox TB_Producto;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}