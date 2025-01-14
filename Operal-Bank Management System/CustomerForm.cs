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
    public partial class CustomerForm : Form
    {

        
        
        
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clear();
            myClass.updateCF.TopLevel = false;
            pnlCustomer.Controls.Add(myClass.updateCF);
            myClass.updateCF.BringToFront();
            myClass.updateCF.Show();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            btnReg.Focus();
            myClass.updateCF.Hide();
        }

        void clear()
        {
            txtname.Clear();
            dobpicker.ResetText();
            txtaddress.Clear();
            CBgender.SelectedIndex = 0;
            txtEmailid.Clear();
            txtMobno.Clear();
            increment();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
          
            if (txtname.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                return;
            }
            if (DateTime.Today <= dobpicker.Value)
            {
                MessageBox.Show("Please select your DOB", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dobpicker.Focus();
                return;
            }
            if (txtaddress.Text == "")
            {
                MessageBox.Show("You have not specified Address ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtaddress.Focus();
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
                MessageBox.Show("You have not specified email id", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailid.Focus();
                return;
            }
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[com]{2,9})$";
            //pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmailid.Text, pattern))
            {
            }
            else
            {
                MessageBox.Show("Not Valid email Address");
                txtEmailid.Focus();
                return;
            }
            if (txtMobno.Text == "" || txtMobno.TextLength < 10)
            {
                MessageBox.Show("You have not specified Mobile Number properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobno.Focus();
                return;
            }
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "insert into customerTb(id,name,dob,address,gender,email_id,mobile_no)values(?,?,?,?,?,?,?)";
                myClass.cmd.Parameters.AddWithValue("id", txtid.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("name", txtname.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("dob", dobpicker.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("address", txtaddress.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("gender", CBgender.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("email_id", txtEmailid.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("mobile_no", txtMobno.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
                //File.Copy(str, Path.Combine(@"D:\sanket\Operal-Bank Management System\Operal-Bank Management System\AImages\", Path.GetFileName(str)), true);
                MessageBox.Show("Registration is Successfully!!!!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                increment();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }
            //str = open.FileName;
            
        }

        void increment()
        {
            string tbname = "customerTb";
            double id = myClass.IncrementF(tbname);
            txtid.Text = id.ToString("000");
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            increment();
            //txtname.Focus();
            
            dobpicker.Value=DateTime.Today;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clear();
            myClass.deleteF.ShowDialog();
         
        }

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobno_TextChanged(object sender, EventArgs e)
        {
            if(txtMobno.TextLength==10)
            {
                txtMobno.FillColor = Color.FromArgb(0, 0, 192);

            }
            else
            {
                txtMobno.FillColor = Color.Red;
            }
        }

        private void CustomerForm_Shown(object sender, EventArgs e)
        {
            txtname.Focus();
        }
    }
}
