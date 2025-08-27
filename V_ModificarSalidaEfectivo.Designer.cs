namespace POS_CHITOS
{
    partial class V_ModificarSalidaEfectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ModificarSalidaEfectivo));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            TB_Monto = new TextBox();
            TB_Concepto = new TextBox();
            label5 = new Label();
            label3 = new Label();
            B_Cancelar = new Button();
            B_ModificarSalida = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TB_Monto);
            panel2.Controls.Add(TB_Concepto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_ModificarSalida);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 346);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.salir;
            pictureBox2.Location = new Point(177, 8);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(103, 86);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 3);
            panel1.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(238, 19);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 55;
            label1.Text = "Datos del Gasto";
            // 
            // TB_Monto
            // 
            TB_Monto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Monto.BackColor = Color.WhiteSmoke;
            TB_Monto.Font = new Font("Segoe UI", 13.8F);
            TB_Monto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Monto.Location = new Point(193, 208);
            TB_Monto.Margin = new Padding(3, 2, 3, 2);
            TB_Monto.Name = "TB_Monto";
            TB_Monto.Size = new Size(312, 32);
            TB_Monto.TabIndex = 59;
            TB_Monto.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_Concepto
            // 
            TB_Concepto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Concepto.BackColor = Color.WhiteSmoke;
            TB_Concepto.Font = new Font("Segoe UI", 13.8F);
            TB_Concepto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Concepto.Location = new Point(110, 129);
            TB_Concepto.Margin = new Padding(3, 2, 3, 2);
            TB_Concepto.Name = "TB_Concepto";
            TB_Concepto.Size = new Size(501, 32);
            TB_Concepto.TabIndex = 58;
            TB_Concepto.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(298, 182);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 56;
            label5.Text = "Monto*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(287, 104);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 57;
            label3.Text = "Concepto*";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(351, 260);
            B_Cancelar.Margin = new Padding(3, 2, 3, 2);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(202, 55);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (Esc)";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_ModificarSalida
            // 
            B_ModificarSalida.AutoSize = true;
            B_ModificarSalida.BackColor = Color.FromArgb(26, 77, 128);
            B_ModificarSalida.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_ModificarSalida.ForeColor = Color.White;
            B_ModificarSalida.Image = Properties.Resources.salvar1;
            B_ModificarSalida.Location = new Point(135, 260);
            B_ModificarSalida.Margin = new Padding(3, 2, 3, 2);
            B_ModificarSalida.Name = "B_ModificarSalida";
            B_ModificarSalida.Size = new Size(202, 55);
            B_ModificarSalida.TabIndex = 5;
            B_ModificarSalida.Text = "Aceptar (Enter)";
            B_ModificarSalida.TextAlign = ContentAlignment.MiddleRight;
            B_ModificarSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_ModificarSalida.UseVisualStyleBackColor = false;
            B_ModificarSalida.Click += B_ModificarSalida_Click;
            // 
            // V_ModificarSalidaEfectivo
            // 
            AcceptButton = B_ModificarSalida;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(712, 346);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_ModificarSalidaEfectivo";
            Text = "Modificar datos del gasto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Cancelar;
        private Button B_ModificarSalida;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private TextBox TB_Monto;
        private TextBox TB_Concepto;
        private Label label5;
        private Label label3;
    }
}