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
            panel2 = new Panel();
            B_CancelarVenta = new Button();
            B_AgregarVenta = new Button();
            TB_TotalVenta = new TextBox();
            label1 = new Label();
            DGV_DetallesVenta = new DataGridView();
            panelSuperior = new Panel();
            B_Servicio = new Button();
            textBox1 = new TextBox();
            B_EliminarProducto = new Button();
            dateTimePicker1 = new DateTimePicker();
            B_AgregarNuevoProducto = new Button();
            button3 = new Button();
            B_ModificarCantidad = new Button();
            TB_Producto = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVenta).BeginInit();
            panelSuperior.SuspendLayout();
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
            panel2.Location = new Point(0, 519);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 88);
            panel2.TabIndex = 18;
            // 
            // B_CancelarVenta
            // 
            B_CancelarVenta.BackColor = SystemColors.ControlLightLight;
            B_CancelarVenta.Cursor = Cursors.Hand;
            B_CancelarVenta.Dock = DockStyle.Left;
            B_CancelarVenta.FlatAppearance.BorderSize = 0;
            B_CancelarVenta.FlatStyle = FlatStyle.Flat;
            B_CancelarVenta.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CancelarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarVenta.Image = Properties.Resources.rechazar__1_;
            B_CancelarVenta.Location = new Point(107, 0);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(107, 88);
            B_CancelarVenta.TabIndex = 5;
            B_CancelarVenta.Text = "Cancelar";
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
            B_AgregarVenta.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarVenta.Image = Properties.Resources.aceptar__1_;
            B_AgregarVenta.Location = new Point(0, 0);
            B_AgregarVenta.Name = "B_AgregarVenta";
            B_AgregarVenta.Size = new Size(107, 88);
            B_AgregarVenta.TabIndex = 4;
            B_AgregarVenta.Text = "Confirmar";
            B_AgregarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarVenta.UseVisualStyleBackColor = false;
            B_AgregarVenta.Click += B_AgregarVenta_Click;
            // 
            // TB_TotalVenta
            // 
            TB_TotalVenta.Dock = DockStyle.Right;
            TB_TotalVenta.Font = new Font("Arial Rounded MT Bold", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalVenta.Location = new Point(1088, 0);
            TB_TotalVenta.Name = "TB_TotalVenta";
            TB_TotalVenta.Size = new Size(350, 91);
            TB_TotalVenta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(863, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 39);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // DGV_DetallesVenta
            // 
            DGV_DetallesVenta.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesVenta.Dock = DockStyle.Fill;
            DGV_DetallesVenta.Location = new Point(0, 139);
            DGV_DetallesVenta.MultiSelect = false;
            DGV_DetallesVenta.Name = "DGV_DetallesVenta";
            DGV_DetallesVenta.ReadOnly = true;
            DGV_DetallesVenta.RowHeadersWidth = 51;
            DGV_DetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesVenta.Size = new Size(1438, 468);
            DGV_DetallesVenta.TabIndex = 17;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(B_Servicio);
            panelSuperior.Controls.Add(textBox1);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(B_AgregarNuevoProducto);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1438, 139);
            panelSuperior.TabIndex = 16;
            // 
            // B_Servicio
            // 
            B_Servicio.BackColor = SystemColors.ControlLightLight;
            B_Servicio.Cursor = Cursors.Hand;
            B_Servicio.Dock = DockStyle.Right;
            B_Servicio.FlatAppearance.BorderSize = 0;
            B_Servicio.FlatStyle = FlatStyle.Flat;
            B_Servicio.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Servicio.ForeColor = Color.FromArgb(44, 140, 153);
            B_Servicio.Image = Properties.Resources.boton_x;
            B_Servicio.Location = new Point(1117, 0);
            B_Servicio.Name = "B_Servicio";
            B_Servicio.Size = new Size(107, 139);
            B_Servicio.TabIndex = 11;
            B_Servicio.Text = "Agregar Servicio";
            B_Servicio.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Servicio.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(25, 12);
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
            B_EliminarProducto.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_EliminarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_EliminarProducto.Image = Properties.Resources.boton_x;
            B_EliminarProducto.Location = new Point(1224, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(107, 139);
            B_EliminarProducto.TabIndex = 9;
            B_EliminarProducto.Text = "Eliminar Producto";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(3118, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // B_AgregarNuevoProducto
            // 
            B_AgregarNuevoProducto.BackColor = SystemColors.ControlLightLight;
            B_AgregarNuevoProducto.Cursor = Cursors.Hand;
            B_AgregarNuevoProducto.FlatAppearance.BorderSize = 0;
            B_AgregarNuevoProducto.FlatStyle = FlatStyle.Flat;
            B_AgregarNuevoProducto.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarNuevoProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarNuevoProducto.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarNuevoProducto.Location = new Point(422, 8);
            B_AgregarNuevoProducto.Name = "B_AgregarNuevoProducto";
            B_AgregarNuevoProducto.Size = new Size(38, 38);
            B_AgregarNuevoProducto.TabIndex = 6;
            B_AgregarNuevoProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(378, 5);
            button3.Name = "button3";
            button3.Size = new Size(38, 41);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_ModificarCantidad
            // 
            B_ModificarCantidad.BackColor = SystemColors.ControlLightLight;
            B_ModificarCantidad.Cursor = Cursors.Hand;
            B_ModificarCantidad.Dock = DockStyle.Right;
            B_ModificarCantidad.FlatAppearance.BorderSize = 0;
            B_ModificarCantidad.FlatStyle = FlatStyle.Flat;
            B_ModificarCantidad.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ModificarCantidad.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCantidad.Image = Properties.Resources.cajas;
            B_ModificarCantidad.Location = new Point(1331, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(107, 139);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Producto.Location = new Point(25, 79);
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
            ClientSize = new Size(1438, 607);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesVenta);
            Controls.Add(panelSuperior);
            Name = "V_ModificarVenta";
            Text = "V_ModificarVenta";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesVenta).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
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
        private Button B_AgregarNuevoProducto;
        private Button button3;
        private Button B_ModificarCantidad;
        private TextBox TB_Producto;
    }
}