namespace POS_CHITOS
{
    partial class V_LogIn
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
            panel2 = new Panel();
            textBox5 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            B_Login = new Button();
            TB_PW = new TextBox();
            TB_Usuario = new TextBox();
            label_NewUsuario = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(B_Login);
            panel1.Controls.Add(TB_PW);
            panel1.Controls.Add(TB_Usuario);
            panel1.Controls.Add(label_NewUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 422);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 422);
            panel2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(10, 320);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 43);
            textBox5.TabIndex = 10;
            textBox5.Text = "* Llena los campos para iniciar sesion exitosamente *";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 64);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 1;
            label4.Text = "Registrate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor__2_;
            pictureBox1.Location = new Point(67, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // B_Login
            // 
            B_Login.AutoSize = true;
            B_Login.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Login.Image = Properties.Resources.aceptar__1_;
            B_Login.Location = new Point(479, 286);
            B_Login.Name = "B_Login";
            B_Login.Size = new Size(108, 69);
            B_Login.TabIndex = 6;
            B_Login.Text = "Ingresar";
            B_Login.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Login.UseVisualStyleBackColor = true;
            B_Login.Click += B_Login_Click;
            // 
            // TB_PW
            // 
            TB_PW.Font = new Font("Arial", 13.8F);
            TB_PW.Location = new Point(379, 212);
            TB_PW.Name = "TB_PW";
            TB_PW.PasswordChar = '*';
            TB_PW.Size = new Size(330, 34);
            TB_PW.TabIndex = 5;
            TB_PW.KeyDown += TB_PW_KeyDown;
            // 
            // TB_Usuario
            // 
            TB_Usuario.Font = new Font("Arial", 13.8F);
            TB_Usuario.Location = new Point(379, 124);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.Size = new Size(330, 34);
            TB_Usuario.TabIndex = 4;
            // 
            // label_NewUsuario
            // 
            label_NewUsuario.AutoSize = true;
            label_NewUsuario.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_NewUsuario.Location = new Point(432, 369);
            label_NewUsuario.Name = "label_NewUsuario";
            label_NewUsuario.Size = new Size(212, 27);
            label_NewUsuario.TabIndex = 3;
            label_NewUsuario.Text = "No Tengo Usuario";
            label_NewUsuario.Click += label_NewUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.Location = new Point(488, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(285, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(651, 69);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label1.Location = new Point(94, 20);
            label1.Name = "label1";
            label1.Size = new Size(342, 27);
            label1.TabIndex = 0;
            label1.Text = "Buen Dia Empleado de Chitos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.Location = new Point(455, 182);
            label3.Name = "label3";
            label3.Size = new Size(143, 27);
            label3.TabIndex = 2;
            label3.Text = "Contrasena";
            // 
            // V_LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 422);
            Controls.Add(panel1);
            Name = "V_LogIn";
            Text = "V_LogIn";
            Load += V_LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_NewUsuario;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private TextBox TB_PW;
        private TextBox TB_Usuario;
        private Button B_Login;
        private Panel panel2;
        private TextBox textBox5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}