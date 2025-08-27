namespace POS_CHITOS.Ventas
{
    partial class V_AgregarProductoVario
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
            B_OK = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            TB_Estante = new TextBox();
            B_Cancelar = new Button();
            TB_DescripcionProducto = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(B_OK);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TB_Estante);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(TB_DescripcionProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 365);
            panel2.TabIndex = 6;
            // 
            // B_OK
            // 
            B_OK.AutoSize = true;
            B_OK.BackColor = Color.FromArgb(26, 77, 128);
            B_OK.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_OK.ForeColor = SystemColors.ButtonHighlight;
            B_OK.Image = Properties.Resources.salvar1;
            B_OK.Location = new Point(161, 253);
            B_OK.Name = "B_OK";
            B_OK.Size = new Size(191, 70);
            B_OK.TabIndex = 13;
            B_OK.Text = "Guardar";
            B_OK.TextAlign = ContentAlignment.MiddleRight;
            B_OK.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_OK.UseVisualStyleBackColor = false;
            B_OK.Click += B_OK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 88);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(181, 17);
            label1.Name = "label1";
            label1.Size = new Size(348, 46);
            label1.TabIndex = 1;
            label1.Text = "Datos Producto Vario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(216, 125);
            label7.Name = "label7";
            label7.Size = new Size(299, 31);
            label7.TabIndex = 0;
            label7.Text = "Descripcion Producto Vario";
            // 
            // TB_Estante
            // 
            TB_Estante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Estante.Font = new Font("Segoe UI", 13.8F);
            TB_Estante.Location = new Point(2183, 219);
            TB_Estante.Name = "TB_Estante";
            TB_Estante.Size = new Size(259, 38);
            TB_Estante.TabIndex = 4;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.FlatAppearance.BorderSize = 0;
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(358, 253);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(191, 70);
            B_Cancelar.TabIndex = 9;
            B_Cancelar.Text = "  Cancelar ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // TB_DescripcionProducto
            // 
            TB_DescripcionProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_DescripcionProducto.Font = new Font("Segoe UI", 13.8F);
            TB_DescripcionProducto.Location = new Point(52, 174);
            TB_DescripcionProducto.Name = "TB_DescripcionProducto";
            TB_DescripcionProducto.Size = new Size(661, 38);
            TB_DescripcionProducto.TabIndex = 2;
            // 
            // V_AgregarProductoVario
            // 
            AcceptButton = B_OK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(768, 365);
            Controls.Add(panel2);
            Name = "V_AgregarProductoVario";
            Text = "Agregar Producto Vario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_OK;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private TextBox TB_Estante;
        private Button B_Cancelar;
        private TextBox TB_DescripcionProducto;
    }
}