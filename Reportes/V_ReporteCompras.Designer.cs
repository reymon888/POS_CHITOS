namespace POS_CHITOS.Reportes
{
    partial class V_ReporteCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ReporteCompras));
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            CB_Proveedores = new ComboBox();
            label8 = new Label();
            B_Cancelar = new Button();
            B_Guardar = new Button();
            check_detallescompras = new CheckBox();
            label7 = new Label();
            check_comprascanceladas = new CheckBox();
            CB_Usuarios = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            DTP_Hasta = new DateTimePicker();
            DTP_Desde = new DateTimePicker();
            panel2 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 77, 128);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(829, 88);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 17);
            label2.Name = "label2";
            label2.Size = new Size(586, 46);
            label2.TabIndex = 1;
            label2.Text = "Parametros para reporte de compras";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(CB_Proveedores);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(B_Cancelar);
            panel1.Controls.Add(B_Guardar);
            panel1.Controls.Add(check_detallescompras);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(check_comprascanceladas);
            panel1.Controls.Add(CB_Usuarios);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DTP_Hasta);
            panel1.Controls.Add(DTP_Desde);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 551);
            panel1.TabIndex = 1;
            // 
            // CB_Proveedores
            // 
            CB_Proveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Proveedores.FormattingEnabled = true;
            CB_Proveedores.Location = new Point(490, 266);
            CB_Proveedores.Name = "CB_Proveedores";
            CB_Proveedores.Size = new Size(302, 36);
            CB_Proveedores.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(565, 232);
            label8.Name = "label8";
            label8.Size = new Size(145, 31);
            label8.TabIndex = 32;
            label8.Text = "Proveedores";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.FlatAppearance.BorderSize = 0;
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(411, 447);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(170, 70);
            B_Cancelar.TabIndex = 31;
            B_Cancelar.Text = "  Cancelar ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_Guardar
            // 
            B_Guardar.AutoSize = true;
            B_Guardar.BackColor = Color.FromArgb(26, 77, 128);
            B_Guardar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Guardar.ForeColor = SystemColors.ButtonHighlight;
            B_Guardar.Image = Properties.Resources.salvar1;
            B_Guardar.Location = new Point(230, 447);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(170, 70);
            B_Guardar.TabIndex = 30;
            B_Guardar.Text = "Guardar";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
            // 
            // check_detallescompras
            // 
            check_detallescompras.AutoSize = true;
            check_detallescompras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_detallescompras.Location = new Point(12, 329);
            check_detallescompras.Name = "check_detallescompras";
            check_detallescompras.Size = new Size(308, 32);
            check_detallescompras.TabIndex = 29;
            check_detallescompras.Text = "Incluir detalles de las compras";
            check_detallescompras.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 304);
            label7.Name = "label7";
            label7.Size = new Size(0, 31);
            label7.TabIndex = 28;
            // 
            // check_comprascanceladas
            // 
            check_comprascanceladas.AutoSize = true;
            check_comprascanceladas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_comprascanceladas.Location = new Point(498, 329);
            check_comprascanceladas.Name = "check_comprascanceladas";
            check_comprascanceladas.Size = new Size(282, 32);
            check_comprascanceladas.TabIndex = 25;
            check_comprascanceladas.Text = "Incluir Compras Canceladas";
            check_comprascanceladas.UseVisualStyleBackColor = true;
            // 
            // CB_Usuarios
            // 
            CB_Usuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Usuarios.FormattingEnabled = true;
            CB_Usuarios.Location = new Point(18, 266);
            CB_Usuarios.Name = "CB_Usuarios";
            CB_Usuarios.Size = new Size(302, 36);
            CB_Usuarios.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(119, 232);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 23;
            label6.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(318, 93);
            label5.Name = "label5";
            label5.Size = new Size(175, 31);
            label5.TabIndex = 2;
            label5.Text = "Rango de fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(602, 136);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 22;
            label3.Text = "Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(136, 136);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 21;
            label4.Text = "Desde";
            // 
            // DTP_Hasta
            // 
            DTP_Hasta.Font = new Font("Segoe UI", 12F);
            DTP_Hasta.Location = new Point(450, 167);
            DTP_Hasta.Name = "DTP_Hasta";
            DTP_Hasta.Size = new Size(360, 34);
            DTP_Hasta.TabIndex = 20;
            // 
            // DTP_Desde
            // 
            DTP_Desde.Font = new Font("Segoe UI", 12F);
            DTP_Desde.Location = new Point(12, 167);
            DTP_Desde.Name = "DTP_Desde";
            DTP_Desde.Size = new Size(360, 34);
            DTP_Desde.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 77, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 88);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(601, 46);
            label1.TabIndex = 1;
            label1.Text = "Caracteristicas para reporte de ventas";
            // 
            // V_ReporteCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 551);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_ReporteCompras";
            Text = "Parametros para generar reporte de compras";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private ComboBox CB_Proveedores;
        private Label label8;
        private Button B_Cancelar;
        private Button B_Guardar;
        private CheckBox check_detallescompras;
        private Label label7;
        private CheckBox check_comprascanceladas;
        private ComboBox CB_Usuarios;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private DateTimePicker DTP_Hasta;
        private DateTimePicker DTP_Desde;
        private Panel panel2;
        private Label label1;
    }
}