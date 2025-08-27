namespace POS_CHITOS.Avisos
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            panel1 = new Panel();
            panel4 = new Panel();
            lblMessage = new TextBox();
            panel3 = new Panel();
            B_OK = new Button();
            B_Cancelar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 336);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMessage);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(940, 160);
            panel4.TabIndex = 18;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.WhiteSmoke;
            lblMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(26, 77, 128);
            lblMessage.Location = new Point(74, 3);
            lblMessage.Multiline = true;
            lblMessage.Name = "lblMessage";
            lblMessage.ReadOnly = true;
            lblMessage.Size = new Size(793, 131);
            lblMessage.TabIndex = 3;
            lblMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(B_OK);
            panel3.Controls.Add(B_Cancelar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(940, 88);
            panel3.TabIndex = 17;
            // 
            // B_OK
            // 
            B_OK.AutoSize = true;
            B_OK.BackColor = Color.FromArgb(26, 77, 128);
            B_OK.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_OK.ForeColor = SystemColors.ButtonHighlight;
            B_OK.Location = new Point(253, 3);
            B_OK.Name = "B_OK";
            B_OK.Size = new Size(191, 70);
            B_OK.TabIndex = 16;
            B_OK.Text = "OK";
            B_OK.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_OK.UseVisualStyleBackColor = false;
            B_OK.Click += B_OK_Click;
            // 
            // B_Cancelar
            // 
            B_Cancelar.AutoSize = true;
            B_Cancelar.BackColor = Color.Silver;
            B_Cancelar.FlatAppearance.BorderSize = 0;
            B_Cancelar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Cancelar.Image = Properties.Resources.cerrar;
            B_Cancelar.Location = new Point(470, 6);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(191, 70);
            B_Cancelar.TabIndex = 14;
            B_Cancelar.Text = "  Cancelar ";
            B_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            B_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Cancelar.UseVisualStyleBackColor = false;
            B_Cancelar.Click += B_Cancelar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 77, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 88);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(391, 16);
            label1.Name = "label1";
            label1.Size = new Size(149, 46);
            label1.TabIndex = 1;
            label1.Text = "Mensaje";
            // 
            // CustomMessageBox
            // 
            AcceptButton = B_OK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(940, 336);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBox";
            Text = "Mensaje";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button B_OK;
        private Panel panel2;
        private Label label1;
        private Button B_Cancelar;
        private Panel panel4;
        private Panel panel3;
        private TextBox lblMessage;
    }
}