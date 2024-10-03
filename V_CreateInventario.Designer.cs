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
            panel2 = new Panel();
            B_Cancelar = new Button();
            B_CrearProducto = new Button();
            TB_PrecioVenta = new TextBox();
            TB_Stock = new TextBox();
            TB_DescripcionProducto = new TextBox();
            TB_CodigoProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TB_Estante = new TextBox();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
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
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 472);
            panel2.TabIndex = 3;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(305, 349);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(135, 70);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_CrearProducto
            // 
            B_CrearProducto.AutoSize = true;
            B_CrearProducto.BackColor = Color.FromArgb(192, 255, 192);
            B_CrearProducto.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_CrearProducto.Image = Properties.Resources.aceptar__1_;
            B_CrearProducto.Location = new Point(69, 349);
            B_CrearProducto.Name = "B_CrearProducto";
            B_CrearProducto.Size = new Size(152, 70);
            B_CrearProducto.TabIndex = 5;
            B_CrearProducto.Text = "Aceptar (Enter)";
            B_CrearProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CrearProducto.UseVisualStyleBackColor = false;
            B_CrearProducto.Click += B_CrearProducto_Click;
            // 
            // TB_PrecioVenta
            // 
            TB_PrecioVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PrecioVenta.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_PrecioVenta.Location = new Point(272, 224);
            TB_PrecioVenta.Name = "TB_PrecioVenta";
            TB_PrecioVenta.Size = new Size(232, 34);
            TB_PrecioVenta.TabIndex = 4;
            TB_PrecioVenta.KeyPress += TB_PrecioVenta_KeyPress;
            // 
            // TB_Stock
            // 
            TB_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Stock.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Stock.Location = new Point(20, 224);
            TB_Stock.Name = "TB_Stock";
            TB_Stock.Size = new Size(176, 34);
            TB_Stock.TabIndex = 3;
            TB_Stock.KeyPress += TB_Stock_KeyPress;
            // 
            // TB_DescripcionProducto
            // 
            TB_DescripcionProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_DescripcionProducto.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_DescripcionProducto.Location = new Point(56, 134);
            TB_DescripcionProducto.Name = "TB_DescripcionProducto";
            TB_DescripcionProducto.Size = new Size(415, 34);
            TB_DescripcionProducto.TabIndex = 2;
            // 
            // TB_CodigoProducto
            // 
            TB_CodigoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_CodigoProducto.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_CodigoProducto.Location = new Point(56, 53);
            TB_CodigoProducto.Name = "TB_CodigoProducto";
            TB_CodigoProducto.Size = new Size(415, 34);
            TB_CodigoProducto.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(286, 183);
            label5.Name = "label5";
            label5.Size = new Size(209, 27);
            label5.TabIndex = 5;
            label5.Text = "Precio a la venta*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 183);
            label4.Name = "label4";
            label4.Size = new Size(82, 27);
            label4.TabIndex = 4;
            label4.Text = "Stock ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 104);
            label3.Name = "label3";
            label3.Size = new Size(157, 27);
            label3.TabIndex = 3;
            label3.Text = "Descripcion*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 23);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 2;
            label2.Text = "Codigo*";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 472);
            panel1.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(10, 283);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 61);
            textBox5.TabIndex = 10;
            textBox5.Text = "* Llena los campos para modificar el producto correctamente *";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 49);
            label1.Name = "label1";
            label1.Size = new Size(226, 27);
            label1.TabIndex = 1;
            label1.Text = "Modificar Producto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor__2_;
            pictureBox1.Location = new Point(64, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TB_Estante
            // 
            TB_Estante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Estante.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Estante.Location = new Point(185, 285);
            TB_Estante.Name = "TB_Estante";
            TB_Estante.Size = new Size(176, 34);
            TB_Estante.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(56, 292);
            label6.Name = "label6";
            label6.Size = new Size(97, 27);
            label6.TabIndex = 8;
            label6.Text = "Estante";
            // 
            // V_CreateInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 472);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_CreateInventario";
            Text = "V_CreateInventario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label2;
        private Panel panel1;
        private TextBox textBox5;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox TB_Estante;
        private Label label6;
    }
}