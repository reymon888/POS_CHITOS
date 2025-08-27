namespace POS_CHITOS.Categorias
{
    partial class V_AgregarCategoriaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarCategoriaInventario));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            B_GuardarCategoria = new Button();
            label7 = new Label();
            TB_Estante = new TextBox();
            B_Cancelar = new Button();
            TB_NombreCategoria = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(B_GuardarCategoria);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TB_Estante);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(TB_NombreCategoria);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 364);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.etiqueta__1_;
            pictureBox2.Location = new Point(137, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(66, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 4);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(223, 16);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 17;
            label1.Text = "Nueva Categoria";
            // 
            // B_GuardarCategoria
            // 
            B_GuardarCategoria.AutoSize = true;
            B_GuardarCategoria.BackColor = Color.FromArgb(26, 77, 128);
            B_GuardarCategoria.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_GuardarCategoria.ForeColor = SystemColors.ButtonHighlight;
            B_GuardarCategoria.Image = Properties.Resources.salvar1;
            B_GuardarCategoria.Location = new Point(160, 273);
            B_GuardarCategoria.Name = "B_GuardarCategoria";
            B_GuardarCategoria.Size = new Size(191, 70);
            B_GuardarCategoria.TabIndex = 13;
            B_GuardarCategoria.Text = "Guardar";
            B_GuardarCategoria.TextAlign = ContentAlignment.MiddleRight;
            B_GuardarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_GuardarCategoria.UseVisualStyleBackColor = false;
            B_GuardarCategoria.Click += B_GuardarCategoria_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(237, 150);
            label7.Name = "label7";
            label7.Size = new Size(208, 31);
            label7.TabIndex = 0;
            label7.Text = "Nombre Categoria";
            // 
            // TB_Estante
            // 
            TB_Estante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Estante.Font = new Font("Segoe UI", 13.8F);
            TB_Estante.Location = new Point(1047, 219);
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
            B_Cancelar.Location = new Point(357, 273);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(191, 70);
            B_Cancelar.TabIndex = 9;
            B_Cancelar.Text = "  Cancelar ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // TB_NombreCategoria
            // 
            TB_NombreCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_NombreCategoria.BackColor = Color.WhiteSmoke;
            TB_NombreCategoria.Font = new Font("Segoe UI", 13.8F);
            TB_NombreCategoria.ForeColor = Color.FromArgb(26, 77, 128);
            TB_NombreCategoria.Location = new Point(35, 199);
            TB_NombreCategoria.Name = "TB_NombreCategoria";
            TB_NombreCategoria.Size = new Size(634, 38);
            TB_NombreCategoria.TabIndex = 2;
            TB_NombreCategoria.TextAlign = HorizontalAlignment.Center;
            TB_NombreCategoria.KeyDown += TB_NombreCategoria_KeyDown;
            // 
            // V_AgregarCategoriaInventario
            // 
            AcceptButton = B_GuardarCategoria;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(706, 364);
            Controls.Add(panel2);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_AgregarCategoriaInventario";
            Text = "  Agregar Nueva Categoria";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button B_AgregarCategoria;
        private ComboBox CB_Categoria;
        private Label label7;
        private TextBox TB_Estante;
        private Label label6;
        private Button B_Cancelar;
        private Button B_GuardarCategoria;
        private TextBox TB_PrecioVenta;
        private TextBox TB_Stock;
        private TextBox TB_NombreCategoria;
        private TextBox TB_CodigoProducto;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
    }
}