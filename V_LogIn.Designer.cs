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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LogIn));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            B_Login = new Button();
            TB_PW = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            TB_Usuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 467);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(B_Login);
            panel2.Controls.Add(TB_PW);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(TB_Usuario);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 467);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = Properties.Resources.Chitos__2_;
            pictureBox1.Location = new Point(36, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // B_Login
            // 
            B_Login.AutoSize = true;
            B_Login.BackColor = Color.FromArgb(26, 77, 128);
            B_Login.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Login.ForeColor = Color.White;
            B_Login.Location = new Point(468, 347);
            B_Login.Name = "B_Login";
            B_Login.Size = new Size(183, 80);
            B_Login.TabIndex = 3;
            B_Login.Text = "Ingresar";
            B_Login.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Login.UseVisualStyleBackColor = false;
            B_Login.Click += B_Login_Click;
            // 
            // TB_PW
            // 
            TB_PW.Font = new Font("Segoe UI", 13.8F);
            TB_PW.Location = new Point(430, 275);
            TB_PW.Name = "TB_PW";
            TB_PW.PasswordChar = '*';
            TB_PW.Size = new Size(330, 38);
            TB_PW.TabIndex = 2;
            TB_PW.KeyDown += TB_PW_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 77, 128);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 69);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(204, 18);
            label1.Name = "label1";
            label1.Size = new Size(520, 38);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a Taller Automotriz Chito's";
            // 
            // TB_Usuario
            // 
            TB_Usuario.Font = new Font("Segoe UI", 13.8F);
            TB_Usuario.Location = new Point(430, 155);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.Size = new Size(330, 38);
            TB_Usuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.Location = new Point(430, 210);
            label3.Name = "label3";
            label3.Size = new Size(160, 38);
            label3.TabIndex = 2;
            label3.Text = "Contrasena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.Location = new Point(430, 101);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // V_LogIn
            // 
            AcceptButton = B_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 467);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_LogIn";
            Text = "Iniciar Sesion";
            Load += V_LogIn_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private TextBox TB_PW;
        private TextBox TB_Usuario;
        private Button B_Login;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}