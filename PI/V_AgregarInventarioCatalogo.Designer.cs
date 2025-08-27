namespace POS_CHITOS.PI
{
    partial class V_AgregarInventarioCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AgregarInventarioCatalogo));
            DGV_Inventario = new DataGridView();
            panelSuperiorProv = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            B_AgregarProducto = new Button();
            B_DarBaja = new Button();
            TB_BuscarProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).BeginInit();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV_Inventario
            // 
            DGV_Inventario.AllowUserToAddRows = false;
            DGV_Inventario.AllowUserToDeleteRows = false;
            DGV_Inventario.AllowUserToOrderColumns = true;
            DGV_Inventario.AllowUserToResizeColumns = false;
            DGV_Inventario.AllowUserToResizeRows = false;
            DGV_Inventario.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Inventario.Dock = DockStyle.Fill;
            DGV_Inventario.Location = new Point(0, 87);
            DGV_Inventario.Name = "DGV_Inventario";
            DGV_Inventario.ReadOnly = true;
            DGV_Inventario.RowHeadersWidth = 51;
            DGV_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Inventario.Size = new Size(1598, 809);
            DGV_Inventario.TabIndex = 4;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarProducto);
            panelSuperiorProv.Controls.Add(B_DarBaja);
            panelSuperiorProv.Controls.Add(TB_BuscarProducto);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1598, 87);
            panelSuperiorProv.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(11, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(597, 17);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarProducto
            // 
            B_AgregarProducto.BackColor = SystemColors.ControlLightLight;
            B_AgregarProducto.Cursor = Cursors.Hand;
            B_AgregarProducto.Dock = DockStyle.Right;
            B_AgregarProducto.FlatAppearance.BorderSize = 0;
            B_AgregarProducto.FlatStyle = FlatStyle.Flat;
            B_AgregarProducto.Font = new Font("Segoe UI", 12F);
            B_AgregarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarProducto.Image = Properties.Resources.agregar_contacto__2_;
            B_AgregarProducto.Location = new Point(1384, 0);
            B_AgregarProducto.Name = "B_AgregarProducto";
            B_AgregarProducto.Size = new Size(107, 87);
            B_AgregarProducto.TabIndex = 3;
            B_AgregarProducto.Text = "Agregar";
            B_AgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProducto.UseVisualStyleBackColor = false;
            B_AgregarProducto.Click += B_AgregarProducto_Click;
            // 
            // B_DarBaja
            // 
            B_DarBaja.BackColor = SystemColors.ControlLightLight;
            B_DarBaja.Cursor = Cursors.Hand;
            B_DarBaja.Dock = DockStyle.Right;
            B_DarBaja.FlatAppearance.BorderSize = 0;
            B_DarBaja.FlatStyle = FlatStyle.Flat;
            B_DarBaja.Font = new Font("Segoe UI", 12F);
            B_DarBaja.ForeColor = Color.FromArgb(44, 140, 153);
            B_DarBaja.Image = Properties.Resources.boton_x;
            B_DarBaja.Location = new Point(1491, 0);
            B_DarBaja.Name = "B_DarBaja";
            B_DarBaja.Size = new Size(107, 87);
            B_DarBaja.TabIndex = 1;
            B_DarBaja.Text = "Cancelar";
            B_DarBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_DarBaja.UseVisualStyleBackColor = false;
            B_DarBaja.Click += B_DarBaja_Click;
            // 
            // TB_BuscarProducto
            // 
            TB_BuscarProducto.Font = new Font("Segoe UI", 12F);
            TB_BuscarProducto.Location = new Point(75, 24);
            TB_BuscarProducto.Name = "TB_BuscarProducto";
            TB_BuscarProducto.Size = new Size(515, 34);
            TB_BuscarProducto.TabIndex = 0;
            // 
            // V_AgregarInventarioCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 896);
            Controls.Add(DGV_Inventario);
            Controls.Add(panelSuperiorProv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_AgregarInventarioCatalogo";
            Text = "Agregar Inventario al Catalogo";
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Inventario;
        private Panel panelSuperiorProv;
        private PictureBox pictureBox1;
        private Button button3;
        private Button B_AgregarProducto;
        private Button B_DarBaja;
        private TextBox TB_BuscarProducto;
    }
}