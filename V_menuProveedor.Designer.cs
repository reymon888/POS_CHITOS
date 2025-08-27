namespace POS_CHITOS
{
    partial class V_menuProveedor
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
            panelSuperiorProv = new Panel();
            B_catalogoProveedor = new Button();
            B_ActualizarProveedor = new Button();
            button3 = new Button();
            button2 = new Button();
            B_ModificarProveedor = new Button();
            B_DarBaja = new Button();
            TB_BuscarProveedor = new TextBox();
            panel1 = new Panel();
            DGV_Proveedores = new DataGridView();
            panelSuperiorProv.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Proveedores).BeginInit();
            SuspendLayout();
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(B_catalogoProveedor);
            panelSuperiorProv.Controls.Add(B_ActualizarProveedor);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(button2);
            panelSuperiorProv.Controls.Add(B_ModificarProveedor);
            panelSuperiorProv.Controls.Add(B_DarBaja);
            panelSuperiorProv.Controls.Add(TB_BuscarProveedor);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1511, 121);
            panelSuperiorProv.TabIndex = 0;
            // 
            // B_catalogoProveedor
            // 
            B_catalogoProveedor.BackColor = Color.WhiteSmoke;
            B_catalogoProveedor.Dock = DockStyle.Right;
            B_catalogoProveedor.FlatAppearance.BorderSize = 0;
            B_catalogoProveedor.FlatStyle = FlatStyle.Flat;
            B_catalogoProveedor.Font = new Font("Segoe UI", 10.2F);
            B_catalogoProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            B_catalogoProveedor.Image = Properties.Resources.catalogo;
            B_catalogoProveedor.Location = new Point(1005, 0);
            B_catalogoProveedor.Name = "B_catalogoProveedor";
            B_catalogoProveedor.Size = new Size(99, 121);
            B_catalogoProveedor.TabIndex = 6;
            B_catalogoProveedor.Text = "Catalogo (Ctrl + C)";
            B_catalogoProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            B_catalogoProveedor.UseVisualStyleBackColor = false;
            B_catalogoProveedor.Click += B_catalogoProveedor_Click;
            // 
            // B_ActualizarProveedor
            // 
            B_ActualizarProveedor.BackColor = Color.WhiteSmoke;
            B_ActualizarProveedor.Dock = DockStyle.Right;
            B_ActualizarProveedor.FlatAppearance.BorderSize = 0;
            B_ActualizarProveedor.FlatStyle = FlatStyle.Flat;
            B_ActualizarProveedor.Font = new Font("Segoe UI", 10.2F);
            B_ActualizarProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            B_ActualizarProveedor.Image = Properties.Resources.recargar;
            B_ActualizarProveedor.Location = new Point(1104, 0);
            B_ActualizarProveedor.Name = "B_ActualizarProveedor";
            B_ActualizarProveedor.Size = new Size(110, 121);
            B_ActualizarProveedor.TabIndex = 5;
            B_ActualizarProveedor.Text = "Actualizar (Ctrl + R)";
            B_ActualizarProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarProveedor.UseVisualStyleBackColor = false;
            B_ActualizarProveedor.Click += B_ActualizarProveedor_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(777, 18);
            button3.Name = "button3";
            button3.Size = new Size(72, 82);
            button3.TabIndex = 4;
            button3.Text = "(Ctrl + S)";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.ForeColor = Color.FromArgb(26, 77, 128);
            button2.Image = Properties.Resources.agregar_contacto__2_;
            button2.Location = new Point(1214, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 121);
            button2.TabIndex = 3;
            button2.Text = "Nuevo (Ctrl + N)";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // B_ModificarProveedor
            // 
            B_ModificarProveedor.BackColor = Color.WhiteSmoke;
            B_ModificarProveedor.Dock = DockStyle.Right;
            B_ModificarProveedor.FlatAppearance.BorderSize = 0;
            B_ModificarProveedor.FlatStyle = FlatStyle.Flat;
            B_ModificarProveedor.Font = new Font("Segoe UI", 10.2F);
            B_ModificarProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            B_ModificarProveedor.Image = Properties.Resources.circulo;
            B_ModificarProveedor.Location = new Point(1308, 0);
            B_ModificarProveedor.Name = "B_ModificarProveedor";
            B_ModificarProveedor.Size = new Size(104, 121);
            B_ModificarProveedor.TabIndex = 2;
            B_ModificarProveedor.Text = "Modificar (Ctrl + M)";
            B_ModificarProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarProveedor.UseVisualStyleBackColor = false;
            B_ModificarProveedor.Click += B_ModificarProveedor_Click;
            // 
            // B_DarBaja
            // 
            B_DarBaja.BackColor = Color.WhiteSmoke;
            B_DarBaja.Dock = DockStyle.Right;
            B_DarBaja.FlatAppearance.BorderSize = 0;
            B_DarBaja.FlatStyle = FlatStyle.Flat;
            B_DarBaja.Font = new Font("Segoe UI", 10.2F);
            B_DarBaja.ForeColor = Color.FromArgb(26, 77, 128);
            B_DarBaja.Image = Properties.Resources.semaforo;
            B_DarBaja.Location = new Point(1412, 0);
            B_DarBaja.Name = "B_DarBaja";
            B_DarBaja.Size = new Size(99, 121);
            B_DarBaja.TabIndex = 1;
            B_DarBaja.Text = "Cambiar Estado (Ctrl + B)";
            B_DarBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_DarBaja.UseVisualStyleBackColor = false;
            B_DarBaja.Click += B_DarBaja_Click;
            // 
            // TB_BuscarProveedor
            // 
            TB_BuscarProveedor.BackColor = Color.WhiteSmoke;
            TB_BuscarProveedor.Font = new Font("Segoe UI", 12F);
            TB_BuscarProveedor.ForeColor = Color.FromArgb(26, 77, 128);
            TB_BuscarProveedor.Location = new Point(12, 39);
            TB_BuscarProveedor.Name = "TB_BuscarProveedor";
            TB_BuscarProveedor.Size = new Size(759, 34);
            TB_BuscarProveedor.TabIndex = 0;
            TB_BuscarProveedor.KeyDown += TB_BuscarProveedor_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(DGV_Proveedores);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(1511, 619);
            panel1.TabIndex = 1;
            // 
            // DGV_Proveedores
            // 
            DGV_Proveedores.AllowUserToAddRows = false;
            DGV_Proveedores.AllowUserToResizeColumns = false;
            DGV_Proveedores.AllowUserToResizeRows = false;
            DGV_Proveedores.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Proveedores.Dock = DockStyle.Fill;
            DGV_Proveedores.Location = new Point(0, 0);
            DGV_Proveedores.MultiSelect = false;
            DGV_Proveedores.Name = "DGV_Proveedores";
            DGV_Proveedores.ReadOnly = true;
            DGV_Proveedores.RowHeadersVisible = false;
            DGV_Proveedores.RowHeadersWidth = 51;
            DGV_Proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Proveedores.Size = new Size(1511, 619);
            DGV_Proveedores.TabIndex = 0;
            DGV_Proveedores.SelectionChanged += DGV_Proveedores_SelectionChanged;
            // 
            // V_menuProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 740);
            Controls.Add(panel1);
            Controls.Add(panelSuperiorProv);
            Name = "V_menuProveedor";
            Text = "V_menuProveedor";
            Load += V_menuProveedor_Load;
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Proveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperiorProv;
        private Button B_DarBaja;
        private TextBox TB_BuscarProveedor;
        private Panel panel1;
        private DataGridView DGV_Proveedores;
        private Button button2;
        private Button B_ModificarProveedor;
        private Button button3;
        private Button B_ActualizarProveedor;
        private Button B_catalogoProveedor;
    }
}