namespace POS_CHITOS.Usuarios
{
    partial class V_CambiarPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_CambiarPW));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            B_Cancelar = new Button();
            B_Guardar = new Button();
            TB_newPW = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TB_newPW2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 77, 128);
            panel2.Location = new Point(110, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 4);
            panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.busqueda_de_trabajo;
            pictureBox1.Location = new Point(222, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(302, 35);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 39;
            label1.Text = "Contraseña nueva";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(404, 362);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(225, 70);
            B_Cancelar.TabIndex = 4;
            B_Cancelar.Text = "Cancelar (Esc)";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_Guardar
            // 
            B_Guardar.AutoSize = true;
            B_Guardar.BackColor = Color.FromArgb(26, 77, 128);
            B_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            B_Guardar.ForeColor = SystemColors.ButtonHighlight;
            B_Guardar.Image = Properties.Resources.salvar1;
            B_Guardar.Location = new Point(169, 362);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(229, 70);
            B_Guardar.TabIndex = 3;
            B_Guardar.Text = "Aceptar (Enter)";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
            // 
            // TB_newPW
            // 
            TB_newPW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW.BackColor = Color.WhiteSmoke;
            TB_newPW.Font = new Font("Segoe UI", 13.8F);
            TB_newPW.ForeColor = Color.FromArgb(26, 77, 128);
            TB_newPW.Location = new Point(157, 195);
            TB_newPW.Name = "TB_newPW";
            TB_newPW.PasswordChar = '*';
            TB_newPW.Size = new Size(472, 38);
            TB_newPW.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(157, 248);
            label4.Name = "label4";
            label4.Size = new Size(239, 31);
            label4.TabIndex = 33;
            label4.Text = "Confirmar contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(157, 152);
            label2.Name = "label2";
            label2.Size = new Size(199, 31);
            label2.TabIndex = 34;
            label2.Text = "Contraseña nueva";
            // 
            // TB_newPW2
            // 
            TB_newPW2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_newPW2.BackColor = Color.WhiteSmoke;
            TB_newPW2.Font = new Font("Segoe UI", 13.8F);
            TB_newPW2.ForeColor = Color.FromArgb(26, 77, 128);
            TB_newPW2.Location = new Point(157, 282);
            TB_newPW2.Name = "TB_newPW2";
            TB_newPW2.PasswordChar = '*';
            TB_newPW2.Size = new Size(472, 38);
            TB_newPW2.TabIndex = 2;
            // 
            // V_CambiarPW
            // 
            AcceptButton = B_Guardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_newPW2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(B_Cancelar);
            Controls.Add(B_Guardar);
            Controls.Add(TB_newPW);
            Controls.Add(label4);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_CambiarPW";
            Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button B_Cancelar;
        private Button B_Guardar;
        private TextBox TB_newPW;
        private Label label4;
        private Label label2;
        private TextBox TB_newPW2;
    }
}