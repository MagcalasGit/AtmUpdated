using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginLastoutput
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            FormLogIn loginPage = new FormLogIn();
            this.Hide();
            loginPage.Show();
        }

        private void CheckBalBTn_Click(object sender, EventArgs e)
        {
            CheckBal ChBalSection = new CheckBal();
            this.Hide();
            ChBalSection.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawSection = new WithdrawForm();
            this.Hide();
            withdrawSection.Show();
        }
    }
}
