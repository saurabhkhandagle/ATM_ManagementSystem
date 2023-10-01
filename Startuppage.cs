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
    public partial class Startuppage : Form
    {
        public Startuppage()
        {
            InitializeComponent();
        }
        int start = 0;
        private void Startuppage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start +=1;
            progressBar1.Value = start;
            lblPercentage.Text=""+start+"%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value=0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();

            }
        }
    }
}
