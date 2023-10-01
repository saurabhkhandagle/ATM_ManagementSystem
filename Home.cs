using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            Deposit d=new Deposit();
            d.Show();
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {
            FastCash fc=new FastCash();
            fc.Show();  
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            ChangePin changePin=new ChangePin();
            changePin.Show();
        }

        private void btnWithdrow_Click(object sender, EventArgs e)
        {
            Withdrow withdrow=new Withdrow();
            withdrow.Show();
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            MiniStatement m = new MiniStatement();
            m.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance bal=new Balance();
            bal.Show();
        }
    }
}
