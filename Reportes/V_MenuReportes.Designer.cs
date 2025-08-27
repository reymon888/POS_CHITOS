namespace POS_CHITOS.Reportes
{
    partial class V_MenuReportes
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
            B_NuevaVenta = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            B_ReporteInventario = new Button();
            B_ReporteGastos = new Button();
            B_ReporteIngresos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // B_NuevaVenta
            // 
            B_NuevaVenta.Anchor = AnchorStyles.Top;
            B_NuevaVenta.AutoSize = true;
            B_NuevaVenta.BackColor = SystemColors.ControlLightLight;
            B_NuevaVenta.FlatAppearance.BorderSize = 0;
            B_NuevaVenta.FlatStyle = FlatStyle.Flat;
            B_NuevaVenta.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_NuevaVenta.ForeColor = SystemColors.ActiveCaptionText;
            B_NuevaVenta.Image = Properties.Resources.punto_de_venta__1_;
            B_NuevaVenta.Location = new Point(426, 220);
            B_NuevaVenta.Name = "B_NuevaVenta";
            B_NuevaVenta.Size = new Size(207, 142);
            B_NuevaVenta.TabIndex = 2;
            B_NuevaVenta.Text = "Ventas (Ctrl + V)";
            B_NuevaVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_NuevaVenta.UseVisualStyleBackColor = false;
            B_NuevaVenta.Click += B_NuevaVenta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 88);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(434, 22);
            label1.Name = "label1";
            label1.Size = new Size(641, 46);
            label1.TabIndex = 1;
            label1.Text = "Selecciona una categoria para el reporte";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.carrito_de_compras;
            button1.Location = new Point(639, 220);
            button1.Name = "button1";
            button1.Size = new Size(218, 142);
            button1.TabIndex = 14;
            button1.Text = "Compras (Ctrl + C)";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // B_ReporteInventario
            // 
            B_ReporteInventario.Anchor = AnchorStyles.Top;
            B_ReporteInventario.AutoSize = true;
            B_ReporteInventario.BackColor = SystemColors.ControlLightLight;
            B_ReporteInventario.FlatAppearance.BorderSize = 0;
            B_ReporteInventario.FlatStyle = FlatStyle.Flat;
            B_ReporteInventario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_ReporteInventario.ForeColor = SystemColors.ActiveCaptionText;
            B_ReporteInventario.Image = Properties.Resources.aceite_de_motor;
            B_ReporteInventario.Location = new Point(863, 220);
            B_ReporteInventario.Name = "B_ReporteInventario";
            B_ReporteInventario.Size = new Size(230, 142);
            B_ReporteInventario.TabIndex = 15;
            B_ReporteInventario.Text = "Productos (Ctrl + P)";
            B_ReporteInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ReporteInventario.UseVisualStyleBackColor = false;
            B_ReporteInventario.Click += B_ReporteInventario_Click;
            // 
            // B_ReporteGastos
            // 
            B_ReporteGastos.Anchor = AnchorStyles.Top;
            B_ReporteGastos.AutoSize = true;
            B_ReporteGastos.BackColor = SystemColors.ControlLightLight;
            B_ReporteGastos.FlatAppearance.BorderSize = 0;
            B_ReporteGastos.FlatStyle = FlatStyle.Flat;
            B_ReporteGastos.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_ReporteGastos.ForeColor = SystemColors.ActiveCaptionText;
            B_ReporteGastos.Image = Properties.Resources.salir;
            B_ReporteGastos.Location = new Point(639, 368);
            B_ReporteGastos.Name = "B_ReporteGastos";
            B_ReporteGastos.Size = new Size(218, 142);
            B_ReporteGastos.TabIndex = 17;
            B_ReporteGastos.Text = "Gastos (Ctrl + G)";
            B_ReporteGastos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ReporteGastos.UseVisualStyleBackColor = false;
            B_ReporteGastos.Click += B_ReporteGastos_Click;
            // 
            // B_ReporteIngresos
            // 
            B_ReporteIngresos.Anchor = AnchorStyles.Top;
            B_ReporteIngresos.AutoSize = true;
            B_ReporteIngresos.BackColor = SystemColors.ControlLightLight;
            B_ReporteIngresos.FlatAppearance.BorderSize = 0;
            B_ReporteIngresos.FlatStyle = FlatStyle.Flat;
            B_ReporteIngresos.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_ReporteIngresos.ForeColor = SystemColors.ActiveCaptionText;
            B_ReporteIngresos.Image = Properties.Resources.dinero;
            B_ReporteIngresos.Location = new Point(426, 368);
            B_ReporteIngresos.Name = "B_ReporteIngresos";
            B_ReporteIngresos.Size = new Size(207, 142);
            B_ReporteIngresos.TabIndex = 16;
            B_ReporteIngresos.Text = "Ingresos (Ctrl + I)";
            B_ReporteIngresos.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ReporteIngresos.UseVisualStyleBackColor = false;
            B_ReporteIngresos.Click += B_ReporteIngresos_Click;
            // 
            // V_MenuReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1472, 668);
            Controls.Add(B_ReporteGastos);
            Controls.Add(B_ReporteIngresos);
            Controls.Add(B_ReporteInventario);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(B_NuevaVenta);
            Name = "V_MenuReportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B_NuevaVenta;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button B_ReporteInventario;
        private Button B_ReporteGastos;
        private Button B_ReporteIngresos;
    }
}