using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginLastoutput
{
    public partial class FormLogIn : Form
    {
        private int maxLoginAttempts = 3;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void ShowHid_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHid.Checked && txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "0000")
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                maxLoginAttempts--;
                if (maxLoginAttempts > 0)
                {
                    MessageBox.Show($"Incorrect username or passsword. You have {maxLoginAttempts} attempts remaining.");
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    AccDisbaled AccDisabledForm = new AccDisbaled();
                    AccDisabledForm.Show();
                    this.Hide();
                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
