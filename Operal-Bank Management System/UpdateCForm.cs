using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Operal_Bank_Management_System
{
    public partial class UpdateCForm : Form
    {
        public UpdateCForm()
        {
            InitializeComponent();
        }

        private void UpdateCForm_Load(object sender, EventArgs e)
        {
            load();
        }

        void clear()
        {
            txtid.Clear();
            txtname.Clear();
            dobpicker.ResetText();
            txtaddress.Clear();
            CBgender.SelectedIndex = 0;
            txtEmailid.Clear();
            txtMobno.Clear();
            load();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                return;
            }
            if (dobpicker.Text == "")
            {
                MessageBox.Show("Please chose your DOB", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dobpicker.Focus();
                return;
            }
           
            if (CBgender.SelectedIndex == 0)
            {
                MessageBox.Show("You have not specified gender properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBgender.Focus();
                return;
            }
            if (txtEmailid.Text == "")
            {
                MessageBox.Show("You have not specified Email Id properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailid.Focus();
                return;
            }
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailid.Text, pattern))
            {
            }
            else
            {
                MessageBox.Show("Not Valid email Address");
                txtEmailid.Focus();
                return;
            }
            if (txtMobno.Text == "")
            {
                MessageBox.Show("You have not specified ID", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobno.Focus();
                return;
            }
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "update customerTb set name=?,dob=?,address=?,gender=?,email_id=?,mobile_no=? where id='" + CBcid.Text + "'";
                myClass.cmd.Parameters.AddWithValue("name", txtname.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("dob", dobpicker.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("address", txtaddress.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("gender", CBgender.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("email_id", txtEmailid.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("mobile_no", txtMobno.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
                MessageBox.Show("Record Updated Successfully!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }
        }
        void load()
        {
            myClass.loadlist("customerTb", CBcid,"id");
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from customerTb where id='" + CBcid.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtid.Text = myClass.buff[0].ToString();
            txtname.Text = myClass.buff[1].ToString();
            dobpicker.Text = myClass.buff[2].ToString();
            txtaddress.Text = myClass.buff[3].ToString();
            CBgender.Text = myClass.buff[4].ToString();
            txtEmailid.Text = myClass.buff[5].ToString();
            txtMobno.Text = myClass.buff[6].ToString();
            myClass.buff.Close();
            myClass.disconnect();
            
            
            txtname.Enabled = true;
            dobpicker.Enabled = true;
            txtaddress.Enabled = true;
            CBgender.Enabled = true;
            txtEmailid.Enabled = true;
            txtMobno.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
            CBcid.Enabled = true;
            clear();
        }

        private void txtMobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Enter Contact Number in digits only", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Enter Alphabets only", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;

            }
        }
    }
}
