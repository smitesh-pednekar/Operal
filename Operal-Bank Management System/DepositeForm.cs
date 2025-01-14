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
    public partial class DepositeForm : Form
    {
        public DepositeForm()
        {
            InitializeComponent();
        }

        private void DepositeForm_Load(object sender, EventArgs e)
        {
            load();
        }

        void clear()
        {
            txtcid.Clear();
            txtacno.Clear();
            txtoldB.Clear();
            txtDamt.Clear();
            textnewB.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtmobileno.Clear();

        }
        private void Searchicon_Click(object sender, EventArgs e)
        {
            //myClass.connect();
            //myClass.cmd.CommandText = "select ac.id,ac.cid,ac.init_balance,c.name,c.address,c.gender,c.email_id,c.mobile_no from account_c ac,customerTb c where ac.id='" + txtacno.Text + "' and ac.cid=c.id";
            //myClass.buff = myClass.cmd.ExecuteReader();
            //myClass.buff.Read();
            //txtcid.Text = myClass.buff[1].ToString();
            //txtoldB.Text = myClass.buff[2].ToString();
            //txtname.Text = myClass.buff[3].ToString();
            //txtaddress.Text = myClass.buff[4].ToString();
            //txtemail.Text = myClass.buff[6].ToString();
            //txtmobileno.Text = myClass.buff[7].ToString();
            //myClass.buff.Close();
            //myClass.disconnect();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            //if (txtDamt.TextLength > txtoldB.TextLength)
            //{
            //    MessageBox.Show("Your don't have sufficient balance in your account to Withdraw!!!! ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //    if (Convert.ToInt32(txtoldB.Text) < Convert.ToInt32(txtDamt.Text))
            //    {
            //        MessageBox.Show("Your don't have sufficient balance in your account to Withdraw!!!! ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    else
            //    {
                    int newB = Convert.ToInt32(txtoldB.Text.ToString()) + Convert.ToInt32(txtDamt.Text.ToString());
                    textnewB.Text = newB.ToString();
                    myClass.connect();
                    myClass.cmd.CommandText = "insert into deposit(Account_No,cid,Deposit_Amount,New_Balance)values(?,?,?,?)";
                    myClass.cmd.Parameters.AddWithValue("Account_No", CBAid.Text.Trim());
                    myClass.cmd.Parameters.AddWithValue("cid", txtcid.Text.Trim());
                    myClass.cmd.Parameters.AddWithValue("Withdraw_Amount", txtDamt.Text.Trim());
                    myClass.cmd.Parameters.AddWithValue("New_Balance", textnewB.Text.Trim());
                    myClass.cmd.ExecuteNonQuery();
                    myClass.disconnect();

                    myClass.connect();
                    myClass.cmd.CommandText = "update account_c set init_balance=? where id='" + CBAid.Text + "'";
                    myClass.cmd.Parameters.AddWithValue("init_balance", textnewB.Text.Trim());
                    myClass.cmd.ExecuteNonQuery();
                    myClass.disconnect();
                    MessageBox.Show("Deposit is Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                    load();
                //}
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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

        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textnewB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Enter Deposit Amount in digits only", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }


        void load()
        {
            myClass.loadlist("account_c", CBAid, "id");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        private void CBAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "select ac.id,ac.cid,ac.init_balance,c.name,c.address,c.gender,c.email_id,c.mobile_no from account_c ac,customerTb c where ac.id='" + CBAid.Text + "' and ac.cid=c.id";
                myClass.buff = myClass.cmd.ExecuteReader();
                myClass.buff.Read();
                txtcid.Text = myClass.buff[1].ToString();
                txtoldB.Text = myClass.buff[2].ToString();
                txtname.Text = myClass.buff[3].ToString();
                txtaddress.Text = myClass.buff[4].ToString();
                txtGender.Text = myClass.buff[5].ToString();
                txtemail.Text = myClass.buff[6].ToString();
                txtmobileno.Text = myClass.buff[7].ToString();
                myClass.buff.Close();
                myClass.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
                load();
            }
        }

        
    }
}
