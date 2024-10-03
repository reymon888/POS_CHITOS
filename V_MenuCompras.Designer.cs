namespace POS_CHITOS
{
    partial class V_MenuCompras
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
            DGV_Compras = new DataGridView();
            panelSuperior = new Panel();
            dateTimePicker1 = new DateTimePicker();
            B_MostrarDetalles = new Button();
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_AgregarCompra = new Button();
            B_ModificarCompra = new Button();
            B_CancelarCompra = new Button();
            TB_BuscarCompra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Compras).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Compras
            // 
            DGV_Compras.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Compras.Dock = DockStyle.Fill;
            DGV_Compras.Location = new Point(0, 87);
            DGV_Compras.MultiSelect = false;
            DGV_Compras.Name = "DGV_Compras";
            DGV_Compras.ReadOnly = true;
            DGV_Compras.RowHeadersVisible = false;
            DGV_Compras.RowHeadersWidth = 51;
            DGV_Compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Compras.Size = new Size(1306, 595);
            DGV_Compras.TabIndex = 4;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(B_MostrarDetalles);
            panelSuperior.Controls.Add(B_ActualizarTabla);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_AgregarCompra);
            panelSuperior.Controls.Add(B_ModificarCompra);
            panelSuperior.Controls.Add(B_CancelarCompra);
            panelSuperior.Controls.Add(TB_BuscarCompra);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1306, 87);
            panelSuperior.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(411, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(354, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // B_MostrarDetalles
            // 
            B_MostrarDetalles.BackColor = SystemColors.ControlLightLight;
            B_MostrarDetalles.Cursor = Cursors.Hand;
            B_MostrarDetalles.Dock = DockStyle.Right;
            B_MostrarDetalles.FlatAppearance.BorderSize = 0;
            B_MostrarDetalles.FlatStyle = FlatStyle.Flat;
            B_MostrarDetalles.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_MostrarDetalles.ForeColor = Color.FromArgb(44, 140, 153);
            B_MostrarDetalles.Image = Properties.Resources.archivo__1_;
            B_MostrarDetalles.Location = new Point(771, 0);
            B_MostrarDetalles.Name = "B_MostrarDetalles";
            B_MostrarDetalles.Size = new Size(107, 87);
            B_MostrarDetalles.TabIndex = 6;
            B_MostrarDetalles.Text = "Mostrar ";
            B_MostrarDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            B_MostrarDetalles.UseVisualStyleBackColor = false;
            B_MostrarDetalles.Click += B_MostrarDetalles_Click;
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
            B_ActualizarTabla.Image = Properties.Resources.recargar;
            B_ActualizarTabla.Location = new Point(878, 0);
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
            button3.Location = new Point(330, 17);
            button3.Name = "button3";
            button3.Size = new Size(51, 52);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // B_AgregarCompra
            // 
            B_AgregarCompra.BackColor = SystemColors.ControlLightLight;
            B_AgregarCompra.Cursor = Cursors.Hand;
            B_AgregarCompra.Dock = DockStyle.Right;
            B_AgregarCompra.FlatAppearance.BorderSize = 0;
            B_AgregarCompra.FlatStyle = FlatStyle.Flat;
            B_AgregarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_AgregarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_AgregarCompra.Image = Properties.Resources.aceptar__1_;
            B_AgregarCompra.Location = new Point(985, 0);
            B_AgregarCompra.Name = "B_AgregarCompra";
            B_AgregarCompra.Size = new Size(107, 87);
            B_AgregarCompra.TabIndex = 3;
            B_AgregarCompra.Text = "Agregar";
            B_AgregarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_AgregarCompra.UseVisualStyleBackColor = false;
            // 
            // B_ModificarCompra
            // 
            B_ModificarCompra.BackColor = SystemColors.ControlLightLight;
            B_ModificarCompra.Cursor = Cursors.Hand;
            B_ModificarCompra.Dock = DockStyle.Right;
            B_ModificarCompra.FlatAppearance.BorderSize = 0;
            B_ModificarCompra.FlatStyle = FlatStyle.Flat;
            B_ModificarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ModificarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarCompra.Image = Properties.Resources.circulo;
            B_ModificarCompra.Location = new Point(1092, 0);
            B_ModificarCompra.Name = "B_ModificarCompra";
            B_ModificarCompra.Size = new Size(107, 87);
            B_ModificarCompra.TabIndex = 2;
            B_ModificarCompra.Text = "Modificar ";
            B_ModificarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarCompra.UseVisualStyleBackColor = false;
            B_ModificarCompra.Click += B_ModificarCompra_Click;
            // 
            // B_CancelarCompra
            // 
            B_CancelarCompra.BackColor = SystemColors.ControlLightLight;
            B_CancelarCompra.Cursor = Cursors.Hand;
            B_CancelarCompra.Dock = DockStyle.Right;
            B_CancelarCompra.FlatAppearance.BorderSize = 0;
            B_CancelarCompra.FlatStyle = FlatStyle.Flat;
            B_CancelarCompra.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CancelarCompra.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarCompra.Image = Properties.Resources.rechazar__1_;
            B_CancelarCompra.Location = new Point(1199, 0);
            B_CancelarCompra.Name = "B_CancelarCompra";
            B_CancelarCompra.Size = new Size(107, 87);
            B_CancelarCompra.TabIndex = 1;
            B_CancelarCompra.Text = "Cancelar";
            B_CancelarCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarCompra.UseVisualStyleBackColor = false;
            B_CancelarCompra.Click += B_CancelarCompra_Click;
            // 
            // TB_BuscarCompra
            // 
            TB_BuscarCompra.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarCompra.Location = new Point(12, 24);
            TB_BuscarCompra.Name = "TB_BuscarCompra";
            TB_BuscarCompra.Size = new Size(300, 34);
            TB_BuscarCompra.TabIndex = 0;
            // 
            // V_MenuCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 682);
            Controls.Add(DGV_Compras);
            Controls.Add(panelSuperior);
            Name = "V_MenuCompras";
            Text = "V_MenuCompras";
            ((System.ComponentModel.ISupportInitialize)DGV_Compras).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Compras;
        private Panel panelSuperior;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_AgregarCompra;
        private Button B_ModificarCompra;
        private Button B_CancelarCompra;
        private TextBox TB_BuscarCompra;
        private Button B_MostrarDetalles;
        private DateTimePicker dateTimePicker1;
    }
}