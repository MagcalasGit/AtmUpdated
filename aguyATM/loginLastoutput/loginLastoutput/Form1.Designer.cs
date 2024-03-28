namespace loginLastoutput
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            BtnLogIn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ShowHid = new Guna.UI2.WinForms.Guna2CheckBox();
            clearBtn = new Guna.UI2.WinForms.Guna2Button();
            cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BorderColor = Color.DarkSlateGray;
            txtUser.BorderRadius = 20;
            txtUser.BorderThickness = 2;
            txtUser.CustomizableEdges = customizableEdges1;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Black;
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(32, 427);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PlaceholderForeColor = Color.DarkGray;
            txtUser.PlaceholderText = "Username";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUser.Size = new Size(322, 50);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.BorderColor = Color.DarkSlateGray;
            txtPass.BorderRadius = 20;
            txtPass.BorderThickness = 2;
            txtPass.CustomizableEdges = customizableEdges3;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.Black;
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(32, 485);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '\0';
            txtPass.PlaceholderForeColor = Color.DarkGray;
            txtPass.PlaceholderText = "Password";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPass.Size = new Size(322, 48);
            txtPass.TabIndex = 2;
            // 
            // BtnLogIn
            // 
            BtnLogIn.BackColor = Color.Transparent;
            BtnLogIn.BorderColor = Color.Teal;
            BtnLogIn.BorderRadius = 15;
            BtnLogIn.BorderThickness = 2;
            BtnLogIn.CustomizableEdges = customizableEdges5;
            BtnLogIn.DisabledState.BorderColor = Color.DarkGray;
            BtnLogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnLogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnLogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnLogIn.FillColor = Color.DarkSlateGray;
            BtnLogIn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogIn.ForeColor = Color.White;
            BtnLogIn.Location = new Point(42, 602);
            BtnLogIn.Name = "BtnLogIn";
            BtnLogIn.PressedColor = Color.DarkCyan;
            BtnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnLogIn.Size = new Size(84, 34);
            BtnLogIn.TabIndex = 3;
            BtnLogIn.Text = "Log in";
            BtnLogIn.Click += BtnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(108, 380);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 4;
            label1.Text = "Atubaw ATM";
            // 
            // ShowHid
            // 
            ShowHid.AutoSize = true;
            ShowHid.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ShowHid.CheckedState.BorderRadius = 0;
            ShowHid.CheckedState.BorderThickness = 0;
            ShowHid.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ShowHid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowHid.ForeColor = Color.DarkSlateGray;
            ShowHid.Location = new Point(42, 540);
            ShowHid.Name = "ShowHid";
            ShowHid.Size = new Size(112, 19);
            ShowHid.TabIndex = 5;
            ShowHid.Text = "Show Password";
            ShowHid.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ShowHid.UncheckedState.BorderRadius = 0;
            ShowHid.UncheckedState.BorderThickness = 0;
            ShowHid.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ShowHid.CheckedChanged += ShowHid_CheckedChanged;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Transparent;
            clearBtn.BorderColor = Color.Teal;
            clearBtn.BorderRadius = 15;
            clearBtn.BorderThickness = 2;
            clearBtn.CustomizableEdges = customizableEdges7;
            clearBtn.DisabledState.BorderColor = Color.DarkGray;
            clearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            clearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearBtn.FillColor = Color.DarkSlateGray;
            clearBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(148, 602);
            clearBtn.Name = "clearBtn";
            clearBtn.PressedColor = Color.DarkCyan;
            clearBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            clearBtn.Size = new Size(84, 34);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.Click += clearBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.BorderColor = Color.Teal;
            cancelBtn.BorderRadius = 15;
            cancelBtn.BorderThickness = 2;
            cancelBtn.CustomizableEdges = customizableEdges9;
            cancelBtn.DisabledState.BorderColor = Color.DarkGray;
            cancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            cancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cancelBtn.FillColor = Color.DarkSlateGray;
            cancelBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(252, 602);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.PressedColor = Color.DarkCyan;
            cancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cancelBtn.Size = new Size(84, 34);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.Click += cancelBtn_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(391, 658);
            Controls.Add(cancelBtn);
            Controls.Add(clearBtn);
            Controls.Add(ShowHid);
            Controls.Add(label1);
            Controls.Add(BtnLogIn);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2Button BtnLogIn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox ShowHid;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
    }
}
