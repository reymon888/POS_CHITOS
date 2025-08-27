namespace POS_CHITOS.Categorias
{
    partial class V_SeleccionarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_SeleccionarCategoria));
            DGV_CategoriasInventario = new DataGridView();
            panelSuperiorProv = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            TB_BuscarCategoria = new TextBox();
            panel1 = new Panel();
            B_GuardarCategoria = new Button();
            B_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_CategoriasInventario).BeginInit();
            panelSuperiorProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_CategoriasInventario
            // 
            DGV_CategoriasInventario.AllowUserToAddRows = false;
            DGV_CategoriasInventario.AllowUserToResizeColumns = false;
            DGV_CategoriasInventario.AllowUserToResizeRows = false;
            DGV_CategoriasInventario.BackgroundColor = Color.WhiteSmoke;
            DGV_CategoriasInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CategoriasInventario.Dock = DockStyle.Fill;
            DGV_CategoriasInventario.Location = new Point(0, 96);
            DGV_CategoriasInventario.MultiSelect = false;
            DGV_CategoriasInventario.Name = "DGV_CategoriasInventario";
            DGV_CategoriasInventario.ReadOnly = true;
            DGV_CategoriasInventario.RowHeadersWidth = 51;
            DGV_CategoriasInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_CategoriasInventario.Size = new Size(800, 354);
            DGV_CategoriasInventario.TabIndex = 6;
            // 
            // panelSuperiorProv
            // 
            panelSuperiorProv.BackColor = Color.WhiteSmoke;
            panelSuperiorProv.Controls.Add(pictureBox1);
            panelSuperiorProv.Controls.Add(button3);
            panelSuperiorProv.Controls.Add(TB_BuscarCategoria);
            panelSuperiorProv.Dock = DockStyle.Top;
            panelSuperiorProv.Location = new Point(0, 0);
            panelSuperiorProv.Name = "panelSuperiorProv";
            panelSuperiorProv.Size = new Size(800, 96);
            panelSuperiorProv.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.etiqueta;
            pictureBox1.Location = new Point(22, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 49);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.buscar;
            button3.Location = new Point(701, 21);
            button3.Name = "button3";
            button3.Size = new Size(47, 45);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // TB_BuscarCategoria
            // 
            TB_BuscarCategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_BuscarCategoria.Location = new Point(63, 24);
            TB_BuscarCategoria.Name = "TB_BuscarCategoria";
            TB_BuscarCategoria.Size = new Size(632, 38);
            TB_BuscarCategoria.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 77, 128);
            panel1.Controls.Add(B_GuardarCategoria);
            panel1.Controls.Add(B_Cancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 371);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 79);
            panel1.TabIndex = 7;
            // 
            // B_GuardarCategoria
            // 
            B_GuardarCategoria.AutoSize = true;
            B_GuardarCategoria.BackColor = Color.FromArgb(26, 77, 128);
            B_GuardarCategoria.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_GuardarCategoria.ForeColor = SystemColors.ButtonHighlight;
            B_GuardarCategoria.Image = Properties.Resources.salvar1;
            B_GuardarCategoria.Location = new Point(201, 3);
            B_GuardarCategoria.Name = "B_GuardarCategoria";
            B_GuardarCategoria.Size = new Size(191, 54);
            B_GuardarCategoria.TabIndex = 15;
            B_GuardarCategoria.Text = "Guardar";
            B_GuardarCategoria.TextAlign = ContentAlignment.MiddleRight;
            B_GuardarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_GuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.FlatAppearance.BorderSize = 0;
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(398, 3);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(191, 54);
            B_Cancelar.TabIndex = 14;
            B_Cancelar.Text = "  Cancelar ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // V_SeleccionarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(DGV_CategoriasInventario);
            Controls.Add(panelSuperiorProv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_SeleccionarCategoria";
            Text = "Seleccionar Categoria";
            ((System.ComponentModel.ISupportInitialize)DGV_CategoriasInventario).EndInit();
            panelSuperiorProv.ResumeLayout(false);
            panelSuperiorProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_CategoriasInventario;
        private Panel panelSuperiorProv;
        private PictureBox pictureBox1;
        private Button button3;
        private TextBox TB_BuscarCategoria;
        private Panel panel1;
        private Button B_GuardarCategoria;
        private Button B_Cancelar;
    }
}