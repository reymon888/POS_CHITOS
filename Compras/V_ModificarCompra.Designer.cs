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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ModificarCompra));
            DGV_DetallesCompras = new DataGridView();
            panelSuperior = new Panel();
            B_CambiarPrecio = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            TB_FolioCompra = new TextBox();
            B_EliminarProducto = new Button();
            TB_Proveedor = new TextBox();
            button3 = new Button();
            B_ModificarCantidad = new Button();
            TB_Producto = new TextBox();
            B_AgregarCompra = new Button();
            B_CancelarCompra = new Button();
            TB_TotalCompra = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).BeginInit();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_DetallesCompras
            // 
            DGV_DetallesCompras.AllowUserToAddRows = false;
            DGV_DetallesCompras.AllowUserToResizeColumns = false;
            DGV_DetallesCompras.AllowUserToResizeRows = false;
            DGV_DetallesCompras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_DetallesCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_DetallesCompras.Location = new Point(0, 161);
            DGV_DetallesCompras.MultiSelect = false;
            DGV_DetallesCompras.Name = "DGV_DetallesCompras";
            DGV_DetallesCompras.ReadOnly = true;
            DGV_DetallesCompras.RowHeadersWidth = 51;
            DGV_DetallesCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_DetallesCompras.Size = new Size(1486, 487);
            DGV_DetallesCompras.TabIndex = 8;
            DGV_DetallesCompras.CellDoubleClick += DGV_DetallesCompras_CellDoubleClick;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(B_CambiarPrecio);
            panelSuperior.Controls.Add(pictureBox4);
            panelSuperior.Controls.Add(pictureBox3);
            panelSuperior.Controls.Add(pictureBox2);
            panelSuperior.Controls.Add(TB_FolioCompra);
            panelSuperior.Controls.Add(B_EliminarProducto);
            panelSuperior.Controls.Add(TB_Proveedor);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_ModificarCantidad);
            panelSuperior.Controls.Add(TB_Producto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1503, 161);
            panelSuperior.TabIndex = 7;
            panelSuperior.Paint += panelSuperior_Paint;
            // 
            // B_CambiarPrecio
            // 
            B_CambiarPrecio.BackColor = SystemColors.ControlLightLight;
            B_CambiarPrecio.Cursor = Cursors.Hand;
            B_CambiarPrecio.Dock = DockStyle.Right;
            B_CambiarPrecio.FlatAppearance.BorderSize = 0;
            B_CambiarPrecio.FlatStyle = FlatStyle.Flat;
            B_CambiarPrecio.Font = new Font("Segoe UI", 12F);
            B_CambiarPrecio.ForeColor = Color.FromArgb(44, 140, 153);
            B_CambiarPrecio.Image = Properties.Resources.etiqueta_del_precio;
            B_CambiarPrecio.Location = new Point(1198, 0);
            B_CambiarPrecio.Name = "B_CambiarPrecio";
            B_CambiarPrecio.Size = new Size(103, 161);
            B_CambiarPrecio.TabIndex = 31;
            B_CambiarPrecio.Text = "Cambiar Precio (Ctrl + O)";
            B_CambiarPrecio.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CambiarPrecio.UseVisualStyleBackColor = false;
            B_CambiarPrecio.Click += B_CambiarPrecio_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox4.Location = new Point(11, 65);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.factura;
            pictureBox3.Location = new Point(11, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.servicio_al_cliente;
            pictureBox2.Location = new Point(11, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // TB_FolioCompra
            // 
            TB_FolioCompra.Font = new Font("Segoe UI", 12F);
            TB_FolioCompra.Location = new Point(49, 63);
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
            B_EliminarProducto.Font = new Font("Segoe UI", 12F);
            B_EliminarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_EliminarProducto.Image = Properties.Resources.boton_x;
            B_EliminarProducto.Location = new Point(1301, 0);
            B_EliminarProducto.Name = "B_EliminarProducto";
            B_EliminarProducto.Size = new Size(101, 161);
            B_EliminarProducto.TabIndex = 9;
            B_EliminarProducto.Text = "Eliminar Producto (Ctrl + E)";
            B_EliminarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_EliminarProducto.UseVisualStyleBackColor = false;
            B_EliminarProducto.Click += B_EliminarProducto_Click;
            // 
            // TB_Proveedor
            // 
            TB_Proveedor.Font = new Font("Segoe UI", 12F);
            TB_Proveedor.Location = new Point(49, 11);
            TB_Proveedor.Name = "TB_Proveedor";
            TB_Proveedor.PlaceholderText = "Proveedor";
            TB_Proveedor.Size = new Size(347, 34);
            TB_Proveedor.TabIndex = 8;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(629, 77);
            button3.Name = "button3";
            button3.Size = new Size(80, 81);
            button3.TabIndex = 4;
            button3.Text = " (Ctrl + S)";
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
            B_ModificarCantidad.Location = new Point(1402, 0);
            B_ModificarCantidad.Name = "B_ModificarCantidad";
            B_ModificarCantidad.Size = new Size(101, 161);
            B_ModificarCantidad.TabIndex = 2;
            B_ModificarCantidad.Text = "Cantidad (Ctrl + C)";
            B_ModificarCantidad.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCantidad.UseVisualStyleBackColor = false;
            B_ModificarCantidad.Click += B_ModificarCantidad_Click;
            // 
            // TB_Producto
            // 
            TB_Producto.Font = new Font("Segoe UI", 12F);
            TB_Producto.Location = new Point(49, 112);
            TB_Producto.Name = "TB_Producto";
            TB_Producto.PlaceholderText = "Selecciona el Producto";
            TB_Producto.Size = new Size(583, 34);
            TB_Producto.TabIndex = 0;
            TB_Producto.KeyDown += TB_Producto_KeyDown;
            // 
            // B_AgregarCompra
            // 
            B_AgregarCompra.BackColor = SystemColors.ControlLightLight;
            B_AgregarCompra.Cursor = Cursors.Hand;
            B_AgregarCompra.Dock = DockStyle.Left;
            B_AgregarCompra.FlatAppearance.BorderSize = 0;
            B_AgregarCompra.FlatStyle = FlatStyle.Flat;
            B_AgregarCompra.Font = new Font("Segoe UI", 12F);
            B_AgregarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarCompra.Image = Properties.Resources.aceptar__1_;
            B_AgregarCompra.Location = new Point(118, 0);
            B_AgregarCompra.Name = "B_AgregarCompra";
            B_AgregarCompra.Size = new Size(107, 110);
            B_AgregarCompra.TabIndex = 3;
            B_AgregarCompra.Text = "Confirmar (Ctrl + N)";
            B_AgregarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarCompra.UseVisualStyleBackColor = false;
            B_AgregarCompra.Click += B_AgregarCompra_Click;
            // 
            // B_CancelarCompra
            // 
            B_CancelarCompra.BackColor = SystemColors.ControlLightLight;
            B_CancelarCompra.Cursor = Cursors.Hand;
            B_CancelarCompra.Dock = DockStyle.Left;
            B_CancelarCompra.FlatAppearance.BorderSize = 0;
            B_CancelarCompra.FlatStyle = FlatStyle.Flat;
            B_CancelarCompra.Font = new Font("Segoe UI", 12F);
            B_CancelarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarCompra.Image = Properties.Resources.rechazar__1_;
            B_CancelarCompra.Location = new Point(0, 0);
            B_CancelarCompra.Name = "B_CancelarCompra";
            B_CancelarCompra.Size = new Size(118, 110);
            B_CancelarCompra.TabIndex = 1;
            B_CancelarCompra.Text = "Cancelar (Ctrl + Esc)";
            B_CancelarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarCompra.UseVisualStyleBackColor = false;
            B_CancelarCompra.Click += B_CancelarCompra_Click;
            // 
            // TB_TotalCompra
            // 
            TB_TotalCompra.Dock = DockStyle.Right;
            TB_TotalCompra.Font = new Font("Arial Rounded MT Bold", 43.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalCompra.Location = new Point(1144, 0);
            TB_TotalCompra.Name = "TB_TotalCompra";
            TB_TotalCompra.Size = new Size(359, 91);
            TB_TotalCompra.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1001, 33);
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
            panel2.Controls.Add(B_AgregarCompra);
            panel2.Controls.Add(B_CancelarCompra);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(1503, 110);
            panel2.TabIndex = 9;
            // 
            // V_ModificarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 656);
            Controls.Add(panel2);
            Controls.Add(DGV_DetallesCompras);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_ModificarCompra";
            Text = "Modificar Compra";
            ((System.ComponentModel.ISupportInitialize)DGV_DetallesCompras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox TB_Proveedor;
        private Label label1;
        private TextBox TB_TotalCompra;
        private Button B_EliminarProducto;
        private Panel panel2;
        private TextBox TB_FolioCompra;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button B_CambiarPrecio;
    }
}