namespace POS_CHITOS
{
    partial class V_MostrarCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MostrarCambio));
            panel2 = new Panel();
            B_Confirmar = new Button();
            TB_Cambio = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(B_Confirmar);
            panel2.Controls.Add(TB_Cambio);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 7;
            // 
            // B_Confirmar
            // 
            B_Confirmar.AutoSize = true;
            B_Confirmar.BackColor = Color.FromArgb(26, 77, 128);
            B_Confirmar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Confirmar.ForeColor = SystemColors.ButtonHighlight;
            B_Confirmar.Location = new Point(250, 289);
            B_Confirmar.Name = "B_Confirmar";
            B_Confirmar.Size = new Size(242, 77);
            B_Confirmar.TabIndex = 5;
            B_Confirmar.Text = "Aceptar (Enter)";
            B_Confirmar.TextImageRelation = TextImageRelation.ImageAboveText;
            B_Confirmar.UseVisualStyleBackColor = false;
            B_Confirmar.Click += B_Confirmar_Click;
            // 
            // TB_Cambio
            // 
            TB_Cambio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TB_Cambio.BackColor = Color.WhiteSmoke;
            TB_Cambio.Font = new Font("Arial Rounded MT Bold", 36F);
            TB_Cambio.ForeColor = Color.FromArgb(26, 77, 128);
            TB_Cambio.Location = new Point(159, 150);
            TB_Cambio.Name = "TB_Cambio";
            TB_Cambio.ReadOnly = true;
            TB_Cambio.Size = new Size(436, 77);
            TB_Cambio.TabIndex = 3;
            TB_Cambio.TextAlign = HorizontalAlignment.Center;
            TB_Cambio.KeyDown += TB_Cambio_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 43);
            label4.Name = "label4";
            label4.Size = new Size(539, 81);
            label4.TabIndex = 4;
            label4.Text = "Entregar al cliente:";
            // 
            // V_MostrarCambio
            // 
            AcceptButton = B_Confirmar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_MostrarCambio";
            Text = "Entregar cambio";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button B_Confirmar;
        private TextBox TB_Cambio;
        private Label label4;
    }
}