namespace POS_CHITOS
{
    partial class V_MontoInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MontoInicial));
            panel1 = new Panel();
            label1 = new Label();
            B_Guardar = new Button();
            TB_MontoInicial = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(B_Guardar);
            panel1.Controls.Add(TB_MontoInicial);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 446);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 77, 128);
            label1.Location = new Point(214, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 0;
            label1.Text = "Monto inicial de caja";
            // 
            // B_Guardar
            // 
            B_Guardar.AutoSize = true;
            B_Guardar.BackColor = Color.FromArgb(26, 77, 128);
            B_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Guardar.ForeColor = SystemColors.ButtonHighlight;
            B_Guardar.Image = Properties.Resources.salvar1;
            B_Guardar.Location = new Point(214, 312);
            B_Guardar.Margin = new Padding(4, 4, 4, 4);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(321, 88);
            B_Guardar.TabIndex = 7;
            B_Guardar.Text = "Guardar";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
            // 
            // TB_MontoInicial
            // 
            TB_MontoInicial.BackColor = Color.WhiteSmoke;
            TB_MontoInicial.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TB_MontoInicial.ForeColor = Color.FromArgb(26, 77, 128);
            TB_MontoInicial.Location = new Point(100, 155);
            TB_MontoInicial.Margin = new Padding(4, 4, 4, 4);
            TB_MontoInicial.Name = "TB_MontoInicial";
            TB_MontoInicial.Size = new Size(560, 135);
            TB_MontoInicial.TabIndex = 1;
            TB_MontoInicial.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(133, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(504, 32);
            label2.TabIndex = 8;
            label2.Text = "Ingresa el efectivo con el que arrancas el día.";
            // 
            // V_MontoInicial
            // 
            AcceptButton = B_Guardar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 446);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "V_MontoInicial";
            Text = "Monto inicial";
            FormClosing += V_MontoInicial_FormClosing;
            FormClosed += V_MontoInicial_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TB_MontoInicial;
        private Button B_Guardar;
        private Label label1;
        private Label label2;
    }
}