using System;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    public partial class LoginForm : Form
    {
        ForgotPassForm forgotPass = new ForgotPassForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void lblreturnR_Click(object sender, EventArgs e)
        {
            myClass.AdminR.Show();
            this.Hide();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            forgotPass.ShowDialog();
        }

        private void CBSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if(CBSecurity.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        void clear()
        {
            txtpass.Clear();
            txtusername.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtusername.Text.Equals("Admin"))&&(txtpass.Text.Equals("Admin@123")))
            {
                this.Hide();
                MessageBox.Show("Login Successfull !!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form f2 = new MainForm();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect !!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
