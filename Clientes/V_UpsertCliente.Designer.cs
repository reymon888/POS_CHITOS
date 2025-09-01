namespace POS_CHITOS.Clientes
{
    partial class V_UpsertCliente
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
            TB_RFC = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTitulo = new Label();
            B_Cancelar = new Button();
            B_Guardar = new Button();
            TB_Direccion = new TextBox();
            TB_CE = new TextBox();
            TB_Telefono = new TextBox();
            TB_Nombre = new TextBox();
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
            panel2.Controls.Add(TB_RFC);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_Guardar);
            panel2.Controls.Add(TB_Direccion);
            panel2.Controls.Add(TB_CE);
            panel2.Controls.Add(TB_Telefono);
            panel2.Controls.Add(TB_Nombre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(823, 835);
            panel2.TabIndex = 1;
            // 
            // TB_RFC
            // 
            TB_RFC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_RFC.BackColor = Color.WhiteSmoke;
            TB_RFC.Font = new Font("Segoe UI", 13.8F);
            TB_RFC.ForeColor = Color.FromArgb(26, 77, 128);
            TB_RFC.Location = new Point(399, 380);
            TB_RFC.Margin = new Padding(4);
            TB_RFC.Name = "TB_RFC";
            TB_RFC.Size = new Size(334, 44);
            TB_RFC.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(399, 322);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 38);
            label1.TabIndex = 9;
            label1.Text = "RFC";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.conductor;
            pictureBox1.Location = new Point(144, 31);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Location = new Point(26, 149);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 5);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(231, 46);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 48);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Datos del Cliente";
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.DarkGray;
            B_Cancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(421, 701);
            B_Cancelar.Margin = new Padding(4);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(299, 92);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (Esc)";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_Guardar
            // 
            B_Guardar.AutoSize = true;
            B_Guardar.BackColor = Color.FromArgb(26, 77, 128);
            B_Guardar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            B_Guardar.ForeColor = Color.White;
            B_Guardar.Image = Properties.Resources.salvar1;
            B_Guardar.Location = new Point(79, 701);
            B_Guardar.Margin = new Padding(4);
            B_Guardar.Name = "B_Guardar";
            B_Guardar.Size = new Size(312, 92);
            B_Guardar.TabIndex = 5;
            B_Guardar.Text = "Aceptar (Enter)";
            B_Guardar.TextAlign = ContentAlignment.MiddleRight;
            B_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Guardar.UseVisualStyleBackColor = false;
            B_Guardar.Click += B_Guardar_Click;
            // 
            // TB_Direccion
            // 
            TB_Direccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Direccion.BackColor = Color.WhiteSmoke;
            TB_Direccion.Font = new Font("Segoe UI", 13.8F);
            TB_Direccion.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Direccion.Location = new Point(59, 606);
            TB_Direccion.Margin = new Padding(4);
            TB_Direccion.Name = "TB_Direccion";
            TB_Direccion.Size = new Size(658, 44);
            TB_Direccion.TabIndex = 4;
            // 
            // TB_CE
            // 
            TB_CE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_CE.BackColor = Color.WhiteSmoke;
            TB_CE.Font = new Font("Segoe UI", 13.8F);
            TB_CE.ForeColor = Color.FromArgb(26, 77, 128);
            TB_CE.Location = new Point(59, 492);
            TB_CE.Margin = new Padding(4);
            TB_CE.Name = "TB_CE";
            TB_CE.Size = new Size(470, 44);
            TB_CE.TabIndex = 3;
            // 
            // TB_Telefono
            // 
            TB_Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Telefono.BackColor = Color.WhiteSmoke;
            TB_Telefono.Font = new Font("Segoe UI", 13.8F);
            TB_Telefono.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Telefono.Location = new Point(66, 388);
            TB_Telefono.Margin = new Padding(4);
            TB_Telefono.Name = "TB_Telefono";
            TB_Telefono.Size = new Size(287, 44);
            TB_Telefono.TabIndex = 2;
            // 
            // TB_Nombre
            // 
            TB_Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Nombre.BackColor = Color.WhiteSmoke;
            TB_Nombre.Font = new Font("Segoe UI", 13.8F);
            TB_Nombre.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Nombre.Location = new Point(66, 249);
            TB_Nombre.Margin = new Padding(4);
            TB_Nombre.Name = "TB_Nombre";
            TB_Nombre.Size = new Size(654, 44);
            TB_Nombre.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(70, 564);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 38);
            label5.TabIndex = 0;
            label5.Text = "Direccion*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(66, 436);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 38);
            label4.TabIndex = 0;
            label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(66, 322);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 38);
            label3.TabIndex = 0;
            label3.Text = "Telefono*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(70, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 0;
            label2.Text = "Nombre*";
            // 
            // V_UpsertCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 835);
            Controls.Add(panel2);
            Name = "V_UpsertCliente";
            Text = "V_UpsertCliente";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTitulo;
        private Button B_Cancelar;
        private Button B_Guardar;
        private TextBox TB_Direccion;
        private TextBox TB_CE;
        private TextBox TB_Telefono;
        private TextBox TB_Nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TB_RFC;
        private Label label1;
    }
}