namespace POS_CHITOS
{
    partial class menuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            PanelSuperior = new Panel();
            panel1 = new Panel();
            B_Salir = new Button();
            labelCargo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            panelEscritorio = new Panel();
            pictureBox3 = new PictureBox();
            B_Menu = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            PanelLateral = new Panel();
            PanelSuperior.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(26, 77, 128);
            PanelSuperior.Controls.Add(panel1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(268, 0);
            PanelSuperior.Margin = new Padding(4);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1542, 133);
            PanelSuperior.TabIndex = 1;
            PanelSuperior.Paint += menuSuperior_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(B_Salir);
            panel1.Controls.Add(labelCargo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1026, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 133);
            panel1.TabIndex = 0;
            // 
            // B_Salir
            // 
            B_Salir.AutoSize = true;
            B_Salir.Dock = DockStyle.Right;
            B_Salir.FlatAppearance.BorderSize = 0;
            B_Salir.FlatStyle = FlatStyle.Flat;
            B_Salir.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Salir.ForeColor = SystemColors.ButtonFace;
            B_Salir.Image = Properties.Resources.boton_x;
            B_Salir.Location = new Point(431, 0);
            B_Salir.Margin = new Padding(4);
            B_Salir.Name = "B_Salir";
            B_Salir.Size = new Size(85, 133);
            B_Salir.TabIndex = 11;
            B_Salir.TabStop = false;
            B_Salir.Text = " (F12)";
            B_Salir.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Salir.UseVisualStyleBackColor = true;
            B_Salir.Click += B_Salir_Click;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Font = new Font("Segoe UI", 12F);
            labelCargo.ForeColor = SystemColors.ButtonHighlight;
            labelCargo.Location = new Point(125, 70);
            labelCargo.Margin = new Padding(4, 0, 4, 0);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(77, 32);
            labelCargo.TabIndex = 3;
            labelCargo.Text = "Cargo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoEllipsis = true;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(125, 34);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(121, 32);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Nickname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero;
            pictureBox1.Location = new Point(22, 21);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = SystemColors.ActiveBorder;
            panelEscritorio.Controls.Add(pictureBox3);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(268, 133);
            panelEscritorio.Margin = new Padding(4);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1542, 1108);
            panelEscritorio.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.Chitos__1_;
            pictureBox3.Location = new Point(4, -7);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1530, 1138);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // B_Menu
            // 
            B_Menu.AutoSize = true;
            B_Menu.Dock = DockStyle.Top;
            B_Menu.FlatAppearance.BorderSize = 0;
            B_Menu.FlatStyle = FlatStyle.Flat;
            B_Menu.Font = new Font("Arial", 9F, FontStyle.Bold);
            B_Menu.ForeColor = SystemColors.ButtonFace;
            B_Menu.Image = Properties.Resources.lista;
            B_Menu.Location = new Point(0, 0);
            B_Menu.Margin = new Padding(4);
            B_Menu.Name = "B_Menu";
            B_Menu.Size = new Size(268, 133);
            B_Menu.TabIndex = 3;
            B_Menu.TabStop = false;
            B_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Menu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(0, 1, 227, 106);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Properties.Resources.payments_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            button1.Location = new Point(0, 133);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(268, 83);
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(0, 1, 227, 106);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = Properties.Resources.metodo_de_pago__1_;
            button2.Location = new Point(0, 216);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(268, 83);
            button2.TabIndex = 5;
            button2.TabStop = false;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Image = Properties.Resources.lista;
            button3.Location = new Point(0, 299);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(268, 83);
            button3.TabIndex = 6;
            button3.TabStop = false;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Image = Properties.Resources.lista;
            button4.Location = new Point(0, 382);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(268, 83);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Image = Properties.Resources.lista;
            button5.Location = new Point(0, 465);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(268, 83);
            button5.TabIndex = 8;
            button5.TabStop = false;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 9F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Image = Properties.Resources.lista;
            button6.Location = new Point(0, 548);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(268, 83);
            button6.TabIndex = 9;
            button6.TabStop = false;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 9F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Image = Properties.Resources.lista;
            button7.Location = new Point(0, 631);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(268, 83);
            button7.TabIndex = 10;
            button7.TabStop = false;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 9F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Image = Properties.Resources.lista;
            button8.Location = new Point(0, 714);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(268, 83);
            button8.TabIndex = 11;
            button8.TabStop = false;
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 9F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Image = Properties.Resources.lista;
            button9.Location = new Point(0, 797);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(268, 83);
            button9.TabIndex = 12;
            button9.TabStop = false;
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 9F, FontStyle.Bold);
            button10.ForeColor = SystemColors.ButtonFace;
            button10.Image = Properties.Resources.lista;
            button10.Location = new Point(0, 880);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(268, 83);
            button10.TabIndex = 13;
            button10.TabStop = false;
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = true;
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = Color.FromArgb(26, 77, 128);
            PanelLateral.Controls.Add(button10);
            PanelLateral.Controls.Add(button9);
            PanelLateral.Controls.Add(button8);
            PanelLateral.Controls.Add(button7);
            PanelLateral.Controls.Add(button6);
            PanelLateral.Controls.Add(button5);
            PanelLateral.Controls.Add(button4);
            PanelLateral.Controls.Add(button3);
            PanelLateral.Controls.Add(button2);
            PanelLateral.Controls.Add(button1);
            PanelLateral.Controls.Add(B_Menu);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Margin = new Padding(4);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(268, 1241);
            PanelLateral.TabIndex = 0;
            PanelLateral.Paint += menuLateral_Paint;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1810, 1241);
            Controls.Add(panelEscritorio);
            Controls.Add(PanelSuperior);
            Controls.Add(PanelLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "menuPrincipal";
            Text = "Punto de Venta Chito's";
            Load += Form1_Load;
            KeyDown += menuPrincipal_KeyDown;
            PanelSuperior.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelLateral.ResumeLayout(false);
            PanelLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelSuperior;
        private Panel panelEscritorio;
        private Panel panel1;
        private Label labelUsuario;
        private PictureBox pictureBox1;
        private Label labelCargo;
        private Button B_Salir;
        private PictureBox pictureBox3;
        private Button B_Menu;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel PanelLateral;
    }
}
