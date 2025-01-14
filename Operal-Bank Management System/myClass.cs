using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    class myClass
    {
        /*--------------------declaring variables-------------------------*/
        public static double incr_id;
        /*--------------------declaring variables-------------------------*/

        /*--------------------form object creation -------------------------*/
        public static LoginForm LoginF = new LoginForm();
        public static AboutUsForm AboutUsF = new AboutUsForm();
        public static AccountCForm AccountC = new AccountCForm();
        public static AccountTForm AccountT = new AccountTForm();
        public static AdminRForm AdminR = new AdminRForm();
        public static BankInfoForm BankInfoF = new BankInfoForm();
        public static CustomerForm CustomerF = new CustomerForm();
        public static DepositeForm DepositeF = new DepositeForm();
        public static TransactionForm TransactionF = new TransactionForm();
        public static TransferForm TransferF = new TransferForm();
        public static UpdateCForm updateCF = new UpdateCForm();
        public static MainForm MainF = new MainForm();
        public static DeleteForm deleteF = new DeleteForm();
        public static LoanForm loanF = new LoanForm();

     /*--------------------form object-------------------------*/
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbConnection cn = new OleDbConnection();
        public static OleDbDataReader buff;

        public static IEnumerable<Control> Controls { get; private set; }

        public static void connect()
        {
            cn.ConnectionString = "Provider=SQLOLEDB;Data Source=SYPDER\\SQLEXPRESS;Initial Catalog=OperalDB;Integrated Security=SSPI";
            cmd.Connection = cn;
            cn.Open();
        }
        public static void disconnect()
        {
            cmd.Parameters.Clear();
            cn.Close();
        }

        public static double IncrementF(string TbName)
        {
            connect();
            cmd.CommandText = "select max(id) from "+TbName+"";
            buff = cmd.ExecuteReader();
            if (buff.Read())
            {
                if (buff[0]!=System.DBNull.Value)
                {
                    int MAX_id = Convert.ToInt32(buff[0].ToString());
                    incr_id = (MAX_id + 1);
                    
                }
                else
                {
                    incr_id = 1;
                }
            }
            disconnect();


            return incr_id;
        }


        public static void deleteFun(string TbName,string id)
        {
            try
            {
                connect();
                cmd.CommandText = "delete from " + TbName + " where id=" + id + "";
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("Record Deleted Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }

        }
        
        public static void deleteFun2(string TbName,string id)
        {
            try
            {
                connect();
                cmd.CommandText = "delete from " + TbName + " where cid=" + id + "";
                cmd.ExecuteNonQuery();
                disconnect();
                MessageBox.Show("Record Deleted Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myClass.disconnect();
                return;
            }

        }

        public static void loadlist(string TbName,ComboBox comboBox,string col)
        {
            comboBox.Items.Clear();
            connect();
            cmd.CommandText = "select " + col + " from " + TbName + "";
            OleDbDataReader buff = cmd.ExecuteReader();
            while (buff.Read())
            {
                comboBox.Items.Add(buff[0].ToString());
            }
            buff.Close();
            disconnect();
        }

        public static string CountF(string TbName,string col)
        {
            connect();
            cmd.CommandText = "select count("+col+") from " + TbName + "";
            buff = cmd.ExecuteReader();
            myClass.buff.Read();
            string a =buff[0].ToString();
            disconnect();
            return a;
        }

        public static string SumF(string TbName, string col)
        {
            connect();
            cmd.CommandText = "select sum(" + col + ") from " + TbName + "";
            buff = cmd.ExecuteReader();
            myClass.buff.Read();
            string a = buff[0].ToString();
            disconnect();
            return a;
        }
    }
}
