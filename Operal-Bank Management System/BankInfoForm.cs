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
    public partial class BankInfoForm : Form
    {
        public BankInfoForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BankInfoForm_Load(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            BrCodetxt.Clear();
            BNametxt.Clear();
            BrNametxt.Clear();
            IFSCtxt.Clear();
            Addresstxt.Clear();
            txtStreet.Clear();
            Citytxt.Clear();
            Pincodetxt.Clear();
        }
        void selectBinfo()
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from Bank_info";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            BrCodetxt.Text = myClass.buff[0].ToString();
            BNametxt.Text = myClass.buff[1].ToString();
            BrNametxt.Text = myClass.buff[2].ToString();
            IFSCtxt.Text = myClass.buff[3].ToString();
            Addresstxt.Text = myClass.buff[4].ToString();
            txtStreet.Text = myClass.buff[5].ToString();
            Citytxt.Text = myClass.buff[6].ToString();
            Pincodetxt.Text = myClass.buff[7].ToString();
            myClass.buff.Close();
            myClass.disconnect();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BrCodetxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BrCodetxt.Focus();
                return;
            }
            if (BNametxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BNametxt.Focus();
                return;
            }
            if (BrNametxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BNametxt.Focus();
                return;
            }
            if (IFSCtxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IFSCtxt.Focus();
                return;
            }
            if (Addresstxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Addresstxt.Focus();
                return;
            }
            if (txtStreet.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStreet.Focus();
                return;
            } 
            if (Citytxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Citytxt.Focus();
                return;
            }
            if (Pincodetxt.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pincodetxt.Focus();
                return;
            }

            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "update Bank_info set  Branch_code=?,Bank_name=?,Branch_Name=?,IFSC_code=?,Address=?,Street=?,city=?,pincode=?";
                myClass.cmd.Parameters.AddWithValue(" Branch_code", BrCodetxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("Bank_name", BNametxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("Branch_Name", BrNametxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("IFSC_code", IFSCtxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("Address", Addresstxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("Street", txtStreet.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("city", Citytxt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("pincode", Pincodetxt.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
                MessageBox.Show("Record Updated Successfully!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception )
            {

            }
            
            
        }
    }
}
