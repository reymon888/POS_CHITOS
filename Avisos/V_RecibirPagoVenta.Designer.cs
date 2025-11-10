namespace POS_CHITOS
{
    partial class V_RecibirPagoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RecibirPagoVenta));
            panel2 = new Panel();
            panel4 = new Panel();
            label12 = new Label();
            B_Cancelar = new Button();
            pContado = new Panel();
            CB_TipoPago = new ComboBox();
            panel5 = new Panel();
            panel8 = new Panel();
            TB_Cambio = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            TB_PagoRecibido = new TextBox();
            panel7 = new Panel();
            B_Confirmar = new Button();
            TB_TotalCobrar = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            pContado.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pContado);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(B_Confirmar);
            panel2.Controls.Add(TB_TotalCobrar);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 640);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 77, 128);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(B_Cancelar);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = SystemColors.ButtonFace;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(811, 59);
            panel4.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(11, 11);
            label12.Name = "label12";
            label12.Size = new Size(371, 37);
            label12.TabIndex = 34;
            label12.Text = "Finalizar Venta / Recibir Pago";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(26, 77, 128);
            B_Cancelar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            B_Cancelar.ForeColor = Color.FromArgb(26, 77, 128);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(946, 9);
            B_Cancelar.Margin = new Padding(3, 2, 3, 2);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(77, 40);
            B_Cancelar.TabIndex = 3;
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // pContado
            // 
            pContado.Controls.Add(CB_TipoPago);
            pContado.Controls.Add(panel5);
            pContado.Controls.Add(panel8);
            pContado.Controls.Add(TB_Cambio);
            pContado.Controls.Add(label6);
            pContado.Controls.Add(label4);
            pContado.Controls.Add(label5);
            pContado.Controls.Add(label2);
            pContado.Controls.Add(TB_PagoRecibido);
            pContado.Location = new Point(55, 221);
            pContado.Margin = new Padding(3, 2, 3, 2);
            pContado.Name = "pContado";
            pContado.Size = new Size(697, 309);
            pContado.TabIndex = 33;
            pContado.Paint += pContado_Paint;
            // 
            // CB_TipoPago
            // 
            CB_TipoPago.BackColor = Color.WhiteSmoke;
            CB_TipoPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TipoPago.FormattingEnabled = true;
            CB_TipoPago.Location = new Point(168, 78);
            CB_TipoPago.Margin = new Padding(3, 2, 3, 2);
            CB_TipoPago.Name = "CB_TipoPago";
            CB_TipoPago.Size = new Size(371, 38);
            CB_TipoPago.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 77, 128);
            panel5.Enabled = false;
            panel5.ForeColor = SystemColors.ButtonFace;
            panel5.Location = new Point(223, 164);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 2);
            panel5.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(26, 77, 128);
            panel8.Enabled = false;
            panel8.ForeColor = SystemColors.ButtonFace;
            panel8.Location = new Point(223, 55);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(253, 2);
            panel8.TabIndex = 39;
            // 
            // TB_Cambio
            // 
            TB_Cambio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cambio.BackColor = Color.WhiteSmoke;
            TB_Cambio.Enabled = false;
            TB_Cambio.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cambio.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Cambio.Location = new Point(292, 225);
            TB_Cambio.Margin = new Padding(3, 2, 3, 2);
            TB_Cambio.Name = "TB_Cambio";
            TB_Cambio.Size = new Size(223, 36);
            TB_Cambio.TabIndex = 37;
            TB_Cambio.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(150, 231);
            label6.Name = "label6";
            label6.Size = new Size(93, 30);
            label6.TabIndex = 36;
            label6.Text = "Cambio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(168, 186);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 35;
            label4.Text = "Recibí:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 129);
            label5.Name = "label5";
            label5.Size = new Size(194, 37);
            label5.TabIndex = 34;
            label5.Text = "Datos de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 20);
            label2.Name = "label2";
            label2.Size = new Size(220, 37);
            label2.TabIndex = 33;
            label2.Text = "Metodo de pago";
            // 
            // TB_PagoRecibido
            // 
            TB_PagoRecibido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PagoRecibido.BackColor = Color.WhiteSmoke;
            TB_PagoRecibido.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_PagoRecibido.ForeColor = Color.FromArgb(26, 77, 128);
            TB_PagoRecibido.Location = new Point(292, 183);
            TB_PagoRecibido.Margin = new Padding(3, 2, 3, 2);
            TB_PagoRecibido.Name = "TB_PagoRecibido";
            TB_PagoRecibido.Size = new Size(223, 36);
            TB_PagoRecibido.TabIndex = 32;
            TB_PagoRecibido.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(26, 77, 128);
            panel7.Enabled = false;
            panel7.ForeColor = SystemColors.ButtonFace;
            panel7.Location = new Point(257, 124);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(253, 2);
            panel7.TabIndex = 30;
            // 
            // B_Confirmar
            // 
            B_Confirmar.AutoSize = true;
            B_Confirmar.BackColor = Color.FromArgb(26, 77, 128);
            B_Confirmar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            B_Confirmar.ForeColor = SystemColors.Control;
            B_Confirmar.Location = new Point(257, 543);
            B_Confirmar.Margin = new Padding(3, 2, 3, 2);
            B_Confirmar.Name = "B_Confirmar";
            B_Confirmar.Size = new Size(253, 62);
            B_Confirmar.TabIndex = 2;
            B_Confirmar.Text = "Aceptar (Enter)";
            B_Confirmar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Confirmar.UseVisualStyleBackColor = false;
            B_Confirmar.Click += B_Confirmar_Click;
            // 
            // TB_TotalCobrar
            // 
            TB_TotalCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_TotalCobrar.BackColor = Color.WhiteSmoke;
            TB_TotalCobrar.Enabled = false;
            TB_TotalCobrar.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_TotalCobrar.ForeColor = Color.FromArgb(26, 77, 128);
            TB_TotalCobrar.Location = new Point(188, 130);
            TB_TotalCobrar.Margin = new Padding(3, 2, 3, 2);
            TB_TotalCobrar.Name = "TB_TotalCobrar";
            TB_TotalCobrar.ReadOnly = true;
            TB_TotalCobrar.Size = new Size(382, 64);
            TB_TotalCobrar.TabIndex = 0;
            TB_TotalCobrar.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            label3.Location = new Point(294, 61);
            label3.Name = "label3";
            label3.Size = new Size(164, 65);
            label3.TabIndex = 0;
            label3.Text = "TOTAL";
            // 
            // V_RecibirPagoVenta
            // 
            AcceptButton = B_Confirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(811, 640);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_RecibirPagoVenta";
            ShowInTaskbar = false;
            Text = "Recibir Pago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pContado.ResumeLayout(false);
            pContado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Cancelar;
        private Button B_Confirmar;
        private TextBox TB_TotalCobrar;
        private Label label3;
        private Panel panel7;
        private Panel pContado;
        private ComboBox CB_TipoPago;
        private Panel panel5;
        private Panel panel8;
        private TextBox TB_Cambio;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label2;
        private TextBox TB_PagoRecibido;
        private Panel panel4;
        private Label label12;
    }
}