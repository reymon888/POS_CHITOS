namespace POS_CHITOS
{
    partial class V_CreateInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_CreateInventario));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            CB_Categoria = new ComboBox();
            label7 = new Label();
            TB_Estante = new TextBox();
            label6 = new Label();
            B_Cancelar = new Button();
            B_CrearProducto = new Button();
            TB_PrecioVenta = new TextBox();
            TB_Stock = new TextBox();
            TB_DescripcionProducto = new TextBox();
            TB_CodigoProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CB_Categoria);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TB_Estante);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_CrearProducto);
            panel2.Controls.Add(TB_PrecioVenta);
            panel2.Controls.Add(TB_Stock);
            panel2.Controls.Add(TB_DescripcionProducto);
            panel2.Controls.Add(TB_CodigoProducto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 672);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(46, 137);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 16;
            label2.Text = "Codigo*";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aceite_de_motor;
            pictureBox2.Location = new Point(198, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(113, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 4);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(268, 24);
            label1.Name = "label1";
            label1.Size = new Size(331, 46);
            label1.TabIndex = 1;
            label1.Text = "Datos del Inventario";
            // 
            // CB_Categoria
            // 
            CB_Categoria.BackColor = Color.WhiteSmoke;
            CB_Categoria.Font = new Font("Segoe UI", 13.8F);
            CB_Categoria.ForeColor = Color.FromArgb(26, 77, 128);
            CB_Categoria.FormattingEnabled = true;
            CB_Categoria.Location = new Point(46, 470);
            CB_Categoria.Name = "CB_Categoria";
            CB_Categoria.Size = new Size(631, 39);
            CB_Categoria.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(46, 436);
            label7.Name = "label7";
            label7.Size = new Size(115, 31);
            label7.TabIndex = 0;
            label7.Text = "Categoria";
            // 
            // TB_Estante
            // 
            TB_Estante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Estante.BackColor = Color.WhiteSmoke;
            TB_Estante.Font = new Font("Segoe UI", 13.8F);
            TB_Estante.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Estante.Location = new Point(284, 366);
            TB_Estante.Name = "TB_Estante";
            TB_Estante.Size = new Size(186, 38);
            TB_Estante.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(284, 332);
            label6.Name = "label6";
            label6.Size = new Size(89, 31);
            label6.TabIndex = 0;
            label6.Text = "Estante";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.FlatAppearance.BorderSize = 0;
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(385, 559);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(214, 70);
            B_Cancelar.TabIndex = 9;
            B_Cancelar.Text = "  Cancelar (Esc) ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_CrearProducto
            // 
            B_CrearProducto.AutoSize = true;
            B_CrearProducto.BackColor = Color.FromArgb(26, 77, 128);
            B_CrearProducto.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_CrearProducto.ForeColor = SystemColors.ButtonHighlight;
            B_CrearProducto.Image = Properties.Resources.salvar1;
            B_CrearProducto.Location = new Point(135, 559);
            B_CrearProducto.Name = "B_CrearProducto";
            B_CrearProducto.Size = new Size(214, 70);
            B_CrearProducto.TabIndex = 8;
            B_CrearProducto.Text = "Guardar (Enter)";
            B_CrearProducto.TextAlign = ContentAlignment.MiddleRight;
            B_CrearProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_CrearProducto.UseVisualStyleBackColor = false;
            B_CrearProducto.Click += B_CrearProducto_Click;
            // 
            // TB_PrecioVenta
            // 
            TB_PrecioVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PrecioVenta.BackColor = Color.WhiteSmoke;
            TB_PrecioVenta.Font = new Font("Segoe UI", 13.8F);
            TB_PrecioVenta.ForeColor = Color.FromArgb(26, 77, 128);
            TB_PrecioVenta.Location = new Point(525, 366);
            TB_PrecioVenta.Name = "TB_PrecioVenta";
            TB_PrecioVenta.Size = new Size(186, 38);
            TB_PrecioVenta.TabIndex = 5;
            TB_PrecioVenta.KeyPress += TB_PrecioVenta_KeyPress;
            // 
            // TB_Stock
            // 
            TB_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Stock.BackColor = Color.WhiteSmoke;
            TB_Stock.Font = new Font("Segoe UI", 13.8F);
            TB_Stock.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Stock.Location = new Point(46, 366);
            TB_Stock.Name = "TB_Stock";
            TB_Stock.Size = new Size(186, 38);
            TB_Stock.TabIndex = 3;
            TB_Stock.KeyPress += TB_Stock_KeyPress;
            // 
            // TB_DescripcionProducto
            // 
            TB_DescripcionProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_DescripcionProducto.BackColor = Color.WhiteSmoke;
            TB_DescripcionProducto.Font = new Font("Segoe UI", 13.8F);
            TB_DescripcionProducto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_DescripcionProducto.Location = new Point(46, 268);
            TB_DescripcionProducto.Name = "TB_DescripcionProducto";
            TB_DescripcionProducto.Size = new Size(665, 38);
            TB_DescripcionProducto.TabIndex = 2;
            // 
            // TB_CodigoProducto
            // 
            TB_CodigoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_CodigoProducto.BackColor = Color.WhiteSmoke;
            TB_CodigoProducto.Font = new Font("Segoe UI", 13.8F);
            TB_CodigoProducto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_CodigoProducto.Location = new Point(46, 171);
            TB_CodigoProducto.Name = "TB_CodigoProducto";
            TB_CodigoProducto.Size = new Size(665, 38);
            TB_CodigoProducto.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(525, 332);
            label5.Name = "label5";
            label5.Size = new Size(152, 31);
            label5.TabIndex = 0;
            label5.Text = "Precio venta*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(46, 335);
            label4.Name = "label4";
            label4.Size = new Size(77, 31);
            label4.TabIndex = 0;
            label4.Text = "Stock ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(46, 234);
            label3.Name = "label3";
            label3.Size = new Size(147, 31);
            label3.TabIndex = 0;
            label3.Text = "Descripcion*";
            // 
            // V_CreateInventario
            // 
            AcceptButton = B_CrearProducto;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(794, 672);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_CreateInventario";
            ShowInTaskbar = false;
            Text = "Registrar Producto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Cancelar;
        private Button B_CrearProducto;
        private TextBox TB_PrecioVenta;
        private TextBox TB_Stock;
        private TextBox TB_DescripcionProducto;
        private TextBox TB_CodigoProducto;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TB_Estante;
        private Label label6;
        private Button B_agregarCategoria;
        private ComboBox CB_Categoria;
        private Label label7;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
    }
}