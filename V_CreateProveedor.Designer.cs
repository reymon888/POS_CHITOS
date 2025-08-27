namespace POS_CHITOS
{
    partial class V_CreateProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_CreateProveedor));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTitulo = new Label();
            B_Cancelar = new Button();
            B_CrearProveedor = new Button();
            TB_DireccionProveedor = new TextBox();
            TB_CEProveedor = new TextBox();
            TB_TelefonoProveedor = new TextBox();
            TB_NombreProveedor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_CrearProveedor);
            panel2.Controls.Add(TB_DireccionProveedor);
            panel2.Controls.Add(TB_CEProveedor);
            panel2.Controls.Add(TB_TelefonoProveedor);
            panel2.Controls.Add(TB_NombreProveedor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 671);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cadena_de_suministro__1_;
            pictureBox1.Location = new Point(115, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(21, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 4);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(185, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 41);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Proveedor";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.DarkGray;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(314, 585);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(239, 74);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (Esc)";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // B_CrearProveedor
            // 
            B_CrearProveedor.AutoSize = true;
            B_CrearProveedor.BackColor = Color.FromArgb(26, 77, 128);
            B_CrearProveedor.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_CrearProveedor.ForeColor = Color.White;
            B_CrearProveedor.Image = Properties.Resources.salvar1;
            B_CrearProveedor.Location = new Point(56, 585);
            B_CrearProveedor.Name = "B_CrearProveedor";
            B_CrearProveedor.Size = new Size(239, 74);
            B_CrearProveedor.TabIndex = 5;
            B_CrearProveedor.Text = "Aceptar (Enter)";
            B_CrearProveedor.TextAlign = ContentAlignment.MiddleRight;
            B_CrearProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_CrearProveedor.UseVisualStyleBackColor = false;
            B_CrearProveedor.Click += B_CrearProveedor_Click;
            // 
            // TB_DireccionProveedor
            // 
            TB_DireccionProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_DireccionProveedor.BackColor = Color.WhiteSmoke;
            TB_DireccionProveedor.Font = new Font("Segoe UI", 13.8F);
            TB_DireccionProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            TB_DireccionProveedor.Location = new Point(48, 498);
            TB_DireccionProveedor.Name = "TB_DireccionProveedor";
            TB_DireccionProveedor.Size = new Size(527, 38);
            TB_DireccionProveedor.TabIndex = 4;
            TB_DireccionProveedor.KeyPress += TB_DireccionProveedor_KeyPress;
            // 
            // TB_CEProveedor
            // 
            TB_CEProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_CEProveedor.BackColor = Color.WhiteSmoke;
            TB_CEProveedor.Font = new Font("Segoe UI", 13.8F);
            TB_CEProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            TB_CEProveedor.Location = new Point(51, 383);
            TB_CEProveedor.Name = "TB_CEProveedor";
            TB_CEProveedor.Size = new Size(527, 38);
            TB_CEProveedor.TabIndex = 3;
            TB_CEProveedor.KeyPress += TB_CEProveedor_KeyPress;
            // 
            // TB_TelefonoProveedor
            // 
            TB_TelefonoProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_TelefonoProveedor.BackColor = Color.WhiteSmoke;
            TB_TelefonoProveedor.Font = new Font("Segoe UI", 13.8F);
            TB_TelefonoProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            TB_TelefonoProveedor.Location = new Point(51, 292);
            TB_TelefonoProveedor.Name = "TB_TelefonoProveedor";
            TB_TelefonoProveedor.Size = new Size(524, 38);
            TB_TelefonoProveedor.TabIndex = 2;
            TB_TelefonoProveedor.KeyPress += TB_TelefonoProveedor_KeyPress;
            // 
            // TB_NombreProveedor
            // 
            TB_NombreProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_NombreProveedor.BackColor = Color.WhiteSmoke;
            TB_NombreProveedor.Font = new Font("Segoe UI", 13.8F);
            TB_NombreProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            TB_NombreProveedor.Location = new Point(51, 191);
            TB_NombreProveedor.Name = "TB_NombreProveedor";
            TB_NombreProveedor.Size = new Size(524, 38);
            TB_NombreProveedor.TabIndex = 1;
            TB_NombreProveedor.KeyPress += TB_NombreProveedor_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(56, 451);
            label5.Name = "label5";
            label5.Size = new Size(123, 31);
            label5.TabIndex = 0;
            label5.Text = "Direccion*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(53, 349);
            label4.Name = "label4";
            label4.Size = new Size(208, 31);
            label4.TabIndex = 0;
            label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(53, 258);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 0;
            label3.Text = "Telefono*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(56, 157);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 0;
            label2.Text = "Nombre*";
            // 
            // V_CreateProveedor
            // 
            AcceptButton = B_CrearProveedor;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(632, 671);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_CreateProveedor";
            Text = "Registrar Nuevo Proveedor";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TB_DireccionProveedor;
        private TextBox TB_CEProveedor;
        private TextBox TB_TelefonoProveedor;
        private TextBox TB_NombreProveedor;
        private Button B_Cancelar;
        private Button B_CrearProveedor;
        private Label lblTitulo;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}