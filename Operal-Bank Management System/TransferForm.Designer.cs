
using System;
using System.Windows.Forms;

namespace Operal_Bank_Management_System
{
    partial class TransferForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.label7 = new System.Windows.Forms.Label();
            this.txttransamt = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbalance1 = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfaccno = new System.Windows.Forms.TextBox();
            this.txtaccount = new System.Windows.Forms.Label();
            this.txttransno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNewb1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Searchicon1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNewb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Searchicon2 = new System.Windows.Forms.PictureBox();
            this.txttaccno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbalance2 = new System.Windows.Forms.TextBox();
            this.txtemail1 = new System.Windows.Forms.TextBox();
            this.txtcid1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(624, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 125;
            this.label7.Text = "Transfer Amount";
            // 
            // txttransamt
            // 
            this.txttransamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransamt.Location = new System.Drawing.Point(801, 101);
            this.txttransamt.Name = "txttransamt";
            this.txttransamt.Size = new System.Drawing.Size(277, 32);
            this.txttransamt.TabIndex = 124;
            this.txttransamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttransamt_KeyPress_1);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(195, 127);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(277, 32);
            this.txtname.TabIndex = 115;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(195, 183);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(277, 32);
            this.txtemail.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 116;
            this.label11.Text = "Email ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 109;
            this.label1.Text = "Current Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 24);
            this.label15.TabIndex = 116;
            this.label15.Text = "Name";
            // 
            // txtbalance1
            // 
            this.txtbalance1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance1.Location = new System.Drawing.Point(195, 232);
            this.txtbalance1.Name = "txtbalance1";
            this.txtbalance1.Size = new System.Drawing.Size(277, 32);
            this.txtbalance1.TabIndex = 110;
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(195, 78);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(277, 32);
            this.txtcid.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 113;
            this.label6.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 119;
            this.label3.Text = "From Account No";
            // 
            // txtfaccno
            // 
            this.txtfaccno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfaccno.Location = new System.Drawing.Point(195, 31);
            this.txtfaccno.Name = "txtfaccno";
            this.txtfaccno.Size = new System.Drawing.Size(277, 32);
            this.txtfaccno.TabIndex = 118;
            // 
            // txtaccount
            // 
            this.txtaccount.AutoSize = true;
            this.txtaccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.Location = new System.Drawing.Point(122, 104);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(107, 24);
            this.txtaccount.TabIndex = 117;
            this.txtaccount.Text = "Transfer No";
            // 
            // txttransno
            // 
            this.txttransno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransno.Location = new System.Drawing.Point(240, 101);
            this.txttransno.Name = "txttransno";
            this.txttransno.Size = new System.Drawing.Size(277, 32);
            this.txttransno.TabIndex = 116;
            this.txttransno.TextChanged += new System.EventHandler(this.txttransno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 49);
            this.label2.TabIndex = 115;
            this.label2.Text = "TRANSFER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNewb1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Searchicon1);
            this.groupBox2.Controls.Add(this.txtfaccno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbalance1);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtcid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(48, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 347);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From Account Details";
            // 
            // textNewb1
            // 
            this.textNewb1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewb1.Location = new System.Drawing.Point(193, 286);
            this.textNewb1.Name = "textNewb1";
            this.textNewb1.Size = new System.Drawing.Size(277, 32);
            this.textNewb1.TabIndex = 192;
            this.textNewb1.TextChanged += new System.EventHandler(this.textNewb1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 24);
            this.label13.TabIndex = 191;
            this.label13.Text = "New Balance";
            // 
            // Searchicon1
            // 
            this.Searchicon1.Image = ((System.Drawing.Image)(resources.GetObject("Searchicon1.Image")));
            this.Searchicon1.Location = new System.Drawing.Point(478, 34);
            this.Searchicon1.Name = "Searchicon1";
            this.Searchicon1.Size = new System.Drawing.Size(40, 32);
            this.Searchicon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Searchicon1.TabIndex = 190;
            this.Searchicon1.TabStop = false;
            this.Searchicon1.Click += new System.EventHandler(this.Searchicon1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNewb2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Searchicon2);
            this.groupBox1.Controls.Add(this.txttaccno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtname1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbalance2);
            this.groupBox1.Controls.Add(this.txtemail1);
            this.groupBox1.Controls.Add(this.txtcid1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(606, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 347);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Account Details";
            // 
            // textNewb2
            // 
            this.textNewb2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewb2.Location = new System.Drawing.Point(195, 286);
            this.textNewb2.Name = "textNewb2";
            this.textNewb2.Size = new System.Drawing.Size(277, 32);
            this.textNewb2.TabIndex = 174;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 173;
            this.label4.Text = "New Balance";
            // 
            // Searchicon2
            // 
            this.Searchicon2.Image = ((System.Drawing.Image)(resources.GetObject("Searchicon2.Image")));
            this.Searchicon2.Location = new System.Drawing.Point(478, 31);
            this.Searchicon2.Name = "Searchicon2";
            this.Searchicon2.Size = new System.Drawing.Size(40, 32);
            this.Searchicon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Searchicon2.TabIndex = 191;
            this.Searchicon2.TabStop = false;
            this.Searchicon2.Click += new System.EventHandler(this.Searchicon2_Click);
            // 
            // txttaccno
            // 
            this.txttaccno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaccno.Location = new System.Drawing.Point(195, 31);
            this.txttaccno.Name = "txttaccno";
            this.txttaccno.Size = new System.Drawing.Size(277, 32);
            this.txttaccno.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Current Balance";
            // 
            // txtname1
            // 
            this.txtname1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname1.Location = new System.Drawing.Point(195, 127);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(277, 32);
            this.txtname1.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 119;
            this.label8.Text = "To Account No";
            // 
            // txtbalance2
            // 
            this.txtbalance2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance2.Location = new System.Drawing.Point(195, 232);
            this.txtbalance2.Name = "txtbalance2";
            this.txtbalance2.Size = new System.Drawing.Size(277, 32);
            this.txtbalance2.TabIndex = 110;
            // 
            // txtemail1
            // 
            this.txtemail1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail1.Location = new System.Drawing.Point(195, 183);
            this.txtemail1.Name = "txtemail1";
            this.txtemail1.Size = new System.Drawing.Size(277, 32);
            this.txtemail1.TabIndex = 113;
            // 
            // txtcid1
            // 
            this.txtcid1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid1.Location = new System.Drawing.Point(195, 78);
            this.txtcid1.Name = "txtcid1";
            this.txtcid1.Size = new System.Drawing.Size(277, 32);
            this.txtcid1.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 116;
            this.label9.Text = "Email ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 113;
            this.label10.Text = "Customer ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 116;
            this.label12.Text = "Name";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Green;
            this.btnTransfer.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.Location = new System.Drawing.Point(388, 524);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(215, 48);
            this.btnTransfer.TabIndex = 121;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(646, 524);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 48);
            this.btnClear.TabIndex = 120;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 614);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttransamt);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.txttransno);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttransamt;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbalance1;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfaccno;
        private System.Windows.Forms.Label txtaccount;
        private System.Windows.Forms.TextBox txttransno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttaccno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbalance2;
        private System.Windows.Forms.TextBox txtemail1;
        private System.Windows.Forms.TextBox txtcid1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox Searchicon1;
        private System.Windows.Forms.PictureBox Searchicon2;
        private System.Windows.Forms.TextBox textNewb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewb1;
        private System.Windows.Forms.Label label13;
    }
}