namespace POS_CHITOS
{
    partial class V_RecibirPagoVenta
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
            B_Cancelar = new Button();
            B_Confirmar = new Button();
            TB_PagoRecibido = new TextBox();
            TB_TotalCobrar = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(B_Cancelar);
            panel2.Controls.Add(B_Confirmar);
            panel2.Controls.Add(TB_PagoRecibido);
            panel2.Controls.Add(TB_TotalCobrar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 515);
            panel2.TabIndex = 6;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_Cancelar.Font = new Font("Arial", 18F, FontStyle.Bold);
            B_Cancelar.Image = Properties.Resources.boton_x;
            B_Cancelar.Location = new Point(457, 385);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(216, 77);
            B_Cancelar.TabIndex = 6;
            B_Cancelar.Text = "Cancelar (F1)";
            B_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Cancelar.UseVisualStyleBackColor = false;
            // 
            // B_Confirmar
            // 
            B_Confirmar.AutoSize = true;
            B_Confirmar.BackColor = Color.FromArgb(192, 255, 192);
            B_Confirmar.Font = new Font("Arial", 18F, FontStyle.Bold);
            B_Confirmar.Image = Properties.Resources.aceptar__1_;
            B_Confirmar.Location = new Point(95, 385);
            B_Confirmar.Name = "B_Confirmar";
            B_Confirmar.Size = new Size(242, 77);
            B_Confirmar.TabIndex = 5;
            B_Confirmar.Text = "Aceptar (Enter)";
            B_Confirmar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Confirmar.UseVisualStyleBackColor = false;
            B_Confirmar.Click += B_Confirmar_Click;
            // 
            // TB_PagoRecibido
            // 
            TB_PagoRecibido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_PagoRecibido.Font = new Font("Arial Rounded MT Bold", 36F);
            TB_PagoRecibido.Location = new Point(153, 269);
            TB_PagoRecibido.Name = "TB_PagoRecibido";
            TB_PagoRecibido.Size = new Size(436, 77);
            TB_PagoRecibido.TabIndex = 3;
            // 
            // TB_TotalCobrar
            // 
            TB_TotalCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_TotalCobrar.Font = new Font("Arial Rounded MT Bold", 36F);
            TB_TotalCobrar.Location = new Point(153, 92);
            TB_TotalCobrar.Name = "TB_TotalCobrar";
            TB_TotalCobrar.Size = new Size(436, 77);
            TB_TotalCobrar.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 36F);
            label4.Location = new Point(279, 196);
            label4.Name = "label4";
            label4.Size = new Size(215, 70);
            label4.TabIndex = 4;
            label4.Text = "Recibi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 36F);
            label3.Location = new Point(134, 9);
            label3.Name = "label3";
            label3.Size = new Size(510, 70);
            label3.TabIndex = 3;
            label3.Text = "Total de la venta";
            // 
            // V_RecibirPagoVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 515);
            Controls.Add(panel2);
            Name = "V_RecibirPagoVenta";
            Text = "V_RecibirPagoVenta";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Cancelar;
        private Button B_Confirmar;
        private TextBox TB_PagoRecibido;
        private TextBox TB_TotalCobrar;
        private Label label4;
        private Label label3;
    }
}