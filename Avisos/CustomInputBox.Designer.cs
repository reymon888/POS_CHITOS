namespace POS_CHITOS.Avisos
{
    partial class CustomInputBox
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
            panel4 = new Panel();
            TB_Input = new TextBox();
            panel3 = new Panel();
            B_OK = new Button();
            B_Cancelar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            lblMessage = new TextBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMessage);
            panel4.Controls.Add(TB_Input);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 274);
            panel4.TabIndex = 0;
            // 
            // TB_Input
            // 
            TB_Input.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TB_Input.Location = new Point(238, 137);
            TB_Input.Name = "TB_Input";
            TB_Input.Size = new Size(295, 87);
            TB_Input.TabIndex = 1;
            TB_Input.TextAlign = HorizontalAlignment.Center;
            TB_Input.KeyDown += TB_Input_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(B_OK);
            panel3.Controls.Add(B_Cancelar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 362);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 88);
            panel3.TabIndex = 0;
            // 
            // B_OK
            // 
            B_OK.AutoSize = true;
            B_OK.BackColor = Color.FromArgb(26, 77, 128);
            B_OK.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_OK.ForeColor = SystemColors.ButtonHighlight;
            B_OK.Location = new Point(171, 6);
            B_OK.Name = "B_OK";
            B_OK.Size = new Size(191, 70);
            B_OK.TabIndex = 2;
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
            B_Cancelar.Location = new Point(436, 6);
            B_Cancelar.Name = "B_Cancelar";
            B_Cancelar.Size = new Size(191, 70);
            B_Cancelar.TabIndex = 3;
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
            panel2.Size = new Size(800, 88);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(286, 17);
            label1.Name = "label1";
            label1.Size = new Size(205, 46);
            label1.TabIndex = 0;
            label1.Text = "Advertencia";
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.WhiteSmoke;
            lblMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(26, 77, 128);
            lblMessage.Location = new Point(0, 23);
            lblMessage.Multiline = true;
            lblMessage.Name = "lblMessage";
            lblMessage.ReadOnly = true;
            lblMessage.Size = new Size(793, 94);
            lblMessage.TabIndex = 4;
            lblMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomInputBox
            // 
            AcceptButton = B_OK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "CustomInputBox";
            Text = "CustomInputBox";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox TB_Input;
        private Panel panel3;
        private Button B_OK;
        private Button B_Cancelar;
        private Panel panel2;
        private Label label1;
        private TextBox lblMessage;
    }
}