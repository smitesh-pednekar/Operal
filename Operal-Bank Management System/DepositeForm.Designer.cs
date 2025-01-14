
namespace Operal_Bank_Management_System
{
    partial class DepositeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositeForm));
            this.Searchicon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndeposit = new System.Windows.Forms.Button();
            this.textnewB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDamt = new System.Windows.Forms.TextBox();
            this.txtoldB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdepositamt = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.Label();
            this.txtacno = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBAid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchicon
            // 
            this.Searchicon.Image = ((System.Drawing.Image)(resources.GetObject("Searchicon.Image")));
            this.Searchicon.Location = new System.Drawing.Point(1128, 570);
            this.Searchicon.Name = "Searchicon";
            this.Searchicon.Size = new System.Drawing.Size(40, 32);
            this.Searchicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Searchicon.TabIndex = 189;
            this.Searchicon.TabStop = false;
            this.Searchicon.Visible = false;
            this.Searchicon.Click += new System.EventHandler(this.Searchicon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 43);
            this.label2.TabIndex = 174;
            this.label2.Text = "DEPOSIT";
            // 
            // btndeposit
            // 
            this.btndeposit.BackColor = System.Drawing.Color.Green;
            this.btndeposit.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btndeposit.ForeColor = System.Drawing.Color.White;
            this.btndeposit.Location = new System.Drawing.Point(109, 373);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(163, 48);
            this.btndeposit.TabIndex = 173;
            this.btndeposit.Text = "DEPOSIT";
            this.btndeposit.UseVisualStyleBackColor = false;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // textnewB
            // 
            this.textnewB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnewB.Location = new System.Drawing.Point(226, 299);
            this.textnewB.Name = "textnewB";
            this.textnewB.Size = new System.Drawing.Size(277, 32);
            this.textnewB.TabIndex = 172;
            this.textnewB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnewB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 171;
            this.label1.Text = "New Balance";
            // 
            // txtDamt
            // 
            this.txtDamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamt.Location = new System.Drawing.Point(226, 249);
            this.txtDamt.Name = "txtDamt";
            this.txtDamt.Size = new System.Drawing.Size(277, 32);
            this.txtDamt.TabIndex = 170;
            this.txtDamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDamt_KeyPress);
            // 
            // txtoldB
            // 
            this.txtoldB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldB.Location = new System.Drawing.Point(226, 192);
            this.txtoldB.Name = "txtoldB";
            this.txtoldB.Size = new System.Drawing.Size(277, 32);
            this.txtoldB.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 168;
            this.label5.Text = "Old Balance";
            // 
            // txtdepositamt
            // 
            this.txtdepositamt.AutoSize = true;
            this.txtdepositamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepositamt.ForeColor = System.Drawing.Color.White;
            this.txtdepositamt.Location = new System.Drawing.Point(53, 254);
            this.txtdepositamt.Name = "txtdepositamt";
            this.txtdepositamt.Size = new System.Drawing.Size(148, 24);
            this.txtdepositamt.TabIndex = 167;
            this.txtdepositamt.Text = "Deposit Amount";
            // 
            // txtaccount
            // 
            this.txtaccount.AutoSize = true;
            this.txtaccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaccount.ForeColor = System.Drawing.Color.White;
            this.txtaccount.Location = new System.Drawing.Point(53, 143);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(107, 24);
            this.txtaccount.TabIndex = 166;
            this.txtaccount.Text = "Account No";
            // 
            // txtacno
            // 
            this.txtacno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacno.Location = new System.Drawing.Point(836, 570);
            this.txtacno.Name = "txtacno";
            this.txtacno.Size = new System.Drawing.Size(277, 32);
            this.txtacno.TabIndex = 165;
            this.txtacno.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(310, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 48);
            this.btnClear.TabIndex = 190;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Operal_Bank_Management_System.Properties.Resources.icons8_refresh_52px;
            this.pictureBox1.Location = new System.Drawing.Point(519, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 239;
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
            this.CBAid.Location = new System.Drawing.Point(226, 137);
            this.CBAid.Name = "CBAid";
            this.CBAid.Size = new System.Drawing.Size(277, 36);
            this.CBAid.TabIndex = 238;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(618, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 409);
            this.groupBox1.TabIndex = 240;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(159, 233);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(277, 32);
            this.txtGender.TabIndex = 151;
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
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(159, 42);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(277, 32);
            this.txtcid.TabIndex = 151;
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
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(159, 281);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(277, 32);
            this.txtemail.TabIndex = 156;
            // 
            // txtmobileno
            // 
            this.txtmobileno.BackColor = System.Drawing.Color.White;
            this.txtmobileno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(159, 325);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(277, 32);
            this.txtmobileno.TabIndex = 157;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(159, 151);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(277, 68);
            this.txtaddress.TabIndex = 154;
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
            this.txtname.Size = new System.Drawing.Size(277, 32);
            this.txtname.TabIndex = 152;
            // 
            // DepositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBAid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Searchicon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.textnewB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDamt);
            this.Controls.Add(this.txtoldB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdepositamt);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.txtacno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositeForm";
            this.Load += new System.EventHandler(this.DepositeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Searchicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Searchicon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.TextBox textnewB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDamt;
        private System.Windows.Forms.TextBox txtoldB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtdepositamt;
        private System.Windows.Forms.Label txtaccount;
        private System.Windows.Forms.TextBox txtacno;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CBAid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtname;
    }
}