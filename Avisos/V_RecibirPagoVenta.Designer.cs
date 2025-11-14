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
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 965);
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
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1159, 98);
            panel4.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(16, 18);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(549, 54);
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
            B_Cancelar.Location = new Point(1351, 15);
            B_Cancelar.Margin = new Padding(4, 3, 4, 3);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(110, 67);
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
            pContado.Location = new Point(79, 339);
            pContado.Margin = new Padding(4, 3, 4, 3);
            pContado.Name = "pContado";
            pContado.Size = new Size(996, 463);
            pContado.TabIndex = 33;
            pContado.Paint += pContado_Paint;
            // 
            // CB_TipoPago
            // 
            CB_TipoPago.BackColor = Color.WhiteSmoke;
            CB_TipoPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TipoPago.FormattingEnabled = true;
            CB_TipoPago.Location = new Point(240, 130);
            CB_TipoPago.Margin = new Padding(4, 3, 4, 3);
            CB_TipoPago.Name = "CB_TipoPago";
            CB_TipoPago.Size = new Size(528, 53);
            CB_TipoPago.TabIndex = 40;
            CB_TipoPago.SelectedIndexChanged += CB_TipoPago_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 77, 128);
            panel5.Enabled = false;
            panel5.ForeColor = SystemColors.ButtonFace;
            panel5.Location = new Point(319, 273);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(361, 3);
            panel5.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(26, 77, 128);
            panel8.Enabled = false;
            panel8.ForeColor = SystemColors.ButtonFace;
            panel8.Location = new Point(319, 92);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(361, 3);
            panel8.TabIndex = 39;
            // 
            // TB_Cambio
            // 
            TB_Cambio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cambio.BackColor = Color.WhiteSmoke;
            TB_Cambio.Enabled = false;
            TB_Cambio.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cambio.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Cambio.Location = new Point(417, 375);
            TB_Cambio.Margin = new Padding(4, 3, 4, 3);
            TB_Cambio.Name = "TB_Cambio";
            TB_Cambio.Size = new Size(317, 51);
            TB_Cambio.TabIndex = 37;
            TB_Cambio.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(214, 385);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 45);
            label6.TabIndex = 36;
            label6.Text = "Cambio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(240, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 45);
            label4.TabIndex = 35;
            label4.Text = "Recibí:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(288, 54);
            label5.TabIndex = 34;
            label5.Text = "Datos de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 54);
            label2.TabIndex = 33;
            label2.Text = "Metodo de pago";
            // 
            // TB_PagoRecibido
            // 
            TB_PagoRecibido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PagoRecibido.BackColor = Color.WhiteSmoke;
            TB_PagoRecibido.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_PagoRecibido.ForeColor = Color.FromArgb(26, 77, 128);
            TB_PagoRecibido.Location = new Point(417, 305);
            TB_PagoRecibido.Margin = new Padding(4, 3, 4, 3);
            TB_PagoRecibido.Name = "TB_PagoRecibido";
            TB_PagoRecibido.Size = new Size(317, 51);
            TB_PagoRecibido.TabIndex = 32;
            TB_PagoRecibido.TextAlign = HorizontalAlignment.Center;
            TB_PagoRecibido.TextChanged += TB_PagoRecibido_TextChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(26, 77, 128);
            panel7.Enabled = false;
            panel7.ForeColor = SystemColors.ButtonFace;
            panel7.Location = new Point(367, 207);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(361, 3);
            panel7.TabIndex = 30;
            // 
            // B_Confirmar
            // 
            B_Confirmar.AutoSize = true;
            B_Confirmar.BackColor = Color.FromArgb(26, 77, 128);
            B_Confirmar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            B_Confirmar.ForeColor = SystemColors.Control;
            B_Confirmar.Location = new Point(393, 817);
            B_Confirmar.Margin = new Padding(4, 3, 4, 3);
            B_Confirmar.Name = "B_Confirmar";
            B_Confirmar.Size = new Size(366, 103);
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
            TB_TotalCobrar.Location = new Point(269, 216);
            TB_TotalCobrar.Margin = new Padding(4, 3, 4, 3);
            TB_TotalCobrar.Name = "TB_TotalCobrar";
            TB_TotalCobrar.ReadOnly = true;
            TB_TotalCobrar.Size = new Size(544, 92);
            TB_TotalCobrar.TabIndex = 0;
            TB_TotalCobrar.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            label3.Location = new Point(420, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 96);
            label3.TabIndex = 0;
            label3.Text = "TOTAL";
            // 
            // V_RecibirPagoVenta
            // 
            AcceptButton = B_Confirmar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(1159, 965);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
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