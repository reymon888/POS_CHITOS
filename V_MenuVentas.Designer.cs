namespace POS_CHITOS
{
    partial class V_MenuVentas
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
            DGV_Ventas = new DataGridView();
            panelSuperior = new Panel();
            dateTimePicker1 = new DateTimePicker();
            B_MostrarDetalles = new Button();
            B_ActualizarTabla = new Button();
            button3 = new Button();
            B_ModificarVenta = new Button();
            B_CancelarVenta = new Button();
            TB_BuscarVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).BeginInit();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Ventas
            // 
            DGV_Ventas.BackgroundColor = SystemColors.ControlLightLight;
            DGV_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Ventas.Dock = DockStyle.Fill;
            DGV_Ventas.Location = new Point(0, 87);
            DGV_Ventas.MultiSelect = false;
            DGV_Ventas.Name = "DGV_Ventas";
            DGV_Ventas.ReadOnly = true;
            DGV_Ventas.RowHeadersVisible = false;
            DGV_Ventas.RowHeadersWidth = 51;
            DGV_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Ventas.Size = new Size(1609, 667);
            DGV_Ventas.TabIndex = 6;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = SystemColors.ControlLightLight;
            panelSuperior.Controls.Add(dateTimePicker1);
            panelSuperior.Controls.Add(B_MostrarDetalles);
            panelSuperior.Controls.Add(B_ActualizarTabla);
            panelSuperior.Controls.Add(button3);
            panelSuperior.Controls.Add(B_ModificarVenta);
            panelSuperior.Controls.Add(B_CancelarVenta);
            panelSuperior.Controls.Add(TB_BuscarVenta);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1609, 87);
            panelSuperior.TabIndex = 5;
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
            B_MostrarDetalles.Location = new Point(1181, 0);
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
            B_ActualizarTabla.Location = new Point(1288, 0);
            B_ActualizarTabla.Name = "B_ActualizarTabla";
            B_ActualizarTabla.Size = new Size(107, 87);
            B_ActualizarTabla.TabIndex = 5;
            B_ActualizarTabla.Text = "Actualizar ";
            B_ActualizarTabla.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ActualizarTabla.UseVisualStyleBackColor = false;
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
            // B_ModificarVenta
            // 
            B_ModificarVenta.BackColor = SystemColors.ControlLightLight;
            B_ModificarVenta.Cursor = Cursors.Hand;
            B_ModificarVenta.Dock = DockStyle.Right;
            B_ModificarVenta.FlatAppearance.BorderSize = 0;
            B_ModificarVenta.FlatStyle = FlatStyle.Flat;
            B_ModificarVenta.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ModificarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_ModificarVenta.Image = Properties.Resources.circulo;
            B_ModificarVenta.Location = new Point(1395, 0);
            B_ModificarVenta.Name = "B_ModificarVenta";
            B_ModificarVenta.Size = new Size(107, 87);
            B_ModificarVenta.TabIndex = 2;
            B_ModificarVenta.Text = "Modificar ";
            B_ModificarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_ModificarVenta.UseVisualStyleBackColor = false;
            B_ModificarVenta.Click += B_ModificarVenta_Click;
            // 
            // B_CancelarVenta
            // 
            B_CancelarVenta.BackColor = SystemColors.ControlLightLight;
            B_CancelarVenta.Cursor = Cursors.Hand;
            B_CancelarVenta.Dock = DockStyle.Right;
            B_CancelarVenta.FlatAppearance.BorderSize = 0;
            B_CancelarVenta.FlatStyle = FlatStyle.Flat;
            B_CancelarVenta.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CancelarVenta.ForeColor = Color.FromArgb(44, 140, 153);
            B_CancelarVenta.Image = Properties.Resources.rechazar__1_;
            B_CancelarVenta.Location = new Point(1502, 0);
            B_CancelarVenta.Name = "B_CancelarVenta";
            B_CancelarVenta.Size = new Size(107, 87);
            B_CancelarVenta.TabIndex = 1;
            B_CancelarVenta.Text = "Cancelar";
            B_CancelarVenta.TextImageRelation = TextImageRelation.ImageAboveText;
            B_CancelarVenta.UseVisualStyleBackColor = false;
            // 
            // TB_BuscarVenta
            // 
            TB_BuscarVenta.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarVenta.Location = new Point(12, 24);
            TB_BuscarVenta.Name = "TB_BuscarVenta";
            TB_BuscarVenta.Size = new Size(300, 34);
            TB_BuscarVenta.TabIndex = 0;
            // 
            // V_MenuVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1609, 754);
            Controls.Add(DGV_Ventas);
            Controls.Add(panelSuperior);
            Name = "V_MenuVentas";
            Text = "V_MenuVentas";
            ((System.ComponentModel.ISupportInitialize)DGV_Ventas).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Ventas;
        private Panel panelSuperior;
        private DateTimePicker dateTimePicker1;
        private Button B_MostrarDetalles;
        private Button B_ActualizarTabla;
        private Button button3;
        private Button B_ModificarVenta;
        private Button B_CancelarVenta;
        private TextBox TB_BuscarVenta;
    }
}