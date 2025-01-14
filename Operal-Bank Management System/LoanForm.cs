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
    public partial class LoanForm : Form
    {
        LoanBorrowF loanBorrowF = new LoanBorrowF();
        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnLInstall_Click(object sender, EventArgs e)
        {
            loanBorrowF.Hide();
        }

        private void btnLBorrow_Click(object sender, EventArgs e)
        {
            
            loanBorrowF.TopLevel = false;
            pnlLoan.Controls.Add(loanBorrowF);
            loanBorrowF.BringToFront();
            loanBorrowF.Show();
        }



        private void CBgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select cid,loanamt,no_ofYear,Interest,MontlyPayment,TotalAmount,TotalPaid,loantype,RemainingA from loan where id='" + CBLid.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtcid.Text = myClass.buff[0].ToString();
            txtamt.Text = myClass.buff[1].ToString();
            txtyear.Text = myClass.buff[2].ToString();
            txtInterest.Text = myClass.buff[3].ToString();
            lblMpay.Text = myClass.buff[4].ToString();
            txtTpay.Text = myClass.buff[5].ToString();
            TxtPaidAmt.Text = myClass.buff[6].ToString();
            txtLtype.Text = myClass.buff[7].ToString();
            TxtRAmt.Text = myClass.buff[8].ToString();
            myClass.buff.Close();
            myClass.disconnect();

            myClass.connect();
            myClass.cmd.CommandText = "select name,address,gender,email_id,mobile_no from customerTb where id='" + txtcid.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtname.Text = myClass.buff[0].ToString();
            txtaddress.Text = myClass.buff[1].ToString();
            combogender.Text = myClass.buff[2].ToString();
            txtemail.Text = myClass.buff[3].ToString();
            txtmobileno.Text = myClass.buff[4].ToString();
            myClass.buff.Close();
            myClass.disconnect();
            txtinstallA.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //if (TxtRAmt.TextLength > txtinstallA.TextLength)
            //{
            //    MessageBox.Show("Your installment has crossed over limit!!!! ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (Convert.ToInt32(TxtRAmt.Text) < Convert.ToInt32(txtinstallA.Text))
            if (Convert.ToDouble(TxtRAmt.Text) < Convert.ToDouble(txtinstallA.Text))
            {
                MessageBox.Show("Your installment has crossed over limit!!!! ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                try
                {
                double RemainA = Convert.ToDouble(TxtRAmt.Text.ToString()) - Convert.ToDouble(txtinstallA.Text.ToString());
                double TotalP = Convert.ToDouble(TxtPaidAmt.Text.ToString()) + Convert.ToDouble(txtinstallA.Text.ToString());

                myClass.connect();
                myClass.cmd.CommandText = "update loan set totalpaid=? where id='" + CBLid.Text + "'";
                myClass.cmd.Parameters.AddWithValue("totalpaid", txtinstallA.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
                MessageBox.Show("Loan install ment amount is paid " + txtinstallA.Text, "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                myClass.connect();
                myClass.cmd.CommandText = "update loan set TotalPaid=?,RemainingA=? where id='" + CBLid.Text + "'";
                myClass.cmd.Parameters.AddWithValue("TotalPaid", Convert.ToString(TotalP));
                myClass.cmd.Parameters.AddWithValue("RemainingA", Convert.ToString(RemainA));
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();

                load();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myClass.disconnect();
                    return;
                  
                }

            }
        }
        void load()
        {
            myClass.loadlist("loan", CBLid,"ID");
        }
        private void LoanForm_Load(object sender, EventArgs e)
        {
            load();
            txtinstallA.MaxLength=TxtRAmt.TextLength;
        }

        private void Searchicon_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }


        void clear()
        {
            txtcid.Clear();
            combogender.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtmobileno.Clear();
            txtLtype.Clear();
            txtamt.Clear();
            txtyear.Clear();
            txtInterest.Clear();
            lblMpay.Clear();
            txtTpay.Clear();
            TxtPaidAmt.Clear();
            TxtRAmt.Clear();
            txtinstallA.Clear();
            load();

        }

        private void txtTpay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinstallA_KeyPress(object sender, KeyPressEventArgs e)
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
