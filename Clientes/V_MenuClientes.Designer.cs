namespace POS_CHITOS.Clientes
{
    partial class V_MenuClientes
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
            DGV_Clientes = new DataGridView();
            panelSuperiorProv = new Panel();
            pictureBox2 = new PictureBox();
            CB_Filtros = new ComboBox();
            pictureBox1 = new PictureBox();
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_Agregar = new Button();
            B_Modificar = new Button();
            B_Estado = new Button();
            TB_BuscarCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Clientes).BeginInit();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV_Clientes
            // 
            DGV_Clientes.AllowUserToAddRows = false;
            DGV_Clientes.AllowUserToResizeColumns = false;
            DGV_Clientes.AllowUserToResizeRows = false;
            DGV_Clientes.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Clientes.Dock = DockStyle.Fill;
            DGV_Clientes.Location = new Point(0, 175);
            DGV_Clientes.Margin = new Padding(4);
            DGV_Clientes.MultiSelect = false;
            DGV_Clientes.Name = "DGV_Clientes";
            DGV_Clientes.ReadOnly = true;
            DGV_Clientes.RowHeadersWidth = 51;
            DGV_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Clientes.Size = new Size(1831, 753);
            DGV_Clientes.TabIndex = 4;
            DGV_Clientes.CellDoubleClick += DGV_Clientes_CellDoubleClick;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(pictureBox2);
            panelSuperiorProv.Controls.Add(CB_Filtros);
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_Agregar);
            panelSuperiorProv.Controls.Add(B_Modificar);
            panelSuperiorProv.Controls.Add(B_Estado);
            panelSuperiorProv.Controls.Add(TB_BuscarCliente);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Margin = new Padding(4);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1831, 175);
            panelSuperiorProv.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.filtrar__1_;
            pictureBox2.Location = new Point(19, 108);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // CB_Filtros
            // 
            CB_Filtros.BackColor = Color.WhiteSmoke;
            CB_Filtros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Filtros.ForeColor = Color.FromArgb(44, 140, 153);
            CB_Filtros.FormattingEnabled = true;
            CB_Filtros.Location = new Point(95, 102);
            CB_Filtros.Margin = new Padding(4);
            CB_Filtros.Name = "CB_Filtros";
            CB_Filtros.Size = new Size(322, 40);
            CB_Filtros.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.servicio_al_cliente;
            pictureBox1.Location = new Point(15, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 48);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // B_ActualizarTabla
            // 
            B_ActualizarTabla.BackColor = Color.WhiteSmoke;
            B_ActualizarTabla.Cursor = Cursors.Hand;
            B_ActualizarTabla.Dock = DockStyle.Right;
            B_ActualizarTabla.FlatAppearance.BorderSize = 0;
            B_ActualizarTabla.FlatStyle = FlatStyle.Flat;
            B_ActualizarTabla.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarTabla.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTabla.Image = Properties.Resources.recargar;
            B_ActualizarTabla.Location = new Point(1334, 0);
            B_ActualizarTabla.Margin = new Padding(4);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(126, 175);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar (Ctrl + R)";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(746, 21);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(59, 56);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_Agregar
            // 
            B_Agregar.BackColor = Color.WhiteSmoke;
            B_Agregar.Cursor = Cursors.Hand;
            B_Agregar.Dock = DockStyle.Right;
            B_Agregar.FlatAppearance.BorderSize = 0;
            B_Agregar.FlatStyle = FlatStyle.Flat;
            B_Agregar.Font = new Font("Segoe UI", 10.2F);
            B_Agregar.ForeColor = Color.FromArgb(44, 140, 153);
            B_Agregar.Image = Properties.Resources.agregar_contacto__2_;
            B_Agregar.Location = new Point(1460, 0);
            B_Agregar.Margin = new Padding(4);
            B_Agregar.Name = "B_Agregar";
            B_Agregar.Size = new Size(126, 175);
            B_Agregar.TabIndex = 3;
            B_Agregar.Text = "Agregar (Ctrl + N)";
            B_Agregar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Agregar.UseVisualStyleBackColor = false;
            B_Agregar.Click += B_Agregar_Click;
            // 
            // B_Modificar
            // 
            B_Modificar.BackColor = Color.WhiteSmoke;
            B_Modificar.Cursor = Cursors.Hand;
            B_Modificar.Dock = DockStyle.Right;
            B_Modificar.FlatAppearance.BorderSize = 0;
            B_Modificar.FlatStyle = FlatStyle.Flat;
            B_Modificar.Font = new Font("Segoe UI", 10.2F);
            B_Modificar.ForeColor = Color.FromArgb(44, 140, 153);
            B_Modificar.Image = Properties.Resources.circulo;
            B_Modificar.Location = new Point(1586, 0);
            B_Modificar.Margin = new Padding(4);
            B_Modificar.Name = "B_Modificar";
            B_Modificar.Size = new Size(126, 175);
            B_Modificar.TabIndex = 2;
            B_Modificar.Text = "Modificar (Ctrl + M)";
            B_Modificar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Modificar.UseVisualStyleBackColor = false;
            B_Modificar.Click += B_Modificar_Click;
            // 
            // B_Estado
            // 
            B_Estado.BackColor = Color.WhiteSmoke;
            B_Estado.Cursor = Cursors.Hand;
            B_Estado.Dock = DockStyle.Right;
            B_Estado.FlatAppearance.BorderSize = 0;
            B_Estado.FlatStyle = FlatStyle.Flat;
            B_Estado.Font = new Font("Segoe UI", 10.2F);
            B_Estado.ForeColor = Color.FromArgb(44, 140, 153);
            B_Estado.Image = Properties.Resources.semaforo;
            B_Estado.Location = new Point(1712, 0);
            B_Estado.Margin = new Padding(4);
            B_Estado.Name = "B_Estado";
            B_Estado.Size = new Size(119, 175);
            B_Estado.TabIndex = 1;
            B_Estado.Text = "Cambiar Estado (Ctrl + B)";
            B_Estado.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Estado.UseVisualStyleBackColor = false;
            B_Estado.Click += B_Estado_ClickAsync;
            // 
            // TB_BuscarCliente
            // 
            TB_BuscarCliente.BackColor = Color.WhiteSmoke;
            TB_BuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarCliente.ForeColor = Color.FromArgb(44, 140, 153);
            TB_BuscarCliente.Location = new Point(95, 30);
            TB_BuscarCliente.Margin = new Padding(4);
            TB_BuscarCliente.Name = "TB_BuscarCliente";
            TB_BuscarCliente.Size = new Size(643, 39);
            TB_BuscarCliente.TabIndex = 0;
            // 
            // V_MenuClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1831, 928);
            Controls.Add(DGV_Clientes);
            Controls.Add(panelSuperiorProv);
            Name = "V_MenuClientes";
            Text = "V_MenuClientes";
            ((System.ComponentModel.ISupportInitialize)DGV_Clientes).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Clientes;
        private Panel panelSuperiorProv;
        private PictureBox pictureBox2;
        private ComboBox CB_Filtros;
        private PictureBox pictureBox1;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_Agregar;
        private Button B_Modificar;
        private Button B_Estado;
        private TextBox TB_BuscarCliente;
    }
}