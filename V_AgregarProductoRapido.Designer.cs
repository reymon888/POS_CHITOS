namespace POS_CHITOS
{
    partial class V_AgregarProductoRapido
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
            B_AgregarProductoRapido = new Button();
            TB_PrecioVenta = new TextBox();
            TB_Cantidad = new TextBox();
            TB_Descripcion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_AgregarProductoRapido);
            panel2.Controls.Add(TB_PrecioVenta);
            panel2.Controls.Add(TB_Cantidad);
            panel2.Controls.Add(TB_Descripcion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 385);
            panel2.TabIndex = 5;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(337, 237);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(135, 70);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_AgregarProductoRapido
            // 
            B_AgregarProductoRapido.AutoSize = true;
            B_AgregarProductoRapido.BackColor = Color.FromArgb(192, 255, 192);
            B_AgregarProductoRapido.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_AgregarProductoRapido.Image = Properties.Resources.aceptar__1_;
            B_AgregarProductoRapido.Location = new Point(101, 237);
            B_AgregarProductoRapido.Name = "B_AgregarProductoRapido";
            B_AgregarProductoRapido.Size = new Size(152, 70);
            B_AgregarProductoRapido.TabIndex = 5;
            B_AgregarProductoRapido.Text = "Aceptar (Enter)";
            B_AgregarProductoRapido.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProductoRapido.UseVisualStyleBackColor = false;
            B_AgregarProductoRapido.Click += B_AgregarProductoRapido_Click;
            // 
            // TB_PrecioVenta
            // 
            TB_PrecioVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PrecioVenta.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_PrecioVenta.Location = new Point(30, 158);
            TB_PrecioVenta.Name = "TB_PrecioVenta";
            TB_PrecioVenta.Size = new Size(232, 34);
            TB_PrecioVenta.TabIndex = 4;
            // 
            // TB_Cantidad
            // 
            TB_Cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cantidad.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cantidad.Location = new Point(319, 158);
            TB_Cantidad.Name = "TB_Cantidad";
            TB_Cantidad.Size = new Size(176, 34);
            TB_Cantidad.TabIndex = 3;
            // 
            // TB_Descripcion
            // 
            TB_Descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Descripcion.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Descripcion.Location = new Point(69, 68);
            TB_Descripcion.Name = "TB_Descripcion";
            TB_Descripcion.Size = new Size(415, 34);
            TB_Descripcion.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 114);
            label5.Name = "label5";
            label5.Size = new Size(125, 27);
            label5.TabIndex = 5;
            label5.Text = "Precio c/u";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 114);
            label4.Name = "label4";
            label4.Size = new Size(113, 27);
            label4.TabIndex = 4;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 38);
            label3.Name = "label3";
            label3.Size = new Size(157, 27);
            label3.TabIndex = 3;
            label3.Text = "Descripcion*";
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
            panel1.Size = new Size(268, 385);
            panel1.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(10, 292);
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
            label1.Location = new Point(-2, 51);
            label1.Name = "label1";
            label1.Size = new Size(299, 27);
            label1.TabIndex = 1;
            label1.Text = "Agregar Producto Rapido";
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
            // V_AgregarProductoRapido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 385);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_AgregarProductoRapido";
            Text = "V_AgregarProductoRapido";
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
        private Button B_AgregarProductoRapido;
        private TextBox TB_PrecioVenta;
        private TextBox TB_Cantidad;
        private TextBox TB_Descripcion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private TextBox textBox5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}