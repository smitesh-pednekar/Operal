
namespace Operal_Bank_Management_System
{
    partial class TransactionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.Label();
            this.searchAccount = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textnewB = new System.Windows.Forms.TextBox();
            this.txtWamt = new System.Windows.Forms.TextBox();
            this.txtoldB = new System.Windows.Forms.TextBox();
            this.txtacno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.btnMWithdraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBAid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchAccount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnlTransaction);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 694);
            this.panel1.TabIndex = 0;
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlTransaction.Controls.Add(this.groupBox1);
            this.pnlTransaction.Controls.Add(this.pictureBox1);
            this.pnlTransaction.Controls.Add(this.CBAid);
            this.pnlTransaction.Controls.Add(this.btnClear);
            this.pnlTransaction.Controls.Add(this.btnWithdraw);
            this.pnlTransaction.Controls.Add(this.label1);
            this.pnlTransaction.Controls.Add(this.label5);
            this.pnlTransaction.Controls.Add(this.label3);
            this.pnlTransaction.Controls.Add(this.txtaccount);
            this.pnlTransaction.Controls.Add(this.searchAccount);
            this.pnlTransaction.Controls.Add(this.label2);
            this.pnlTransaction.Controls.Add(this.textnewB);
            this.pnlTransaction.Controls.Add(this.txtWamt);
            this.pnlTransaction.Controls.Add(this.txtoldB);
            this.pnlTransaction.Controls.Add(this.txtacno);
            this.pnlTransaction.Location = new System.Drawing.Point(16, 66);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(1180, 614);
            this.pnlTransaction.TabIndex = 1;
            this.pnlTransaction.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTransaction_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(291, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 48);
            this.btnClear.TabIndex = 192;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Green;
            this.btnWithdraw.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(81, 383);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(177, 48);
            this.btnWithdraw.TabIndex = 191;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 175;
            this.label1.Text = "New Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 174;
            this.label5.Text = "Old Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 173;
            this.label3.Text = "Withdraw Amount";
            // 
            // txtaccount
            // 
            this.txtaccount.AutoSize = true;
            this.txtaccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.Location = new System.Drawing.Point(32, 133);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(107, 24);
            this.txtaccount.TabIndex = 172;
            this.txtaccount.Text = "Account No";
            // 
            // searchAccount
            // 
            this.searchAccount.Location = new System.Drawing.Point(1137, 570);
            this.searchAccount.Name = "searchAccount";
            this.searchAccount.Size = new System.Drawing.Size(40, 32);
            this.searchAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchAccount.TabIndex = 164;
            this.searchAccount.TabStop = false;
            this.searchAccount.Visible = false;
            this.searchAccount.Click += new System.EventHandler(this.searchAccount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 163;
            this.label10.Text = "Gender";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(159, 100);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(277, 32);
            this.txtname.TabIndex = 152;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(159, 151);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(277, 68);
            this.txtaddress.TabIndex = 154;
            // 
            // txtmobileno
            // 
            this.txtmobileno.BackColor = System.Drawing.Color.White;
            this.txtmobileno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(159, 325);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.ReadOnly = true;
            this.txtmobileno.Size = new System.Drawing.Size(277, 32);
            this.txtmobileno.TabIndex = 157;
            this.txtmobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobileno_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(159, 281);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(277, 32);
            this.txtemail.TabIndex = 156;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 162;
            this.label11.Text = "Email ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 161;
            this.label12.Text = "Mobile No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 24);
            this.label13.TabIndex = 160;
            this.label13.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 24);
            this.label15.TabIndex = 158;
            this.label15.Text = "Name";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(159, 233);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(277, 32);
            this.txtGender.TabIndex = 151;
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(159, 42);
            this.txtcid.Name = "txtcid";
            this.txtcid.ReadOnly = true;
            this.txtcid.Size = new System.Drawing.Size(277, 32);
            this.txtcid.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 150;
            this.label4.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 43);
            this.label2.TabIndex = 149;
            this.label2.Text = "WITHDRAWAL";
            // 
            // textnewB
            // 
            this.textnewB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnewB.Location = new System.Drawing.Point(226, 297);
            this.textnewB.Name = "textnewB";
            this.textnewB.ReadOnly = true;
            this.textnewB.Size = new System.Drawing.Size(277, 32);
            this.textnewB.TabIndex = 147;
            // 
            // txtWamt
            // 
            this.txtWamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWamt.Location = new System.Drawing.Point(226, 237);
            this.txtWamt.MaxLength = 3465465;
            this.txtWamt.Name = "txtWamt";
            this.txtWamt.Size = new System.Drawing.Size(277, 32);
            this.txtWamt.TabIndex = 145;
            this.txtWamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWamt_KeyPress);
            // 
            // txtoldB
            // 
            this.txtoldB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldB.Location = new System.Drawing.Point(226, 182);
            this.txtoldB.Name = "txtoldB";
            this.txtoldB.ReadOnly = true;
            this.txtoldB.Size = new System.Drawing.Size(277, 32);
            this.txtoldB.TabIndex = 144;
            // 
            // txtacno
            // 
            this.txtacno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacno.Location = new System.Drawing.Point(1114, 570);
            this.txtacno.Name = "txtacno";
            this.txtacno.Size = new System.Drawing.Size(10, 32);
            this.txtacno.TabIndex = 140;
            this.txtacno.Visible = false;
            this.txtacno.TextChanged += new System.EventHandler(this.txtacno_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTransfer);
            this.panel2.Controls.Add(this.btnDeposite);
            this.panel2.Controls.Add(this.btnMWithdraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 58);
            this.panel2.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Red;
            this.btnTransfer.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(816, 6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(380, 52);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.BackColor = System.Drawing.Color.Red;
            this.btnDeposite.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposite.ForeColor = System.Drawing.Color.White;
            this.btnDeposite.Location = new System.Drawing.Point(416, 8);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(380, 52);
            this.btnDeposite.TabIndex = 0;
            this.btnDeposite.Text = "Deposit";
            this.btnDeposite.UseVisualStyleBackColor = false;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnMWithdraw
            // 
            this.btnMWithdraw.BackColor = System.Drawing.Color.Red;
            this.btnMWithdraw.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnMWithdraw.Location = new System.Drawing.Point(16, 8);
            this.btnMWithdraw.Name = "btnMWithdraw";
            this.btnMWithdraw.Size = new System.Drawing.Size(380, 52);
            this.btnMWithdraw.TabIndex = 0;
            this.btnMWithdraw.Text = "Withdraw";
            this.btnMWithdraw.UseVisualStyleBackColor = false;
            this.btnMWithdraw.Click += new System.EventHandler(this.btnMWithdraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Operal_Bank_Management_System.Properties.Resources.icons8_refresh_52px;
            this.pictureBox1.Location = new System.Drawing.Point(519, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 237;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CBAid
            // 
            this.CBAid.BackColor = System.Drawing.Color.Transparent;
            this.CBAid.BorderThickness = 2;
            this.CBAid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBAid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAid.FocusedColor = System.Drawing.Color.Red;
            this.CBAid.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.CBAid.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.CBAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBAid.ForeColor = System.Drawing.Color.Black;
            this.CBAid.HoverState.BorderColor = System.Drawing.Color.Red;
            this.CBAid.HoverState.ForeColor = System.Drawing.Color.Black;
            this.CBAid.ItemHeight = 30;
            this.CBAid.Items.AddRange(new object[] {
            "--Select--"});
            this.CBAid.Location = new System.Drawing.Point(226, 128);
            this.CBAid.Name = "CBAid";
            this.CBAid.Size = new System.Drawing.Size(277, 36);
            this.CBAid.TabIndex = 236;
            this.CBAid.SelectedIndexChanged += new System.EventHandler(this.CBAid_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcid);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtmobileno);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(641, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 409);
            this.groupBox1.TabIndex = 238;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.Button btnMWithdraw;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.PictureBox searchAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnewB;
        private System.Windows.Forms.TextBox txtWamt;
        private System.Windows.Forms.TextBox txtoldB;
        private System.Windows.Forms.TextBox txtacno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtaccount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CBAid;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}