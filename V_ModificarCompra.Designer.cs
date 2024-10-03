namespace POS_CHITOS
{
    partial class V_ModificarCompra
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
            DGV_DetallesCompras = new DataGridView();
            panelSuperior = new Panel();
            TB_FolioCompra = new TextBox();
            B_EliminarProducto = new Button();
            TB_Proveedor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            B_AgregarNuevoProducto = new Button();
            button3 = new Button();
            B_AgregarCompra = new Button();
            B_ModificarCantidad = new Button();
            B_CancelarCompra = new Button();
            TB_Producto = new TextBox();
            TB_TotalCompra = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).BeginInit();
            panelSuperior.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_DetallesCompras
            // 
            DGV_DetallesCompras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesCompras.Dock = DockStyle.Fill;
            DGV_DetallesCompras.Location = new Point(0, 113);
            DGV_DetallesCompras.MultiSelect = false;
            DGV_DetallesCompras.Name = "DGV_DetallesCompras";
            DGV_DetallesCompras.ReadOnly = true;
            DGV_DetallesCompras.RowHeadersWidth = 51;
            DGV_DetallesCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesCompras.Size = new Size(1328, 459);
            DGV_DetallesCompras.TabIndex = 8;
            DGV_DetallesCompras.CellDoubleClick += DGV_DetallesCompras_CellDoubleClick;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(TB_FolioCompra);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(TB_Proveedor);
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(B_AgregarNuevoProducto);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_AgregarCompra);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(B_CancelarCompra);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1328, 113);
            panelSuperior.TabIndex = 7;
            panelSuperior.Paint += panelSuperior_Paint;
            // 
            // TB_FolioCompra
            // 
            TB_FolioCompra.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_FolioCompra.Location = new Point(435, 12);
            TB_FolioCompra.Name = "TB_FolioCompra";
            TB_FolioCompra.PlaceholderText = "FolioCompraOriginal";
            TB_FolioCompra.Size = new Size(347, 34);
            TB_FolioCompra.TabIndex = 10;
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
            B_EliminarProducto.Location = new Point(793, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(107, 113);
            B_EliminarProducto.TabIndex = 9;
            B_EliminarProducto.Text = "Eliminar Producto";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // TB_Proveedor
            // 
            TB_Proveedor.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Proveedor.Location = new Point(25, 12);
            TB_Proveedor.Name = "TB_Proveedor";
            TB_Proveedor.PlaceholderText = "Proveedor";
            TB_Proveedor.Size = new Size(347, 34);
            TB_Proveedor.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(452, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // B_AgregarNuevoProducto
            // 
            B_AgregarNuevoProducto.BackColor = SystemColors.ControlLightLight;
            B_AgregarNuevoProducto.Cursor = Cursors.Hand;
            B_AgregarNuevoProducto.Dock = DockStyle.Right;
            B_AgregarNuevoProducto.FlatAppearance.BorderSize = 0;
            B_AgregarNuevoProducto.FlatStyle = FlatStyle.Flat;
            B_AgregarNuevoProducto.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarNuevoProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarNuevoProducto.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarNuevoProducto.Location = new Point(900, 0);
            B_AgregarNuevoProducto.Name = "B_AgregarNuevoProducto";
            B_AgregarNuevoProducto.Size = new Size(107, 113);
            B_AgregarNuevoProducto.TabIndex = 6;
            B_AgregarNuevoProducto.Text = "Agregar Producto";
            B_AgregarNuevoProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarNuevoProducto.UseVisualStyleBackColor = false;
            B_AgregarNuevoProducto.Click += B_AgregarNuevoProducto_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(378, 40);
            button3.Name = "button3";
            button3.Size = new Size(51, 52);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarCompra
            // 
            B_AgregarCompra.BackColor = SystemColors.ControlLightLight;
            B_AgregarCompra.Cursor = Cursors.Hand;
            B_AgregarCompra.Dock = DockStyle.Right;
            B_AgregarCompra.FlatAppearance.BorderSize = 0;
            B_AgregarCompra.FlatStyle = FlatStyle.Flat;
            B_AgregarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarCompra.Image = Properties.Resources.aceptar__1_;
            B_AgregarCompra.Location = new Point(1007, 0);
            B_AgregarCompra.Name = "B_AgregarCompra";
            B_AgregarCompra.Size = new Size(107, 113);
            B_AgregarCompra.TabIndex = 3;
            B_AgregarCompra.Text = "Confirmar";
            B_AgregarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarCompra.UseVisualStyleBackColor = false;
            B_AgregarCompra.Click += B_AgregarCompra_Click;
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
            B_ModificarCantidad.Location = new Point(1114, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(107, 113);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // B_CancelarCompra
            // 
            B_CancelarCompra.BackColor = SystemColors.ControlLightLight;
            B_CancelarCompra.Cursor = Cursors.Hand;
            B_CancelarCompra.Dock = DockStyle.Right;
            B_CancelarCompra.FlatAppearance.BorderSize = 0;
            B_CancelarCompra.FlatStyle = FlatStyle.Flat;
            B_CancelarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CancelarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarCompra.Image = Properties.Resources.rechazar__1_;
            B_CancelarCompra.Location = new Point(1221, 0);
            B_CancelarCompra.Name = "B_CancelarCompra";
            B_CancelarCompra.Size = new Size(107, 113);
            B_CancelarCompra.TabIndex = 1;
            B_CancelarCompra.Text = "Eliminar";
            B_CancelarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarCompra.UseVisualStyleBackColor = false;
            B_CancelarCompra.Click += B_CancelarCompra_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Producto.Location = new Point(25, 58);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(347, 34);
            TB_Producto.TabIndex = 0;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // TB_TotalCompra
            // 
            TB_TotalCompra.Dock = DockStyle.Right;
            TB_TotalCompra.Font = new Font("Arial Rounded MT Bold", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalCompra.Location = new Point(1030, 0);
            TB_TotalCompra.Name = "TB_TotalCompra";
            TB_TotalCompra.Size = new Size(298, 91);
            TB_TotalCompra.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(913, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 39);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(TB_TotalCompra);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 484);
            panel2.Name = "panel2";
            panel2.Size = new Size(1328, 88);
            panel2.TabIndex = 9;
            // 
            // V_ModificarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 572);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesCompras);
            Controls.Add(panelSuperior);
            Name = "V_ModificarCompra";
            Text = "V_ModificarCompra";
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_DetallesCompras;
        private Panel panelSuperior;
        private Button button3;
        private Button B_AgregarCompra;
        private Button B_ModificarCantidad;
        private Button B_CancelarCompra;
        private TextBox TB_Producto;
        private Button B_AgregarNuevoProducto;
        private DateTimePicker dateTimePicker1;
        private TextBox TB_Proveedor;
        private Label label1;
        private TextBox TB_TotalCompra;
        private Button B_EliminarProducto;
        private Panel panel2;
        private TextBox TB_FolioCompra;
    }
}