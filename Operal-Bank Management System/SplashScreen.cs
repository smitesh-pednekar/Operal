using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlload.Width = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<77;i++)
            {
                pnlload.Width = pnlload.Width + 6;
                Thread.Sleep(20);
            }
            timer1.Stop();
            Thread.Sleep(100);
            this.Hide();
            myClass.LoginF.Show();
        }
    }
}
