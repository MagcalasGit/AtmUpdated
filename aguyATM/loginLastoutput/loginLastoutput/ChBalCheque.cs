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
    public partial class ChBalCheque : Form
    {
        public ChBalCheque()
        {
            InitializeComponent();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            MainPage backToMain = new MainPage();
            this.Hide();
            backToMain.Show();
        }

        private void txtCurrentBalCheuqe_Click(object sender, EventArgs e)
        {

        }
    }
}
