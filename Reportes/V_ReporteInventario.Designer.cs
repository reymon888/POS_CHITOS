namespace POS_CHITOS.Reportes
{
    partial class V_ReporteInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ReporteInventario));
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            TB_Stock = new TextBox();
            RB_SinStock = new RadioButton();
            RB_DebajoStock = new RadioButton();
            RB_ConStock = new RadioButton();
            CB_Categorias = new ComboBox();
            label3 = new Label();
            CB_Proveedores = new ComboBox();
            label8 = new Label();
            B_Cancelar = new Button();
            B_Guardar = new Button();
            label7 = new Label();
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
            panel3.Size = new Size(796, 88);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(89, 17);
            label2.Name = "label2";
            label2.Size = new Size(610, 46);
            label2.TabIndex = 1;
            label2.Text = "Parametros para reporte de inventario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(TB_Stock);
            panel1.Controls.Add(RB_SinStock);
            panel1.Controls.Add(RB_DebajoStock);
            panel1.Controls.Add(RB_ConStock);
            panel1.Controls.Add(CB_Categorias);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CB_Proveedores);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(B_Cancelar);
            panel1.Controls.Add(B_Guardar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 452);
            panel1.TabIndex = 2;
            // 
            // TB_Stock
            // 
            TB_Stock.Font = new Font("Segoe UI", 12F);
            TB_Stock.Location = new Point(329, 278);
            TB_Stock.Name = "TB_Stock";
            TB_Stock.Size = new Size(125, 34);
            TB_Stock.TabIndex = 39;
            // 
            // RB_SinStock
            // 
            RB_SinStock.AutoSize = true;
            RB_SinStock.Font = new Font("Segoe UI", 12F);
            RB_SinStock.Location = new Point(538, 240);
            RB_SinStock.Name = "RB_SinStock";
            RB_SinStock.Size = new Size(113, 32);
            RB_SinStock.TabIndex = 38;
            RB_SinStock.TabStop = true;
            RB_SinStock.Text = "Sin Stock";
            RB_SinStock.UseVisualStyleBackColor = true;
            // 
            // RB_DebajoStock
            // 
            RB_DebajoStock.AutoSize = true;
            RB_DebajoStock.Font = new Font("Segoe UI", 12F);
            RB_DebajoStock.Location = new Point(309, 240);
            RB_DebajoStock.Name = "RB_DebajoStock";
            RB_DebajoStock.Size = new Size(178, 32);
            RB_DebajoStock.TabIndex = 37;
            RB_DebajoStock.TabStop = true;
            RB_DebajoStock.Text = "Stock debajo de:";
            RB_DebajoStock.UseVisualStyleBackColor = true;
            RB_DebajoStock.CheckedChanged += RB_DebajoStock_CheckedChanged;
            // 
            // RB_ConStock
            // 
            RB_ConStock.AutoSize = true;
            RB_ConStock.Font = new Font("Segoe UI", 12F);
            RB_ConStock.Location = new Point(73, 240);
            RB_ConStock.Name = "RB_ConStock";
            RB_ConStock.Size = new Size(105, 32);
            RB_ConStock.TabIndex = 36;
            RB_ConStock.TabStop = true;
            RB_ConStock.Text = "En stock";
            RB_ConStock.UseVisualStyleBackColor = true;
            // 
            // CB_Categorias
            // 
            CB_Categorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Categorias.FormattingEnabled = true;
            CB_Categorias.Location = new Point(411, 148);
            CB_Categorias.Name = "CB_Categorias";
            CB_Categorias.Size = new Size(302, 36);
            CB_Categorias.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(486, 114);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 34;
            label3.Text = "Categorias";
            // 
            // CB_Proveedores
            // 
            CB_Proveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Proveedores.FormattingEnabled = true;
            CB_Proveedores.Location = new Point(55, 148);
            CB_Proveedores.Name = "CB_Proveedores";
            CB_Proveedores.Size = new Size(302, 36);
            CB_Proveedores.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(130, 114);
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
            B_Cancelar.Location = new Point(387, 356);
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
            B_Guardar.Location = new Point(211, 356);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(170, 70);
            B_Guardar.TabIndex = 30;
            B_Guardar.Text = "Guardar";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 77, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 88);
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
            // V_ReporteInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 452);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_ReporteInventario";
            Text = "Parametros para generar reporte de inventario";
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
        private Label label7;
        private Panel panel2;
        private Label label1;
        private ComboBox CB_Categorias;
        private Label label3;
        private RadioButton RB_SinStock;
        private RadioButton RB_DebajoStock;
        private RadioButton RB_ConStock;
        private TextBox TB_Stock;
    }
}