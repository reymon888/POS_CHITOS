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
            panel2 = new Panel();
            B_Cancelar = new Button();
            B_ModificarEntrada = new Button();
            TB_Monto = new TextBox();
            TB_Concepto = new TextBox();
            label5 = new Label();
            label3 = new Label();
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
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_ModificarEntrada);
            panel2.Controls.Add(TB_Monto);
            panel2.Controls.Add(TB_Concepto);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(323, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 346);
            panel2.TabIndex = 7;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(266, 239);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(152, 70);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_ModificarEntrada
            // 
            B_ModificarEntrada.AutoSize = true;
            B_ModificarEntrada.BackColor = Color.FromArgb(192, 255, 192);
            B_ModificarEntrada.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_ModificarEntrada.Image = Properties.Resources.aceptar__1_;
            B_ModificarEntrada.Location = new Point(76, 239);
            B_ModificarEntrada.Name = "B_ModificarEntrada";
            B_ModificarEntrada.Size = new Size(152, 70);
            B_ModificarEntrada.TabIndex = 5;
            B_ModificarEntrada.Text = "Aceptar (Enter)";
            B_ModificarEntrada.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarEntrada.UseVisualStyleBackColor = false;
            B_ModificarEntrada.Click += B_ModificarEntrada_Click;
            // 
            // TB_Monto
            // 
            TB_Monto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Monto.Font = new Font("Arial Rounded MT Bold", 16.2F);
            TB_Monto.Location = new Point(64, 163);
            TB_Monto.Name = "TB_Monto";
            TB_Monto.Size = new Size(354, 39);
            TB_Monto.TabIndex = 4;
            // 
            // TB_Concepto
            // 
            TB_Concepto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Concepto.Font = new Font("Arial Rounded MT Bold", 16.2F);
            TB_Concepto.Location = new Point(47, 66);
            TB_Concepto.Name = "TB_Concepto";
            TB_Concepto.Size = new Size(415, 39);
            TB_Concepto.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label5.Location = new Point(190, 128);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 5;
            label5.Text = "Monto*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label3.Location = new Point(162, 31);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 3;
            label3.Text = "Concepto*";
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
            panel1.Size = new Size(323, 346);
            panel1.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(28, 264);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 61);
            textBox5.TabIndex = 10;
            textBox5.Text = "* Llena los campos para modificar la entrada de efectivo correctamente *";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 49);
            label1.Name = "label1";
            label1.Size = new Size(309, 27);
            label1.TabIndex = 1;
            label1.Text = "Modificar Entrada Efectivo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor__2_;
            pictureBox1.Location = new Point(88, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // V_ModificarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 346);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_ModificarEntrada";
            Text = "Modificar Entrada Efectivo";
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
        private Button B_ModificarEntrada;
        private TextBox TB_Monto;
        private TextBox TB_Concepto;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private TextBox textBox5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}