namespace POS_CHITOS
{
    partial class V_Register
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
            TB_newPW2 = new TextBox();
            label5 = new Label();
            CB_Rol = new ComboBox();
            B_Cancelar = new Button();
            B_RegistrarUsuario = new Button();
            TB_newPW = new TextBox();
            TB_newUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel2.Controls.Add(TB_newPW2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CB_Rol);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_RegistrarUsuario);
            panel2.Controls.Add(TB_newPW);
            panel2.Controls.Add(TB_newUser);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 495);
            panel2.TabIndex = 5;
            // 
            // TB_newPW2
            // 
            TB_newPW2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_newPW2.Location = new Point(87, 240);
            TB_newPW2.Name = "TB_newPW2";
            TB_newPW2.PasswordChar = '*';
            TB_newPW2.Size = new Size(284, 34);
            TB_newPW2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 210);
            label5.Name = "label5";
            label5.Size = new Size(272, 27);
            label5.TabIndex = 13;
            label5.Text = "Confirmar Contraseña*";
            // 
            // CB_Rol
            // 
            CB_Rol.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Rol.FormattingEnabled = true;
            CB_Rol.Location = new Point(87, 331);
            CB_Rol.Name = "CB_Rol";
            CB_Rol.Size = new Size(284, 31);
            CB_Rol.TabIndex = 12;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(266, 399);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(148, 70);
            B_Cancelar.TabIndex = 11;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_RegistrarUsuario
            // 
            B_RegistrarUsuario.AutoSize = true;
            B_RegistrarUsuario.BackColor = Color.FromArgb(192, 255, 192);
            B_RegistrarUsuario.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_RegistrarUsuario.Image = Properties.Resources.aceptar__1_;
            B_RegistrarUsuario.Location = new Point(32, 399);
            B_RegistrarUsuario.Name = "B_RegistrarUsuario";
            B_RegistrarUsuario.Size = new Size(152, 70);
            B_RegistrarUsuario.TabIndex = 10;
            B_RegistrarUsuario.Text = "Aceptar (Enter)";
            B_RegistrarUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_RegistrarUsuario.UseVisualStyleBackColor = false;
            B_RegistrarUsuario.Click += B_RegistrarUsuario_Click;
            // 
            // TB_newPW
            // 
            TB_newPW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_newPW.Location = new Point(87, 157);
            TB_newPW.Name = "TB_newPW";
            TB_newPW.PasswordChar = '*';
            TB_newPW.Size = new Size(284, 34);
            TB_newPW.TabIndex = 7;
            // 
            // TB_newUser
            // 
            TB_newUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_newUser.Location = new Point(87, 69);
            TB_newUser.Name = "TB_newUser";
            TB_newUser.Size = new Size(284, 34);
            TB_newUser.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(133, 301);
            label4.Name = "label4";
            label4.Size = new Size(183, 27);
            label4.TabIndex = 4;
            label4.Text = "Rol de usuario*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 127);
            label3.Name = "label3";
            label3.Size = new Size(153, 27);
            label3.TabIndex = 3;
            label3.Text = "Contraseña*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 26);
            label2.Name = "label2";
            label2.Size = new Size(235, 27);
            label2.TabIndex = 2;
            label2.Text = "Nombre de usuario*";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 495);
            panel1.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(3, 309);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 43);
            textBox5.TabIndex = 10;
            textBox5.Text = "* Llena los campos para registrarte exitosamente *";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 67);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 1;
            label1.Text = "Registrate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor__2_;
            pictureBox1.Location = new Point(66, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_Register";
            Text = "V_Register";
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
        private Button B_RegistrarUsuario;
        private TextBox TB_newPW;
        private TextBox TB_newUser;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private TextBox textBox5;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox CB_Rol;
        private TextBox TB_newPW2;
        private Label label5;
    }
}