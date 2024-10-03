namespace POS_CHITOS
{
    partial class V_menuInventario
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
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_AgregarProducto = new Button();
            B_ModificarProducto = new Button();
            B_DarBaja = new Button();
            TB_BuscarProducto = new TextBox();
            DGV_Inventario = new DataGridView();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).BeginInit();
            SuspendLayout();
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = SystemColors.ControlLightLight;
            panelSuperiorProv.Controls.Add(B_ActualizarTabla);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(B_AgregarProducto);
            panelSuperiorProv.Controls.Add(B_ModificarProducto);
            panelSuperiorProv.Controls.Add(B_DarBaja);
            panelSuperiorProv.Controls.Add(TB_BuscarProducto);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(1405, 87);
            panelSuperiorProv.TabIndex = 1;
            // 
            // B_ActualizarTabla
            // 
            B_ActualizarTabla.BackColor = SystemColors.ControlLightLight;
            B_ActualizarTabla.Cursor = Cursors.Hand;
            B_ActualizarTabla.Dock = DockStyle.Right;
            B_ActualizarTabla.FlatAppearance.BorderSize = 0;
            B_ActualizarTabla.FlatStyle = FlatStyle.Flat;
            B_ActualizarTabla.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ActualizarTabla.ForeColor = Color.FromArgb(44, 140, 153);
            B_ActualizarTabla.Image = Properties.Resources.editar__4_;
            B_ActualizarTabla.Location = new Point(977, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(107, 87);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar ";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
            B_ActualizarTabla.Click += B_ActualizarTabla_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(795, 17);
            button3.Name = "button3";
            button3.Size = new Size(51, 52);
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
            B_AgregarProducto.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarProducto.Image = Properties.Resources.aceptar__1_;
            B_AgregarProducto.Location = new Point(1084, 0);
            B_AgregarProducto.Name = "B_AgregarProducto";
            B_AgregarProducto.Size = new Size(107, 87);
            B_AgregarProducto.TabIndex = 3;
            B_AgregarProducto.Text = "Agregar";
            B_AgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarProducto.UseVisualStyleBackColor = false;
            B_AgregarProducto.Click += B_AgregarProducto_Click;
            // 
            // B_ModificarProducto
            // 
            B_ModificarProducto.BackColor = SystemColors.ControlLightLight;
            B_ModificarProducto.Cursor = Cursors.Hand;
            B_ModificarProducto.Dock = DockStyle.Right;
            B_ModificarProducto.FlatAppearance.BorderSize = 0;
            B_ModificarProducto.FlatStyle = FlatStyle.Flat;
            B_ModificarProducto.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ModificarProducto.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarProducto.Image = Properties.Resources.circulo;
            B_ModificarProducto.Location = new Point(1191, 0);
            B_ModificarProducto.Name = "B_ModificarProducto";
            B_ModificarProducto.Size = new Size(107, 87);
            B_ModificarProducto.TabIndex = 2;
            B_ModificarProducto.Text = "Modificar ";
            B_ModificarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarProducto.UseVisualStyleBackColor = false;
            B_ModificarProducto.Click += B_ModificarProducto_Click;
            // 
            // B_DarBaja
            // 
            B_DarBaja.BackColor = SystemColors.ControlLightLight;
            B_DarBaja.Cursor = Cursors.Hand;
            B_DarBaja.Dock = DockStyle.Right;
            B_DarBaja.FlatAppearance.BorderSize = 0;
            B_DarBaja.FlatStyle = FlatStyle.Flat;
            B_DarBaja.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_DarBaja.ForeColor = Color.FromArgb(44, 140, 153);
            B_DarBaja.Image = Properties.Resources.boton_x;
            B_DarBaja.Location = new Point(1298, 0);
            B_DarBaja.Name = "B_DarBaja";
            B_DarBaja.Size = new Size(107, 87);
            B_DarBaja.TabIndex = 1;
            B_DarBaja.Text = "Eliminar";
            B_DarBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            B_DarBaja.UseVisualStyleBackColor = false;
            B_DarBaja.Click += B_DarBaja_Click;
            // 
            // TB_BuscarProducto
            // 
            TB_BuscarProducto.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarProducto.Location = new Point(12, 27);
            TB_BuscarProducto.Name = "TB_BuscarProducto";
            TB_BuscarProducto.Size = new Size(777, 34);
            TB_BuscarProducto.TabIndex = 0;
            TB_BuscarProducto.KeyDown += TB_BuscarProducto_KeyDown;
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
            DGV_Inventario.Size = new Size(1405, 620);
            DGV_Inventario.TabIndex = 2;
            DGV_Inventario.SelectionChanged += DGV_Inventario_SelectionChanged;
            // 
            // V_menuInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 707);
            Controls.Add(DGV_Inventario);
            Controls.Add(panelSuperiorProv);
            Name = "V_menuInventario";
            Text = "V_menuInventario";
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperiorProv;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_AgregarProducto;
        private Button B_ModificarProducto;
        private Button B_DarBaja;
        private TextBox TB_BuscarProducto;
        private DataGridView DGV_Inventario;
    }
}