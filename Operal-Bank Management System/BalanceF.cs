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
    public partial class BalanceF : Form
    {
        public BalanceF()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtacNo.Text == "")
            {
                MessageBox.Show("You have not specified Account number properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtacNo.Focus();
                return;
            }
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "select init_balance from account_c where id = '" + txtacNo.Text + "' ";
                myClass.buff = myClass.cmd.ExecuteReader();
                myClass.buff.Read();
                lblBalance.Text = myClass.buff[0].ToString();
                myClass.buff.Close();
                myClass.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }
        }
    }
}
