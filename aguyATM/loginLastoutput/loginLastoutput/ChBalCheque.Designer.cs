namespace loginLastoutput
{
    partial class ChBalCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChBalCheque));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtCurrentBalCheuqe = new Label();
            proceedBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(393, 363);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel1.Location = new Point(408, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(222, 30);
            guna2HtmlLabel1.TabIndex = 14;
            guna2HtmlLabel1.Text = "Transaction Summary";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel2.Location = new Point(386, 48);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(423, 38);
            guna2HtmlLabel2.TabIndex = 15;
            guna2HtmlLabel2.Text = "-----------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(550, 89);
            label1.Name = "label1";
            label1.Size = new Size(112, 36);
            label1.TabIndex = 18;
            label1.Text = "Cheque";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.DarkSlateGray;
            guna2HtmlLabel3.Location = new Point(408, 145);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(171, 30);
            guna2HtmlLabel3.TabIndex = 19;
            guna2HtmlLabel3.Text = "Current Balance:";
            // 
            // txtCurrentBalCheuqe
            // 
            txtCurrentBalCheuqe.AutoSize = true;
            txtCurrentBalCheuqe.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentBalCheuqe.Location = new Point(408, 198);
            txtCurrentBalCheuqe.Name = "txtCurrentBalCheuqe";
            txtCurrentBalCheuqe.Size = new Size(32, 32);
            txtCurrentBalCheuqe.TabIndex = 20;
            txtCurrentBalCheuqe.Text = "...";
            txtCurrentBalCheuqe.Click += txtCurrentBalCheuqe_Click;
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
            proceedBtn.TabIndex = 21;
            proceedBtn.Text = "Proceed to Merchant";
            proceedBtn.Click += proceedBtn_Click;
            // 
            // ChBalCheque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(805, 360);
            Controls.Add(proceedBtn);
            Controls.Add(txtCurrentBalCheuqe);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(label1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChBalCheque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChBalCheque";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Label txtCurrentBalCheuqe;
        private Guna.UI2.WinForms.Guna2Button proceedBtn;
    }
}