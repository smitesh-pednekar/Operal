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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            timerdatetime.Start();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void timerdatetime_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("hh");
            lblMin.Text = DateTime.Now.ToString("mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblAMPM.Text = DateTime.Now.ToString("tt");
            datelbl.Text = DateTime.Now.ToString("MMM dd yyy");
            daylbl.Text = DateTime.Now.ToString("dddd");
            //lbltime.Text = DateTime.Now.ToLongTimeString();//its for current date

            //lbldate.Text = DateTime.Now.ToLongDateString();//its for current time
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (btnCustomer.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = Color.White;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
               
                btnLogout.BackColor = pnlsideB.BackColor;
            }

            myClass.CustomerF.TopLevel = false;
            pnlContent.Controls.Add(myClass.CustomerF);
            myClass.CustomerF.BringToFront();
            myClass.CustomerF.Show();
            Headlbl.Text = "Customer Form Window";
            //hide all forms
            myClass.AccountT.Hide();
            myClass.AccountC.Hide();
            myClass.TransactionF.Hide();
            myClass.AboutUsF.Hide();
            myClass.loanF.Hide();
        }

        private void btnAType_Click(object sender, EventArgs e)
        {
            if (btnAType.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = Color.White;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
                
                btnLogout.BackColor = pnlsideB.BackColor;
            }

            myClass.AccountT.TopLevel = false;
            pnlContent.Controls.Add(myClass.AccountT);
            myClass.AccountT.BringToFront();
            myClass.AccountT.Show();
            Headlbl.Text = "Account Type Form Window";
            //hide all forms
            myClass.CustomerF.Hide();
            myClass.AccountC.Hide();
            myClass.TransactionF.Hide();
            myClass.AboutUsF.Hide();
            myClass.loanF.Hide();
        }

        private void btnACreate_Click(object sender, EventArgs e)
        {
            if (btnACreate.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = Color.White;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
               
                btnLogout.BackColor = pnlsideB.BackColor;
            }

            myClass.AccountC.TopLevel = false;
            pnlContent.Controls.Add(myClass.AccountC);
            myClass.AccountC.BringToFront();
            myClass.AccountC.Show();
            Headlbl.Text = "Account Creation Window";
            //hide all forms
            myClass.CustomerF.Hide();
            myClass.AccountT.Hide();
            myClass.TransactionF.Hide();
            myClass.AboutUsF.Hide();
            myClass.loanF.Hide();
        }

        

        //private void btnAboutus_Click(object sender, EventArgs e)
        //{
        //    if (btnAboutus.Focused == true)
        //    {
        //        btnHome.BackColor = pnlsideB.BackColor;
        //        btnBalance.BackColor = pnlsideB.BackColor;
        //        btnTranscation.BackColor = pnlsideB.BackColor;
        //        btnLoan.BackColor = pnlsideB.BackColor;
        //        btnAboutus.BackColor = Color.White;
        //        btnCustomer.BackColor = pnlsideB.BackColor;
        //        btnAType.BackColor = pnlsideB.BackColor;
        //        btnACreate.BackColor = pnlsideB.BackColor; ;
        //        btnLogout.BackColor = pnlsideB.BackColor;
        //    }

        //    myClass.AboutUsF.TopLevel = false;
        //    pnlContent.Controls.Add(myClass.AboutUsF);
        //    myClass.AboutUsF.BringToFront();
        //    myClass.AboutUsF.Show();
        //    Headlbl.Text = "About US Form";
        //    myClass.CustomerF.Hide();
        //    myClass.AccountT.Hide();
        //    myClass.AccountC.Hide();
        //    myClass.TransactionF.Hide();
        //    myClass.loanF.Hide();
        //}

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnHome.Focused == true)
            {
                btnHome.BackColor = Color.White;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
                //btnAboutus.BackColor = pnlsideB.BackColor;
                btnLogout.BackColor = pnlsideB.BackColor;
            }

            Headlbl.Text = "OPERAL HOME WINDOW";
            myClass.CustomerF.Hide();
            myClass.AccountT.Hide();
            myClass.AccountC.Hide();
            myClass.TransactionF.Hide();
            myClass.AboutUsF.Hide();
            myClass.loanF.Hide();

            
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (btnBalance.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = Color.White;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
                //btnAboutus.BackColor = pnlsideB.BackColor;
                btnLogout.BackColor = pnlsideB.BackColor;
            }

            BalanceF balanceF = new BalanceF();
            balanceF.ShowDialog();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {

            if (btnLoan.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = Color.White;
                //btnAboutus.BackColor = pnlsideB.BackColor;
                btnLogout.BackColor = pnlsideB.BackColor;
            }


            myClass.loanF.TopLevel = false;
            pnlContent.Controls.Add(myClass.loanF);
            myClass.loanF.BringToFront();
            myClass.loanF.Show();
            Headlbl.Text = "Loan Form Window";

            myClass.AccountT.Hide();
            myClass.AccountC.Hide();
            myClass.TransactionF.Hide();
            myClass.AboutUsF.Hide();

            
        }

        private void btnTranscation_Click(object sender, EventArgs e)
        {
            if (btnTranscation.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = Color.White;
                btnLoan.BackColor = pnlsideB.BackColor;
                //btnAboutus.BackColor = pnlsideB.BackColor;
                btnLogout.BackColor = pnlsideB.BackColor;
            }


            myClass.TransactionF.TopLevel = false;
                pnlContent.Controls.Add(myClass.TransactionF);
                myClass.TransactionF.BringToFront();
                myClass.TransactionF.Show();
                Headlbl.Text = "Transaction Form Window";
                myClass.CustomerF.Hide();
                myClass.AccountT.Hide();
                myClass.AccountC.Hide();
                myClass.AboutUsF.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (btnLogout.Focused == true)
            {
                btnHome.BackColor = pnlsideB.BackColor;
                btnBalance.BackColor = pnlsideB.BackColor;
                btnCustomer.BackColor = pnlsideB.BackColor;
                btnAType.BackColor = pnlsideB.BackColor;
                btnACreate.BackColor = pnlsideB.BackColor;
                btnTranscation.BackColor = pnlsideB.BackColor;
                btnLoan.BackColor = pnlsideB.BackColor;
                //btnAboutus.BackColor = pnlsideB.BackColor;
                btnLogout.BackColor = Color.White;
            }


            if (MessageBox.Show("Are you want to logout application", "Logout message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("Logout Successfull !!!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myClass.LoginF.Show();
            }
            
        }

        void bankinfo()
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from Bank_info";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            lblBrC.Text = myClass.buff[0].ToString();
            lblBN.Text = myClass.buff[1].ToString();
            lblBrN.Text = myClass.buff[2].ToString();
            lblIFSC.Text = myClass.buff[3].ToString();
            lblAddress.Text = myClass.buff[4].ToString();
            lblStreet.Text = myClass.buff[5].ToString();
            lblCity.Text = myClass.buff[6].ToString();
            lblPincode.Text = myClass.buff[7].ToString();
            myClass.buff.Close();
            myClass.disconnect();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.White;
            loadD();
            bankinfo();
        }

        void loadD()
        {
            txtC.Text = myClass.CountF("customerTb", "id");
            txtAC.Text = myClass.CountF("account_c", "id");
            txtD.Text = myClass.SumF("deposit", "Deposit_Amount");
            txtW.Text = myClass.SumF("withdraw", "Withdraw_Amount");
            txtL.Text = myClass.SumF("loan", "loanamt");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BankInfoForm bankInfoF = new BankInfoForm();
            bankInfoF.ShowDialog();
        }

        private void lblBrN_Click(object sender, EventArgs e)
        {

        }

        private void PicR_Click(object sender, EventArgs e)
        {
            bankinfo();
        }

        private void txtC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadD();
        }
    }
}
