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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void withdrawSavingsBtn_Click(object sender, EventArgs e)
        {
            withdrawSavingsForm withdrawSavings = new withdrawSavingsForm();
            this.Hide();
            withdrawSavings.Show();
        }

        private void withdrawChequeBtn_Click(object sender, EventArgs e)
        {
            withdrawChequeForm wihtdrawCheque = new withdrawChequeForm();
            this.Hide();
            wihtdrawCheque.Show();
        }
    }
}
