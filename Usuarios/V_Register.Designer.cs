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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Register));
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
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
            panel2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 691);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(35, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 4);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.busqueda_de_trabajo;
            pictureBox1.Location = new Point(147, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 26);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 17;
            label1.Text = "Datos Usuario";
            // 
            // TB_newPW2
            // 
            TB_newPW2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW2.BackColor = Color.WhiteSmoke;
            TB_newPW2.Font = new Font("Segoe UI", 13.8F);
            TB_newPW2.ForeColor = Color.FromArgb(26, 77, 128);
            TB_newPW2.Location = new Point(76, 392);
            TB_newPW2.Name = "TB_newPW2";
            TB_newPW2.PasswordChar = '*';
            TB_newPW2.Size = new Size(472, 38);
            TB_newPW2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(79, 358);
            label5.Name = "label5";
            label5.Size = new Size(252, 31);
            label5.TabIndex = 0;
            label5.Text = "Confirmar Contraseña*";
            // 
            // CB_Rol
            // 
            CB_Rol.BackColor = Color.WhiteSmoke;
            CB_Rol.Font = new Font("Segoe UI", 13.8F);
            CB_Rol.ForeColor = Color.FromArgb(26, 77, 128);
            CB_Rol.FormattingEnabled = true;
            CB_Rol.Location = new Point(79, 494);
            CB_Rol.Name = "CB_Rol";
            CB_Rol.Size = new Size(472, 39);
            CB_Rol.TabIndex = 4;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(326, 574);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(225, 70);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (Esc)";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_RegistrarUsuario
            // 
            B_RegistrarUsuario.AutoSize = true;
            B_RegistrarUsuario.BackColor = Color.FromArgb(26, 77, 128);
            B_RegistrarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            B_RegistrarUsuario.ForeColor = SystemColors.ButtonHighlight;
            B_RegistrarUsuario.Image = Properties.Resources.salvar1;
            B_RegistrarUsuario.Location = new Point(91, 574);
            B_RegistrarUsuario.Name = "B_RegistrarUsuario";
            B_RegistrarUsuario.Size = new Size(229, 70);
            B_RegistrarUsuario.TabIndex = 5;
            B_RegistrarUsuario.Text = "Aceptar (Enter)";
            B_RegistrarUsuario.TextAlign = ContentAlignment.MiddleRight;
            B_RegistrarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_RegistrarUsuario.UseVisualStyleBackColor = false;
            B_RegistrarUsuario.Click += B_RegistrarUsuario_Click;
            // 
            // TB_newPW
            // 
            TB_newPW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW.BackColor = Color.WhiteSmoke;
            TB_newPW.Font = new Font("Segoe UI", 13.8F);
            TB_newPW.ForeColor = Color.FromArgb(26, 77, 128);
            TB_newPW.Location = new Point(82, 284);
            TB_newPW.Name = "TB_newPW";
            TB_newPW.PasswordChar = '*';
            TB_newPW.Size = new Size(472, 38);
            TB_newPW.TabIndex = 2;
            // 
            // TB_newUser
            // 
            TB_newUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newUser.BackColor = Color.WhiteSmoke;
            TB_newUser.Font = new Font("Segoe UI", 13.8F);
            TB_newUser.ForeColor = Color.FromArgb(26, 77, 128);
            TB_newUser.Location = new Point(82, 189);
            TB_newUser.Name = "TB_newUser";
            TB_newUser.Size = new Size(472, 38);
            TB_newUser.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(79, 460);
            label4.Name = "label4";
            label4.Size = new Size(172, 31);
            label4.TabIndex = 0;
            label4.Text = "Rol de usuario*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(79, 250);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 0;
            label3.Text = "Contraseña*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(82, 146);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 0;
            label2.Text = "Nombre de usuario*";
            // 
            // V_Register
            // 
            AcceptButton = B_RegistrarUsuario;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(677, 691);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Register";
            ShowInTaskbar = false;
            Text = "Registrar Usuarios";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ComboBox CB_Rol;
        private TextBox TB_newPW2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
    }
}