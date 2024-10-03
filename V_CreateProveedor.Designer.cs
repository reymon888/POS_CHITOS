namespace POS_CHITOS
{
    partial class V_CreateProveedor
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
            panel1 = new Panel();
            textBox5 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            B_Cancelar = new Button();
            B_CrearProveedor = new Button();
            TB_DireccionProveedor = new TextBox();
            TB_CEProveedor = new TextBox();
            TB_TelefonoProveedor = new TextBox();
            TB_NombreProveedor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(268, 412);
            panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(11, 282);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 43);
            textBox5.TabIndex = 10;
            textBox5.Text = "* Llena los campos para registrar un nuevo proveedor *";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 49);
            label1.Name = "label1";
            label1.Size = new Size(206, 27);
            label1.TabIndex = 1;
            label1.Text = "Nuevo Proveedor";
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_CrearProveedor);
            panel2.Controls.Add(TB_DireccionProveedor);
            panel2.Controls.Add(TB_CEProveedor);
            panel2.Controls.Add(TB_TelefonoProveedor);
            panel2.Controls.Add(TB_NombreProveedor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 412);
            panel2.TabIndex = 1;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(497, 226);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(135, 70);
            B_Cancelar.TabIndex = 11;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_CrearProveedor
            // 
            B_CrearProveedor.AutoSize = true;
            B_CrearProveedor.BackColor = Color.FromArgb(192, 255, 192);
            B_CrearProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_CrearProveedor.Image = Properties.Resources.aceptar__1_;
            B_CrearProveedor.Location = new Point(493, 69);
            B_CrearProveedor.Name = "B_CrearProveedor";
            B_CrearProveedor.Size = new Size(152, 74);
            B_CrearProveedor.TabIndex = 10;
            B_CrearProveedor.Text = "Aceptar (Enter)";
            B_CrearProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CrearProveedor.UseVisualStyleBackColor = false;
            B_CrearProveedor.Click += B_CrearProveedor_Click;
            // 
            // TB_DireccionProveedor
            // 
            TB_DireccionProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_DireccionProveedor.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_DireccionProveedor.Location = new Point(17, 345);
            TB_DireccionProveedor.Name = "TB_DireccionProveedor";
            TB_DireccionProveedor.Size = new Size(415, 34);
            TB_DireccionProveedor.TabIndex = 9;
            // 
            // TB_CEProveedor
            // 
            TB_CEProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_CEProveedor.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_CEProveedor.Location = new Point(17, 262);
            TB_CEProveedor.Name = "TB_CEProveedor";
            TB_CEProveedor.Size = new Size(415, 34);
            TB_CEProveedor.TabIndex = 8;
            // 
            // TB_TelefonoProveedor
            // 
            TB_TelefonoProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_TelefonoProveedor.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TelefonoProveedor.Location = new Point(17, 161);
            TB_TelefonoProveedor.Name = "TB_TelefonoProveedor";
            TB_TelefonoProveedor.Size = new Size(284, 34);
            TB_TelefonoProveedor.TabIndex = 7;
            // 
            // TB_NombreProveedor
            // 
            TB_NombreProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_NombreProveedor.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_NombreProveedor.Location = new Point(17, 69);
            TB_NombreProveedor.Name = "TB_NombreProveedor";
            TB_NombreProveedor.Size = new Size(415, 34);
            TB_NombreProveedor.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 315);
            label5.Name = "label5";
            label5.Size = new Size(131, 27);
            label5.TabIndex = 5;
            label5.Text = "Direccion*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 221);
            label4.Name = "label4";
            label4.Size = new Size(226, 27);
            label4.TabIndex = 4;
            label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 131);
            label3.Name = "label3";
            label3.Size = new Size(120, 27);
            label3.TabIndex = 3;
            label3.Text = "Telefono*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 2;
            label2.Text = "Nombre*";
            // 
            // V_CreateProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 412);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_CreateProveedor";
            Text = "V_CreateProveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TB_DireccionProveedor;
        private TextBox TB_CEProveedor;
        private TextBox TB_TelefonoProveedor;
        private TextBox TB_NombreProveedor;
        private TextBox textBox5;
        private Button B_Cancelar;
        private Button B_CrearProveedor;
    }
}