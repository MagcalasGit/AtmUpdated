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
    public partial class CheckBal : Form
    {
        public CheckBal()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainPage backmain = new MainPage();
            this.Hide();
            backmain.Show();
        }

        private void SavingsBtn_Click(object sender, EventArgs e)
        {
            ChBalSavings checkSavings = new ChBalSavings();
            this.Hide();
            checkSavings.Show();

        }

        private void chequeBtn_Click(object sender, EventArgs e)
        {
            ChBalCheque checkCheque = new ChBalCheque();
            this.Hide();
            checkCheque.Show();
        }
    }
}
