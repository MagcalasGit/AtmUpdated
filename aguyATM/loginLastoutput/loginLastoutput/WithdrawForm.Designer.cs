namespace loginLastoutput
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            withdrawSavingsBtn = new Guna.UI2.WinForms.Guna2Button();
            withdrawChequeBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(393, 363);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(121, 379);
            label1.Name = "label1";
            label1.Size = new Size(138, 36);
            label1.TabIndex = 8;
            label1.Text = "Withdraw";
            // 
            // withdrawSavingsBtn
            // 
            withdrawSavingsBtn.BorderColor = Color.DarkCyan;
            withdrawSavingsBtn.BorderRadius = 15;
            withdrawSavingsBtn.BorderThickness = 2;
            withdrawSavingsBtn.CustomizableEdges = customizableEdges1;
            withdrawSavingsBtn.DisabledState.BorderColor = Color.DarkGray;
            withdrawSavingsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            withdrawSavingsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            withdrawSavingsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            withdrawSavingsBtn.FillColor = Color.DarkSlateGray;
            withdrawSavingsBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawSavingsBtn.ForeColor = Color.White;
            withdrawSavingsBtn.Location = new Point(97, 449);
            withdrawSavingsBtn.Name = "withdrawSavingsBtn";
            withdrawSavingsBtn.PressedColor = Color.DarkCyan;
            withdrawSavingsBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            withdrawSavingsBtn.Size = new Size(180, 45);
            withdrawSavingsBtn.TabIndex = 9;
            withdrawSavingsBtn.Text = "Savings";
            withdrawSavingsBtn.Click += withdrawSavingsBtn_Click;
            // 
            // withdrawChequeBtn
            // 
            withdrawChequeBtn.BorderColor = Color.DarkCyan;
            withdrawChequeBtn.BorderRadius = 15;
            withdrawChequeBtn.BorderThickness = 2;
            withdrawChequeBtn.CustomizableEdges = customizableEdges3;
            withdrawChequeBtn.DisabledState.BorderColor = Color.DarkGray;
            withdrawChequeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            withdrawChequeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            withdrawChequeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            withdrawChequeBtn.FillColor = Color.DarkSlateGray;
            withdrawChequeBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawChequeBtn.ForeColor = Color.White;
            withdrawChequeBtn.Location = new Point(97, 514);
            withdrawChequeBtn.Name = "withdrawChequeBtn";
            withdrawChequeBtn.PressedColor = Color.DarkCyan;
            withdrawChequeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            withdrawChequeBtn.Size = new Size(180, 45);
            withdrawChequeBtn.TabIndex = 10;
            withdrawChequeBtn.Text = "Cheque";
            withdrawChequeBtn.Click += withdrawChequeBtn_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(391, 628);
            Controls.Add(withdrawChequeBtn);
            Controls.Add(withdrawSavingsBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WithdrawForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithdrawForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button withdrawSavingsBtn;
        private Guna.UI2.WinForms.Guna2Button withdrawChequeBtn;
    }
}