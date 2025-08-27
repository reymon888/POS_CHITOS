namespace POS_CHITOS.Inventario
{
    partial class V_SeleccionarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_SeleccionarInventario));
            DGV_Inventario = new DataGridView();
            panelSuperiorProv = new Panel();
            pictureBox1 = new PictureBox();
            B_Aceptar = new Button();
            TB_BuscarProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).BeginInit();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV_Inventario
            // 
            DGV_Inventario.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Inventario.Dock = DockStyle.Fill;
            DGV_Inventario.Location = new Point(0, 87);
            DGV_Inventario.MultiSelect = false;
            DGV_Inventario.Name = "DGV_Inventario";
            DGV_Inventario.ReadOnly = true;
            DGV_Inventario.RowHeadersWidth = 51;
            DGV_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Inventario.Size = new Size(978, 345);
            DGV_Inventario.TabIndex = 4;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(B_Aceptar);
            panelSuperiorProv.Controls.Add(TB_BuscarProducto);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(978, 87);
            panelSuperiorProv.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.codigo_de_barras__1_;
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // B_Aceptar
            // 
            B_Aceptar.BackColor = Color.Silver;
            B_Aceptar.FlatAppearance.BorderSize = 0;
            B_Aceptar.FlatStyle = FlatStyle.Flat;
            B_Aceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Aceptar.Image = Properties.Resources.aceptar__1_;
            B_Aceptar.Location = new Point(737, 21);
            B_Aceptar.Name = "B_Aceptar";
            B_Aceptar.Size = new Size(198, 45);
            B_Aceptar.TabIndex = 4;
            B_Aceptar.Text = "Aceptar";
            B_Aceptar.TextAlign = ContentAlignment.MiddleRight;
            B_Aceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Aceptar.UseVisualStyleBackColor = false;
            B_Aceptar.Click += B_Aceptar_Click;
            // 
            // TB_BuscarProducto
            // 
            TB_BuscarProducto.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TB_BuscarProducto.Location = new Point(76, 24);
            TB_BuscarProducto.Name = "TB_BuscarProducto";
            TB_BuscarProducto.Size = new Size(515, 38);
            TB_BuscarProducto.TabIndex = 0;
            // 
            // V_SeleccionarInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 432);
            Controls.Add(DGV_Inventario);
            Controls.Add(panelSuperiorProv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_SeleccionarInventario";
            Text = "Selecciona Producto";
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
        private Button B_Aceptar;
        private TextBox TB_BuscarProducto;
    }
}