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
    public partial class ThanksPage : Form
    {
        public ThanksPage()
        {
            InitializeComponent();
        }

        private void ThanksPage_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 60 * 1); // 1 mins
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hii.Text = (int.Parse(hii.Text) - 1).ToString();
            if (int.Parse(hii.Text) == 0)  //if the countdown reaches '0', we stop it

            {
                //  MessageBox.Show("The form will now be closed.", "Time Elapsed");

               Application.Exit();
            }


        }
    }
}
