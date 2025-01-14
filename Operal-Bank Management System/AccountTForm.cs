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
    public partial class AccountTForm : Form
    {
        double id;
        //string tbname = "account_type";

        public AccountTForm()
        {
            InitializeComponent();
        }

        void clear() 
        {
            increment();
            txtType.Clear();
            txtROI.Clear();
            load();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            increment();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("You have not specified Name properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Focus();
                return;
            }
            if (txtType.Text == "")
            {
                MessageBox.Show("You have not specified Type properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }
            if (txtROI.Text == "")
            {
                MessageBox.Show("You have not specified Rate of interest properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtROI.Focus();
                return;
            }
            myClass.connect();
            myClass.cmd.CommandText = "insert into account_type(id,type,roi )values(?,?,?)";
            myClass.cmd.Parameters.AddWithValue("id", txtid.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("type", txtType.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("roi", txtROI.Text.Trim());
            myClass.cmd.ExecuteNonQuery();
            myClass.disconnect();
            MessageBox.Show("Account type is created  Successfully!!!!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            load();
            increment();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCreate.Enabled = false;
            txtType.Enabled = false;
            txtROI.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                MessageBox.Show("You have not specified Account Type Id properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }
            string tbname = "account_type";
            string id = CBAid.Text;
            myClass.deleteFun(tbname, id);
            clear();
            increment();
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                MessageBox.Show("You have not specified Type properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }
            if (txtROI.Text == "")
            {
                MessageBox.Show("You have not specified Rate of interest properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtROI.Focus();
                return;
            }
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "update account_type set type=?,roi=? where id='" + txtid.Text + "'";
                myClass.cmd.Parameters.AddWithValue("type", txtType.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("roi", txtROI.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
                MessageBox.Show("Record Updated Successfully!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                increment();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtidS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtROI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Enter ROI in digits only", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CBAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from account_type where id='" + CBAid.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtid.Text = myClass.buff[0].ToString();
            txtType.Text = myClass.buff[1].ToString();
            txtROI.Text = myClass.buff[2].ToString();
            myClass.buff.Close();
            myClass.disconnect();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCreate.Enabled = false;
            txtType.Enabled = true;
            txtROI.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        void load()
        {
            myClass.loadlist("account_type", CBAid,"id");
        }

        void increment()
        {
            string tbname = "account_type";
            double id = myClass.IncrementF(tbname);
            txtid.Text = id.ToString("000");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            increment();
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtType.Enabled = true;
            txtROI.Enabled = true;
            txtType.Focus();

        }
    }
}
