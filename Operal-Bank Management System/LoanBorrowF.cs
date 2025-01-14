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
    public partial class LoanBorrowF : Form
    {
        double InterestRate, montlyInterestRate, loanAmount,MonthlyPayment, TotalPayment;
        int numberOfYears;
        string iMonthlyPayment;


        public LoanBorrowF()
        {
            InitializeComponent();
        }

        void increment()
        {
            string tbname = "loan";
            double Transfer_No = myClass.IncrementF(tbname);
            txtlid.Text = Transfer_No.ToString("");
        }
        private void TransferForm_Load(object sender, EventArgs e)
        {
            increment();
        }

        void load()
        {
            myClass.loadlist("account_c", CBacno, "id");
        }

        

        private void btncal_Click(object sender, EventArgs e)
        {
            if (txtamt.Text == "")
            {
                MessageBox.Show("You have not specified Borrow amount", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtamt.Focus();
                return;
            }
            if (txtyear.Text == "")
            {
                MessageBox.Show("You have not specified year ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtyear.Focus();
                return;
            }

            if (txtInterest.Text == "")
            {
                MessageBox.Show("You have not specified rate of interest", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInterest.Focus();
                return;
            }
            InterestRate = Convert.ToDouble(txtInterest.Text);
            montlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtyear.Text);
            loanAmount = Convert.ToDouble(txtamt.Text);
            MonthlyPayment = loanAmount * montlyInterestRate / (1 - 1 / Math.Pow(1 + montlyInterestRate, numberOfYears * 12));


            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            lblMpay.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            lblTpay.Text = Convert.ToString(TotalPayment);

            //txtamt.Text = string.Format("{0:C}", loanAmount);



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Searchicon_Click(object sender, EventArgs e)
        {

            
        }

        private void comboLoanT_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void lblMpay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CBacno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myClass.connect();
                myClass.cmd.CommandText = "select ac.id,ac.cid,c.name,c.address,c.gender,c.email_id,c.mobile_no from account_c ac,customerTb c where ac.id='" + CBacno.Text + "' and ac.cid=c.id";
                myClass.buff = myClass.cmd.ExecuteReader();
                myClass.buff.Read();
                txtcid.Text = myClass.buff[1].ToString();
                txtname.Text = myClass.buff[2].ToString();
                txtaddress.Text = myClass.buff[3].ToString();
                combogender.Text = myClass.buff[4].ToString();
                txtemail.Text = myClass.buff[5].ToString();
                txtmobileno.Text = myClass.buff[6].ToString();
                myClass.buff.Close();
                myClass.disconnect();
                comboLoanT.Enabled = true;
            }
            catch(Exception)
            {

            }
            
        }
        private void loan_Load(object sender, EventArgs e)
        {
            increment();
            load();
            

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtlid.Text == "")
            {
                MessageBox.Show("You have not specified Loan ID properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlid.Focus();
                return;
            }
            if (txtcid.Text == "")
            {
                MessageBox.Show("You have not specified Customer ID ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcid.Focus();
                return;
            }
            if (comboLoanT.SelectedIndex == 0)
            {
                MessageBox.Show("You have not specified Loan Type ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboLoanT.Focus();
                return;
            }
           
            if (txtamt.Text == "")
            {
                MessageBox.Show("You have not specified borrow Amount ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtamt.Focus();
                return;
            }
            if (txtyear.Text == "")
            {
                MessageBox.Show("You have not specified year  ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtyear.Focus();
                return;
            }
            if (txtInterest.Text == "")
            {
                MessageBox.Show("You have not specified interest ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInterest.Focus();
                return;
            }
            if (lblMpay.Text == "")
            {
                MessageBox.Show("Can not Calculated ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMpay.Focus();
                return;
            }
            if (lblTpay.Text == "")
            {
                MessageBox.Show("Can not Calculated ", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTpay.Focus();
                return;
            }
            
            
            myClass.connect();
            myClass.cmd.CommandText = "insert into loan(id,loantype,cid,loanamt,no_ofYear,Interest,MontlyPayment,TotalAmount,RemainingA)values(?,?,?,?,?,?,?,?,?)";
            myClass.cmd.Parameters.AddWithValue("id", txtlid.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("loantype", comboLoanT.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("cid", txtcid.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("loanamt", txtamt.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("no_ofYear", txtyear.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("Interest", txtInterest.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("MontlyPayment", lblMpay.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("TotalAmount", lblTpay.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("RemainingA", lblTpay.Text.Trim());
            myClass.cmd.ExecuteNonQuery();
            myClass.disconnect();

            MessageBox.Show("Loan Applied Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            comboLoanT.SelectedIndex=-1;
            txtamt.Clear();
            txtyear.Clear();
            txtInterest.Clear();
            lblMpay.Clear();
            lblTpay.Clear();
            //TxtPaidAmt.Clear();
            //TxtRAmt.Clear();
            //txtinstallA.Clear();
            load();

        }

    }
}
