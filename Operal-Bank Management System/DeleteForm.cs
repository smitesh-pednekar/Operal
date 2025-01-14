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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        void load()
        {
            myClass.loadlist("customerTb", txtId, "id");
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("You have not specified Customer ID properly", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }

            string tbname = "customerTb";
            string id = txtId.Text;
            myClass.deleteFun(tbname, id);
                        
            string tbnamea = "account_c";
            string ida = txtId.Text;
            myClass.deleteFun2(tbnamea, ida);
            
           

            ////try
            ////{
            //myClass.connect();
            //    myClass.cmd.CommandText = "delete from customerTb where id=" + txtId.Text + "";
            //    myClass.cmd.ExecuteNonQuery();
            //    myClass.disconnect();
            //    MessageBox.Show("Record Deleted Successfully!!!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    load();
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    myClass.disconnect();
            ////    return;
            ////}
        }
    }
}
