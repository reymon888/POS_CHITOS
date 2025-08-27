namespace POS_CHITOS
{
    partial class V_ModificarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ModificarEntrada));
            panel2 = new Panel();
            B_Cancelar = new Button();
            B_Guardar = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            TB_Monto = new TextBox();
            TB_Concepto = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_Guardar);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TB_Monto);
            panel2.Controls.Add(TB_Concepto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 346);
            panel2.TabIndex = 7;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(358, 260);
            B_Cancelar.Margin = new Padding(3, 2, 3, 2);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(192, 55);
            B_Cancelar.TabIndex = 48;
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
            B_Guardar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Guardar.ForeColor = Color.White;
            B_Guardar.Image = Properties.Resources.salvar1;
            B_Guardar.Location = new Point(139, 260);
            B_Guardar.Margin = new Padding(3, 2, 3, 2);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(203, 55);
            B_Guardar.TabIndex = 47;
            B_Guardar.Text = "Aceptar (Enter)";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dinero;
            pictureBox2.Location = new Point(172, 8);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(98, 85);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 3);
            panel1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(234, 20);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 41;
            label1.Text = "Datos del Ingreso";
            // 
            // TB_Monto
            // 
            TB_Monto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Monto.BackColor = Color.WhiteSmoke;
            TB_Monto.Font = new Font("Segoe UI", 13.8F);
            TB_Monto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Monto.Location = new Point(187, 193);
            TB_Monto.Margin = new Padding(3, 2, 3, 2);
            TB_Monto.Name = "TB_Monto";
            TB_Monto.Size = new Size(312, 32);
            TB_Monto.TabIndex = 45;
            TB_Monto.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_Concepto
            // 
            TB_Concepto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Concepto.BackColor = Color.WhiteSmoke;
            TB_Concepto.Font = new Font("Segoe UI", 13.8F);
            TB_Concepto.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Concepto.Location = new Point(98, 129);
            TB_Concepto.Margin = new Padding(3, 2, 3, 2);
            TB_Concepto.Name = "TB_Concepto";
            TB_Concepto.Size = new Size(509, 32);
            TB_Concepto.TabIndex = 44;
            TB_Concepto.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(298, 167);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 42;
            label5.Text = "Monto*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(285, 90);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 43;
            label3.Text = "Concepto*";
            // 
            // V_ModificarEntrada
            // 
            AcceptButton = B_Guardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(712, 346);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_ModificarEntrada";
            Text = "Modificar Entrada Efectivo";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private TextBox TB_Monto;
        private TextBox TB_Concepto;
        private Label label5;
        private Label label3;
        private Button B_Cancelar;
        private Button B_Guardar;
    }
}