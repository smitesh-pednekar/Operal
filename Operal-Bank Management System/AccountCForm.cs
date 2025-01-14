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
    public partial class AccountCForm : Form
    {
        public AccountCForm()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myClass.updateCF.TopLevel = false;
            pnlCustomer.Controls.Add(myClass.updateCF);
            myClass.updateCF.BringToFront();
            myClass.updateCF.Show();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            
            
        }

        void clear()
        {
            txtname.Clear();
            txtaddress.Clear();
            CBgender.Clear();
            txtEmailid.Clear();
            loadid();
            txtacNO.Clear();
            //txtcid.Clear();
            txtROI.Clear();
            txtInitB.Clear();
            increment();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            
            myClass.connect();
            myClass.cmd.CommandText = "insert into account_c(id,cid,roi,init_balance)values(?,?,?,?)";
            myClass.cmd.Parameters.AddWithValue("id", txtacNO.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("cid", CBacno.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("roi", txtROI.Text.Trim());
            myClass.cmd.Parameters.AddWithValue("init_balance", txtInitB.Text.Trim());
            myClass.cmd.ExecuteNonQuery();
            myClass.disconnect();
            MessageBox.Show("Record Saved Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            increment();
            clear();
            CBacno.Focus();
        }

        void increment()
        {
            string tbname = "account_c";
            double id = myClass.IncrementF(tbname);
            txtacNO.Text = id.ToString();
        }

        //void account_typeA()
        //{
        //    acctTypeCB.Items.Clear();
        //    myClass.connect();
        //    myClass.cmd.CommandText = "select type from account_type";
        //    myClass.buff = myClass.cmd.ExecuteReader();
        //    while (myClass.buff.Read())
        //    {
        //        acctTypeCB.Items.Add(myClass.buff[0].ToString());
        //    }
        //    myClass.disconnect();
        //}

        private void AccountCForm_Load(object sender, EventArgs e)
        {
            increment();
            load();
            loadid();
            load1();
        }

         void load1()
        {
            myClass.loadlist("account_type", acctTypeCB, "type");
        }

        private void btnsearchCust_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tbname = "account_c";
            string id = txtidS.Text;
            myClass.deleteFun(tbname, id);
            clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            loadid();
        }

        

        private void acctTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select roi from account_type where type='" + acctTypeCB.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
          txtROI.Text = myClass.buff[0].ToString();
            myClass.buff.Close();
            myClass.disconnect();
        }
        void load()
        {
            myClass.loadlist("customerTb", CBacno,"id");
        }

        void loadid()
        {
            myClass.loadlist("account_c", txtidS, "id");
        }
        private void CBacno_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from customerTb where id='" + CBacno.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtname.Text = myClass.buff[1].ToString();
            txtaddress.Text = myClass.buff[3].ToString();
            CBgender.Text = myClass.buff[4].ToString();
            txtEmailid.Text = myClass.buff[5].ToString();
            myClass.buff.Close();
            myClass.disconnect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInitB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadid();
        }

        private void txtidS_SelectedIndexChanged(object sender, EventArgs e)
        {
            myClass.connect();
            myClass.cmd.CommandText = "select * from account_c where id='" + txtidS.Text + "'";
            myClass.buff = myClass.cmd.ExecuteReader();
            myClass.buff.Read();
            txtacNO.Text = myClass.buff[0].ToString();
            CBacno.Text = myClass.buff[1].ToString();
            txtROI.Text = myClass.buff[2].ToString();
            txtInitB.Text = myClass.buff[3].ToString();
            myClass.buff.Close();
            myClass.disconnect();
        }
    }
}
