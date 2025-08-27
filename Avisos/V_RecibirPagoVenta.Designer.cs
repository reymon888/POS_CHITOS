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
            pCredito = new Panel();
            panel6 = new Panel();
            CB_TipoAnticipo = new ComboBox();
            dtp_fechacredito = new DateTimePicker();
            TB_Abono = new TextBox();
            TB_Cliente = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            rb_credito = new RadioButton();
            rb_contado = new RadioButton();
            label1 = new Label();
            B_Confirmar = new Button();
            TB_TotalCobrar = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            pContado.SuspendLayout();
            pCredito.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pContado);
            panel2.Controls.Add(pCredito);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(rb_credito);
            panel2.Controls.Add(rb_contado);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(B_Confirmar);
            panel2.Controls.Add(TB_TotalCobrar);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 861);
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
            panel4.Name = "panel4";
            panel4.Size = new Size(1181, 79);
            panel4.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(13, 15);
            label12.Name = "label12";
            label12.Size = new Size(469, 46);
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
            B_Cancelar.Location = new Point(1081, 12);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(88, 54);
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
            pContado.Location = new Point(0, 438);
            pContado.Name = "pContado";
            pContado.Size = new Size(569, 375);
            pContado.TabIndex = 33;
            pContado.Paint += pContado_Paint;
            // 
            // CB_TipoPago
            // 
            CB_TipoPago.BackColor = Color.WhiteSmoke;
            CB_TipoPago.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TipoPago.FormattingEnabled = true;
            CB_TipoPago.Location = new Point(23, 104);
            CB_TipoPago.Name = "CB_TipoPago";
            CB_TipoPago.Size = new Size(289, 45);
            CB_TipoPago.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 77, 128);
            panel5.Enabled = false;
            panel5.ForeColor = SystemColors.ButtonFace;
            panel5.Location = new Point(20, 228);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 3);
            panel5.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(26, 77, 128);
            panel8.Enabled = false;
            panel8.ForeColor = SystemColors.ButtonFace;
            panel8.Location = new Point(23, 67);
            panel8.Name = "panel8";
            panel8.Size = new Size(289, 3);
            panel8.TabIndex = 39;
            // 
            // TB_Cambio
            // 
            TB_Cambio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cambio.BackColor = Color.WhiteSmoke;
            TB_Cambio.Enabled = false;
            TB_Cambio.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cambio.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Cambio.Location = new Point(196, 304);
            TB_Cambio.Name = "TB_Cambio";
            TB_Cambio.Size = new Size(254, 43);
            TB_Cambio.TabIndex = 37;
            TB_Cambio.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(34, 304);
            label6.Name = "label6";
            label6.Size = new Size(117, 38);
            label6.TabIndex = 36;
            label6.Text = "Cambio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(37, 240);
            label4.Name = "label4";
            label4.Size = new Size(97, 38);
            label4.TabIndex = 35;
            label4.Text = "Recibí:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 185);
            label5.Name = "label5";
            label5.Size = new Size(243, 46);
            label5.TabIndex = 34;
            label5.Text = "Datos de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 20);
            label2.Name = "label2";
            label2.Size = new Size(275, 46);
            label2.TabIndex = 33;
            label2.Text = "Metodo de pago";
            // 
            // TB_PagoRecibido
            // 
            TB_PagoRecibido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PagoRecibido.BackColor = Color.WhiteSmoke;
            TB_PagoRecibido.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_PagoRecibido.ForeColor = Color.FromArgb(26, 77, 128);
            TB_PagoRecibido.Location = new Point(196, 240);
            TB_PagoRecibido.Name = "TB_PagoRecibido";
            TB_PagoRecibido.Size = new Size(254, 43);
            TB_PagoRecibido.TabIndex = 32;
            TB_PagoRecibido.TextAlign = HorizontalAlignment.Center;
            // 
            // pCredito
            // 
            pCredito.Controls.Add(panel6);
            pCredito.Controls.Add(CB_TipoAnticipo);
            pCredito.Controls.Add(dtp_fechacredito);
            pCredito.Controls.Add(TB_Abono);
            pCredito.Controls.Add(TB_Cliente);
            pCredito.Controls.Add(label11);
            pCredito.Controls.Add(label10);
            pCredito.Controls.Add(label9);
            pCredito.Controls.Add(label8);
            pCredito.Controls.Add(label7);
            pCredito.Location = new Point(595, 268);
            pCredito.Name = "pCredito";
            pCredito.Size = new Size(552, 430);
            pCredito.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(26, 77, 128);
            panel6.Enabled = false;
            panel6.ForeColor = SystemColors.ButtonFace;
            panel6.Location = new Point(244, 78);
            panel6.Name = "panel6";
            panel6.Size = new Size(289, 3);
            panel6.TabIndex = 39;
            // 
            // CB_TipoAnticipo
            // 
            CB_TipoAnticipo.BackColor = Color.WhiteSmoke;
            CB_TipoAnticipo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_TipoAnticipo.FormattingEnabled = true;
            CB_TipoAnticipo.Location = new Point(146, 255);
            CB_TipoAnticipo.Name = "CB_TipoAnticipo";
            CB_TipoAnticipo.Size = new Size(387, 45);
            CB_TipoAnticipo.TabIndex = 38;
            // 
            // dtp_fechacredito
            // 
            dtp_fechacredito.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_fechacredito.Format = DateTimePickerFormat.Short;
            dtp_fechacredito.Location = new Point(146, 189);
            dtp_fechacredito.Name = "dtp_fechacredito";
            dtp_fechacredito.Size = new Size(387, 43);
            dtp_fechacredito.TabIndex = 37;
            // 
            // TB_Abono
            // 
            TB_Abono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Abono.BackColor = Color.WhiteSmoke;
            TB_Abono.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Abono.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Abono.Location = new Point(146, 315);
            TB_Abono.Name = "TB_Abono";
            TB_Abono.Size = new Size(254, 43);
            TB_Abono.TabIndex = 36;
            TB_Abono.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_Cliente
            // 
            TB_Cliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cliente.BackColor = Color.WhiteSmoke;
            TB_Cliente.Enabled = false;
            TB_Cliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Cliente.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Cliente.Location = new Point(146, 118);
            TB_Cliente.Name = "TB_Cliente";
            TB_Cliente.Size = new Size(387, 43);
            TB_Cliente.TabIndex = 35;
            TB_Cliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F);
            label11.Location = new Point(108, 315);
            label11.Name = "label11";
            label11.Size = new Size(32, 38);
            label11.TabIndex = 34;
            label11.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F);
            label10.Location = new Point(21, 258);
            label10.Name = "label10";
            label10.Size = new Size(119, 38);
            label10.TabIndex = 33;
            label10.Text = "Anticipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F);
            label9.Location = new Point(43, 189);
            label9.Name = "label9";
            label9.Size = new Size(97, 38);
            label9.TabIndex = 32;
            label9.Text = "Vence:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F);
            label8.Location = new Point(31, 118);
            label8.Name = "label8";
            label8.Size = new Size(109, 38);
            label8.TabIndex = 31;
            label8.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(260, 35);
            label7.Name = "label7";
            label7.Size = new Size(273, 46);
            label7.TabIndex = 30;
            label7.Text = "Datos de crédito";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(26, 77, 128);
            panel7.Enabled = false;
            panel7.ForeColor = SystemColors.ButtonFace;
            panel7.Location = new Point(449, 169);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 3);
            panel7.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 77, 128);
            panel3.Enabled = false;
            panel3.ForeColor = SystemColors.ButtonFace;
            panel3.Location = new Point(36, 325);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 3);
            panel3.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Enabled = false;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(575, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 450);
            panel1.TabIndex = 26;
            // 
            // rb_credito
            // 
            rb_credito.AutoSize = true;
            rb_credito.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_credito.Location = new Point(74, 390);
            rb_credito.Name = "rb_credito";
            rb_credito.Size = new Size(128, 42);
            rb_credito.TabIndex = 11;
            rb_credito.TabStop = true;
            rb_credito.Text = "Crédito";
            rb_credito.UseVisualStyleBackColor = true;
            rb_credito.CheckedChanged += rb_credito_CheckedChanged;
            // 
            // rb_contado
            // 
            rb_contado.AutoSize = true;
            rb_contado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_contado.Location = new Point(74, 341);
            rb_contado.Name = "rb_contado";
            rb_contado.Size = new Size(142, 42);
            rb_contado.TabIndex = 10;
            rb_contado.TabStop = true;
            rb_contado.Text = "Contado";
            rb_contado.UseVisualStyleBackColor = true;
            rb_contado.CheckedChanged += rb_contado_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 282);
            label1.Name = "label1";
            label1.Size = new Size(229, 46);
            label1.TabIndex = 4;
            label1.Text = "Tipo de venta";
            label1.Click += label1_Click;
            // 
            // B_Confirmar
            // 
            B_Confirmar.AutoSize = true;
            B_Confirmar.BackColor = Color.FromArgb(26, 77, 128);
            B_Confirmar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            B_Confirmar.ForeColor = SystemColors.Control;
            B_Confirmar.Location = new Point(766, 718);
            B_Confirmar.Name = "B_Confirmar";
            B_Confirmar.Size = new Size(256, 83);
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
            TB_TotalCobrar.Location = new Point(371, 178);
            TB_TotalCobrar.Name = "TB_TotalCobrar";
            TB_TotalCobrar.ReadOnly = true;
            TB_TotalCobrar.Size = new Size(436, 78);
            TB_TotalCobrar.TabIndex = 0;
            TB_TotalCobrar.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            label3.Location = new Point(491, 85);
            label3.Name = "label3";
            label3.Size = new Size(206, 81);
            label3.TabIndex = 0;
            label3.Text = "TOTAL";
            // 
            // V_RecibirPagoVenta
            // 
            AcceptButton = B_Confirmar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(1181, 861);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_RecibirPagoVenta";
            ShowInTaskbar = false;
            Text = "Recibir Pago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pContado.ResumeLayout(false);
            pContado.PerformLayout();
            pCredito.ResumeLayout(false);
            pCredito.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Cancelar;
        private Button B_Confirmar;
        private TextBox TB_TotalCobrar;
        private Label label3;
        private Label label1;
        private RadioButton rb_credito;
        private RadioButton rb_contado;
        private Panel panel3;
        private Panel panel1;
        private Panel panel7;
        private Panel pCredito;
        private Panel panel6;
        private ComboBox CB_TipoAnticipo;
        private DateTimePicker dtp_fechacredito;
        private TextBox TB_Abono;
        private TextBox TB_Cliente;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
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