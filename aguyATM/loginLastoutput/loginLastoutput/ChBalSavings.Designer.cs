namespace loginLastoutput
{
    partial class ChBalSavings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChBalSavings));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            proceedBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtCurrentBalSavings = new Label();
            label1 = new Label();
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
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // proceedBtn
            // 
            proceedBtn.BorderColor = Color.DarkCyan;
            proceedBtn.BorderRadius = 15;
            proceedBtn.BorderThickness = 2;
            proceedBtn.CustomizableEdges = customizableEdges1;
            proceedBtn.DisabledState.BorderColor = Color.DarkGray;
            proceedBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            proceedBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            proceedBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            proceedBtn.FillColor = Color.DarkSlateGray;
            proceedBtn.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proceedBtn.ForeColor = Color.White;
            proceedBtn.Location = new Point(408, 303);
            proceedBtn.Name = "proceedBtn";
            proceedBtn.PressedColor = Color.DarkCyan;
            proceedBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            proceedBtn.Size = new Size(236, 45);
            proceedBtn.TabIndex = 12;
            proceedBtn.Text = "Proceed to Merchant";
            proceedBtn.Click += proceedBtn_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel1.Location = new Point(408, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(222, 30);
            guna2HtmlLabel1.TabIndex = 13;
            guna2HtmlLabel1.Text = "Transaction Summary";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel2.Location = new Point(384, 48);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(423, 38);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "-----------------------------------";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel3.Location = new Point(408, 148);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(171, 30);
            guna2HtmlLabel3.TabIndex = 15;
            guna2HtmlLabel3.Text = "Current Balance:";
            // 
            // txtCurrentBalSavings
            // 
            txtCurrentBalSavings.AutoSize = true;
            txtCurrentBalSavings.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentBalSavings.Location = new Point(408, 200);
            txtCurrentBalSavings.Name = "txtCurrentBalSavings";
            txtCurrentBalSavings.Size = new Size(32, 32);
            txtCurrentBalSavings.TabIndex = 16;
            txtCurrentBalSavings.Text = "...";
            txtCurrentBalSavings.Click += txtCurrentBal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(549, 89);
            label1.Name = "label1";
            label1.Size = new Size(112, 36);
            label1.TabIndex = 17;
            label1.Text = "Savings";
            // 
            // ChBalSavings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(805, 360);
            Controls.Add(label1);
            Controls.Add(txtCurrentBalSavings);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(proceedBtn);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChBalSavings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChBalSavings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button proceedBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Label txtCurrentBalSavings;
        private Label label1;
    }
}