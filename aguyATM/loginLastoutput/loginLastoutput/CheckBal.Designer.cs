namespace loginLastoutput
{
    partial class CheckBal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBal));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            chequeBtn = new Guna.UI2.WinForms.Guna2Button();
            SavingsBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -1);
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
            label1.Location = new Point(96, 375);
            label1.Name = "label1";
            label1.Size = new Size(197, 36);
            label1.TabIndex = 8;
            label1.Text = "Check Balance";
            // 
            // cancelBtn
            // 
            cancelBtn.BorderColor = Color.DarkCyan;
            cancelBtn.BorderRadius = 15;
            cancelBtn.BorderThickness = 2;
            cancelBtn.CustomizableEdges = customizableEdges1;
            cancelBtn.DisabledState.BorderColor = Color.DarkGray;
            cancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelBtn.FillColor = Color.DarkSlateGray;
            cancelBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(96, 539);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.PressedColor = Color.DarkCyan;
            cancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cancelBtn.Size = new Size(197, 45);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.Click += cancelBtn_Click;
            // 
            // chequeBtn
            // 
            chequeBtn.BorderColor = Color.DarkCyan;
            chequeBtn.BorderRadius = 15;
            chequeBtn.BorderThickness = 2;
            chequeBtn.CustomizableEdges = customizableEdges3;
            chequeBtn.DisabledState.BorderColor = Color.DarkGray;
            chequeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            chequeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            chequeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            chequeBtn.FillColor = Color.DarkSlateGray;
            chequeBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chequeBtn.ForeColor = Color.White;
            chequeBtn.Location = new Point(96, 488);
            chequeBtn.Name = "chequeBtn";
            chequeBtn.PressedColor = Color.DarkCyan;
            chequeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            chequeBtn.Size = new Size(197, 45);
            chequeBtn.TabIndex = 10;
            chequeBtn.Text = "Cheque";
            chequeBtn.Click += chequeBtn_Click;
            // 
            // SavingsBtn
            // 
            SavingsBtn.BorderColor = Color.DarkCyan;
            SavingsBtn.BorderRadius = 15;
            SavingsBtn.BorderThickness = 2;
            SavingsBtn.CustomizableEdges = customizableEdges5;
            SavingsBtn.DisabledState.BorderColor = Color.DarkGray;
            SavingsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SavingsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SavingsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SavingsBtn.FillColor = Color.DarkSlateGray;
            SavingsBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SavingsBtn.ForeColor = Color.White;
            SavingsBtn.Location = new Point(96, 437);
            SavingsBtn.Name = "SavingsBtn";
            SavingsBtn.PressedColor = Color.DarkCyan;
            SavingsBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SavingsBtn.Size = new Size(197, 45);
            SavingsBtn.TabIndex = 9;
            SavingsBtn.Text = "Savings";
            SavingsBtn.Click += SavingsBtn_Click;
            // 
            // CheckBal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(390, 620);
            Controls.Add(cancelBtn);
            Controls.Add(chequeBtn);
            Controls.Add(SavingsBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CheckBal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBal";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button chequeBtn;
        private Guna.UI2.WinForms.Guna2Button SavingsBtn;
    }
}