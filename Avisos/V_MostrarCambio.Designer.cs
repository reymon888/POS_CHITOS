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
            panel2 = new Panel();
            B_Confirmar = new Button();
            TB_Cambio = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
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
            B_Confirmar.BackColor = Color.FromArgb(192, 255, 192);
            B_Confirmar.Font = new Font("Arial", 18F, FontStyle.Bold);
            B_Confirmar.Image = Properties.Resources.aceptar__1_;
            B_Confirmar.Location = new Point(264, 253);
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
            TB_Cambio.Font = new Font("Arial Rounded MT Bold", 36F);
            TB_Cambio.Location = new Point(186, 118);
            TB_Cambio.Name = "TB_Cambio";
            TB_Cambio.Size = new Size(436, 77);
            TB_Cambio.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 36F);
            label4.Location = new Point(291, 36);
            label4.Name = "label4";
            label4.Size = new Size(215, 70);
            label4.TabIndex = 4;
            label4.Text = "Recibi";
            // 
            // V_MostrarCambio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "V_MostrarCambio";
            Text = "V_MostrarCambio";
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