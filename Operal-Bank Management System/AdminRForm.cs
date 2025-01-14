using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    public partial class AdminRForm : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        string str;

        public AdminRForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBSecurity_P_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSecurity_P.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void CBSecurity_C_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSecurity_C.Checked)
            {
                txtPassC.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassC.UseSystemPasswordChar = true;
            }
        }

        private void lblreturnL_Click(object sender, EventArgs e)
        {
            this.Hide();
            myClass.LoginF.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                str = open.FileName;
                picUpload.Image = new Bitmap(str);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUserName.Clear();
            CBRole.SelectedIndex=0;
            CBGender.SelectedIndex = 0;
            txtEmailId.Clear();
            txtMobNO.Clear();
            txtAddress.Clear();
            txtpass.Clear();
            txtPassC.Clear();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            str = open.FileName;
            
            string tbname = "adminTb";
            double id = myClass.IncrementF(tbname);
            myClass.connect();
                myClass.cmd.CommandText = "insert into adminTb(id,name,username,role,gender,emailid,mobileno,address,password)values(?,?,?,?,?,?,?,?,?)";
                myClass.cmd.Parameters.AddWithValue("id",id.ToString());
                myClass.cmd.Parameters.AddWithValue("name", txtName.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("username", txtUserName.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("role", CBRole.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("gender", CBGender.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("emailid", txtEmailId.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("mobileno", txtMobNO.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("address", txtAddress.Text.Trim());
                myClass.cmd.Parameters.AddWithValue("password", txtpass.Text.Trim());
                myClass.cmd.ExecuteNonQuery();
                myClass.disconnect();
            File.Copy(str, Path.Combine(@"D:\sanket\Operal-Bank Management System\Operal-Bank Management System\AImages\", Path.GetFileName(str)), true);
            MessageBox.Show("Registration is Successfully!!!!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myClass.LoginF.Show();
                this.Hide();
            
            
        }
    }
}
