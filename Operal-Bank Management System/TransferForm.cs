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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }


        void clear()
        {
            txttransno.Clear();
            txttransamt.Clear();
            txtfaccno.Clear();
            txttaccno.Clear();
            txtcid.Clear();
            txtcid1.Clear();
            txtname.Clear();
            txtname1.Clear();
            txtemail.Clear();
            txtemail1.Clear();
            txtname.Clear();
            txtbalance1.Clear();
            txtbalance2.Clear();
            textNewb1.Clear();
            textNewb2.Clear();

        }
        void increment()
        {
            string tbname = "transfer";
            double Transfer_No = myClass.IncrementF(tbname);
            txttransno.Text = Transfer_No.ToString();
        }
        private void TransferForm_Load(object sender, EventArgs e)
        {
            increment();
        }

        private void Searchicon1_Click(object sender, EventArgs e)
        {
            try
            {
            myClass.connect();
            myClass.cmd.CommandText = "select ac.id,ac.cid,c.name,c.email_id,ac.init_balance from account_c ac,customerTb c where ac.id='" + txtfaccno.Text + "' and ac.cid=c.id";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtcid.Text = myClass.buff[1].ToString();
            txtname.Text = myClass.buff[2].ToString();
            txtemail.Text = myClass.buff[3].ToString();
            txtbalance1.Text = myClass.buff[4].ToString();
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

        private void Searchicon2_Click(object sender, EventArgs e)
        {
            try { 
            myClass.connect();
            myClass.cmd.CommandText = "select ac.id,ac.cid,c.name,c.email_id,ac.init_balance from account_c ac,customerTb c where ac.id='" + txttaccno.Text + "' and ac.cid=c.id";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtcid1.Text = myClass.buff[1].ToString();
            txtname1.Text = myClass.buff[2].ToString();
            txtemail1.Text = myClass.buff[3].ToString();
            txtbalance2.Text = myClass.buff[4].ToString();
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
                if (Convert.ToInt32(txttransno.Text)> Convert.ToInt32(txtbalance1.Text))
                {
                    MessageBox.Show("Your don't have sufficient balance in your account to Withdraw!!!! ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
            {
                int newB = Convert.ToInt32(txtbalance1.Text.ToString()) - Convert.ToInt32(txttransamt.Text.ToString());
                textNewb1.Text = newB.ToString();
                myClass.connect();
                myClass.cmd.CommandText = "insert into transfer(id,Transfer_Amount,From_Account_No,To_Account_No)values(?,?,?,?)";
                myClass.cmd.Parameters.AddWithValue("id", txttransno.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("Transfer_Amount", txttransamt.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("From_Account_No", txtfaccno.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("To_Account_No", txttaccno.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();

                myClass.connect();
                myClass.cmd.CommandText = "update account_c set init_balance=? where id='" + txtfaccno.Text + "'";
                myClass.cmd.Parameters.AddWithValue("init_balance", textNewb1.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();

                int newC = Convert.ToInt32(txtbalance2.Text.ToString()) + Convert.ToInt32(txttransamt.Text.ToString());
                textNewb2.Text = newC.ToString();

                myClass.connect();
                myClass.cmd.CommandText = "update account_c set init_balance=? where id='" + txttaccno.Text + "'";
                myClass.cmd.Parameters.AddWithValue("init_balance", textNewb2.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();

                MessageBox.Show("Transfer is Successfull!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
           

        }

        private void txttransno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            increment();
        }

        private void txttransamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Enter digits only", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txttransamt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Enter digits only", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
