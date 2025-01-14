using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void bthcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnforgotpass_Click(object sender, EventArgs e)
        {

        }

        private void CBSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSecurity.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
