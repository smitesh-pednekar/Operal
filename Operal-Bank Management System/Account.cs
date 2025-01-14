using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OPERAL_Bank_Management_System
{

    public partial class Account : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();

        void connect()
        {
            cn.ConnectionString = "Provider=SQLOLEDB;Data Source=SYPDER\\SQLEXPRESS;Initial Catalog=OperalDB;Integrated Security=SSPI";
            cmd.Connection = cn;
            cn.Open();
        }
        void disconnect()
        {
            cmd.Parameters.Clear();
            cn.Close();
        }

        void clearall()
        {
            txtid.Clear();
            txttype.Clear();
            txtroi.Clear();
        }
        public Account()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            connect();
            cmd.CommandText = "insert into account_type(id,type,roi)values(?,?,?)";
            cmd.Parameters.AddWithValue("id", txtid.Text.Trim());
            cmd.Parameters.AddWithValue("type", txttype.Text.Trim());
            cmd.Parameters.AddWithValue("roi", txtroi.Text.Trim());
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("Record Saved Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearall();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connect();
            cmd.CommandText = "delete from account_type where id='" + txtid.Text + "'";
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("Record Deleted Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearall();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            combosearch.Items.Clear();
            connect();
            cmd.CommandText = "select id from account_type";
            OleDbDataReader buff = cmd.ExecuteReader();
            while (buff.Read())
            {
                combosearch.Items.Add(buff[0].ToString());
            }
            disconnect();
        }

        private void combosearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect();
            cmd.CommandText = "select * from account_type where id='" + combosearch.Text + "'";
            OleDbDataReader buff = cmd.ExecuteReader();
            buff.Read();
            txtid.Text = buff[0].ToString();
            txttype.Text = buff[1].ToString();
            txtroi.Text = buff[2].ToString();
            buff.Close();
            disconnect();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connect();
            cmd.CommandText = "update account_type set type=?,roi=? where id='" + txtid.Text + "'";
            cmd.Parameters.AddWithValue("type", txttype.Text.Trim());
            cmd.Parameters.AddWithValue("roi", txtroi.Text.Trim());
            cmd.ExecuteNonQuery();
            disconnect();
            MessageBox.Show("Record updated Successfully!!!!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearall();
        }

        //


    }
}
