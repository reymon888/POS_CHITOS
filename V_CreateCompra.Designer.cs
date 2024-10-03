namespace POS_CHITOS
{
    partial class V_CreateCompra
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
            B_CancelarCompra = new Button();
            B_AgregarCompra = new Button();
            TB_TotalCompra = new TextBox();
            label1 = new Label();
            DGV_DetallesCompras = new DataGridView();
            panelSuperior = new Panel();
            TB_FolioCompra = new TextBox();
            B_EliminarProducto = new Button();
            TB_Proveedor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            B_AgregarNuevoProducto = new Button();
            button3 = new Button();
            B_ModificarCantidad = new Button();
            TB_Producto = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(B_CancelarCompra);
            panel2.Controls.Add(B_AgregarCompra);
            panel2.Controls.Add(TB_TotalCompra);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(1430, 88);
            panel2.TabIndex = 12;
            // 
            // B_CancelarCompra
            // 
            B_CancelarCompra.BackColor = SystemColors.ControlLightLight;
            B_CancelarCompra.Cursor = Cursors.Hand;
            B_CancelarCompra.Dock = DockStyle.Left;
            B_CancelarCompra.FlatAppearance.BorderSize = 0;
            B_CancelarCompra.FlatStyle = FlatStyle.Flat;
            B_CancelarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CancelarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarCompra.Image = Properties.Resources.rechazar__1_;
            B_CancelarCompra.Location = new Point(107, 0);
            B_CancelarCompra.Name = "B_CancelarCompra";
            B_CancelarCompra.Size = new Size(107, 88);
            B_CancelarCompra.TabIndex = 5;
            B_CancelarCompra.Text = "Cancelar";
            B_CancelarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarCompra.UseVisualStyleBackColor = false;
            B_CancelarCompra.Click += B_CancelarCompra_Click;
            // 
            // B_AgregarCompra
            // 
            B_AgregarCompra.BackColor = SystemColors.ControlLightLight;
            B_AgregarCompra.Cursor = Cursors.Hand;
            B_AgregarCompra.Dock = DockStyle.Left;
            B_AgregarCompra.FlatAppearance.BorderSize = 0;
            B_AgregarCompra.FlatStyle = FlatStyle.Flat;
            B_AgregarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarCompra.Image = Properties.Resources.aceptar__1_;
            B_AgregarCompra.Location = new Point(0, 0);
            B_AgregarCompra.Name = "B_AgregarCompra";
            B_AgregarCompra.Size = new Size(107, 88);
            B_AgregarCompra.TabIndex = 4;
            B_AgregarCompra.Text = "Confirmar";
            B_AgregarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarCompra.UseVisualStyleBackColor = false;
            B_AgregarCompra.Click += B_AgregarCompra_Click;
            // 
            // TB_TotalCompra
            // 
            TB_TotalCompra.Dock = DockStyle.Right;
            TB_TotalCompra.Font = new Font("Arial Rounded MT Bold", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalCompra.Location = new Point(1132, 0);
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
            // DGV_DetallesCompras
            // 
            DGV_DetallesCompras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesCompras.Dock = DockStyle.Fill;
            DGV_DetallesCompras.Location = new Point(0, 164);
            DGV_DetallesCompras.MultiSelect = false;
            DGV_DetallesCompras.Name = "DGV_DetallesCompras";
            DGV_DetallesCompras.ReadOnly = true;
            DGV_DetallesCompras.RowHeadersWidth = 51;
            DGV_DetallesCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesCompras.Size = new Size(1430, 496);
            DGV_DetallesCompras.TabIndex = 11;
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
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1430, 164);
            panelSuperior.TabIndex = 10;
            // 
            // TB_FolioCompra
            // 
            TB_FolioCompra.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_FolioCompra.Location = new Point(25, 109);
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
            B_EliminarProducto.Location = new Point(1216, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(107, 164);
            B_EliminarProducto.TabIndex = 9;
            B_EliminarProducto.Text = "Eliminar Producto";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // TB_Proveedor
            // 
            TB_Proveedor.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Proveedor.Location = new Point(25, 65);
            TB_Proveedor.Name = "TB_Proveedor";
            TB_Proveedor.PlaceholderText = "Proveedor";
            TB_Proveedor.Size = new Size(499, 34);
            TB_Proveedor.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(608, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(389, 30);
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
            B_ModificarCantidad.Location = new Point(1323, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(107, 164);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Producto.Location = new Point(25, 12);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(347, 34);
            TB_Producto.TabIndex = 0;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // V_CreateCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 660);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesCompras);
            Controls.Add(panelSuperior);
            Name = "V_CreateCompra";
            Text = "Realizar Compra";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox TB_TotalCompra;
        private Label label1;
        private DataGridView DGV_DetallesCompras;
        private Panel panelSuperior;
        private TextBox TB_FolioCompra;
        private Button B_EliminarProducto;
        private TextBox TB_Proveedor;
        private DateTimePicker dateTimePicker1;
        private Button B_AgregarNuevoProducto;
        private Button button3;
        private Button B_ModificarCantidad;
        private TextBox TB_Producto;
        private Button B_CancelarCompra;
        private Button B_AgregarCompra;
    }
}