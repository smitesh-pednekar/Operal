
namespace Operal_Bank_Management_System
{
    partial class AccountCForm
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
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.CBacno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtROI = new Guna.UI2.WinForms.Guna2TextBox();
            this.acctTypeCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtidS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmailid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBgender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtInitB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtacNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnlCustomer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 694);
            this.panel1.TabIndex = 0;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlCustomer.Controls.Add(this.CBacno);
            this.pnlCustomer.Controls.Add(this.pictureBox1);
            this.pnlCustomer.Controls.Add(this.txtROI);
            this.pnlCustomer.Controls.Add(this.acctTypeCB);
            this.pnlCustomer.Controls.Add(this.label6);
            this.pnlCustomer.Controls.Add(this.groupBox3);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Controls.Add(this.groupBox1);
            this.pnlCustomer.Controls.Add(this.btnCancel);
            this.pnlCustomer.Controls.Add(this.btnCreate);
            this.pnlCustomer.Controls.Add(this.txtInitB);
            this.pnlCustomer.Controls.Add(this.label3);
            this.pnlCustomer.Controls.Add(this.txtacNO);
            this.pnlCustomer.Controls.Add(this.label2);
            this.pnlCustomer.Controls.Add(this.label14);
            this.pnlCustomer.Location = new System.Drawing.Point(16, 64);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1180, 616);
            this.pnlCustomer.TabIndex = 0;
            // 
            // CBacno
            // 
            this.CBacno.BackColor = System.Drawing.Color.Transparent;
            this.CBacno.BorderThickness = 2;
            this.CBacno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBacno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBacno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CBacno.FocusedColor = System.Drawing.Color.Red;
            this.CBacno.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.CBacno.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.CBacno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBacno.ForeColor = System.Drawing.Color.White;
            this.CBacno.HoverState.BorderColor = System.Drawing.Color.Red;
            this.CBacno.HoverState.ForeColor = System.Drawing.Color.Black;
            this.CBacno.ItemHeight = 30;
            this.CBacno.Items.AddRange(new object[] {
            "--Select--"});
            this.CBacno.Location = new System.Drawing.Point(165, 100);
            this.CBacno.Name = "CBacno";
            this.CBacno.Size = new System.Drawing.Size(328, 36);
            this.CBacno.StartIndex = 0;
            this.CBacno.TabIndex = 233;
            this.CBacno.SelectedIndexChanged += new System.EventHandler(this.CBacno_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Operal_Bank_Management_System.Properties.Resources.icons8_refresh_52px;
            this.pictureBox1.Location = new System.Drawing.Point(501, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 234;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtROI
            // 
            this.txtROI.BackColor = System.Drawing.Color.Transparent;
            this.txtROI.BorderThickness = 2;
            this.txtROI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtROI.DefaultText = "";
            this.txtROI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtROI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtROI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtROI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtROI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtROI.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtROI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtROI.ForeColor = System.Drawing.Color.White;
            this.txtROI.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtROI.Location = new System.Drawing.Point(786, 94);
            this.txtROI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtROI.Name = "txtROI";
            this.txtROI.PasswordChar = '\0';
            this.txtROI.PlaceholderText = "Rate Of Interest";
            this.txtROI.ReadOnly = true;
            this.txtROI.SelectedText = "";
            this.txtROI.Size = new System.Drawing.Size(328, 42);
            this.txtROI.TabIndex = 76;
            // 
            // acctTypeCB
            // 
            this.acctTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.acctTypeCB.BorderThickness = 2;
            this.acctTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.acctTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acctTypeCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.acctTypeCB.FocusedColor = System.Drawing.Color.Red;
            this.acctTypeCB.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.acctTypeCB.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.acctTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.acctTypeCB.ForeColor = System.Drawing.Color.White;
            this.acctTypeCB.HoverState.BorderColor = System.Drawing.Color.Red;
            this.acctTypeCB.HoverState.ForeColor = System.Drawing.Color.Black;
            this.acctTypeCB.ItemHeight = 30;
            this.acctTypeCB.Items.AddRange(new object[] {
            "-Select-"});
            this.acctTypeCB.Location = new System.Drawing.Point(786, 37);
            this.acctTypeCB.Name = "acctTypeCB";
            this.acctTypeCB.Size = new System.Drawing.Size(328, 36);
            this.acctTypeCB.StartIndex = 0;
            this.acctTypeCB.TabIndex = 217;
            this.acctTypeCB.SelectedIndexChanged += new System.EventHandler(this.acctTypeCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(606, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Rate Of Interest";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtidS);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox3.Location = new System.Drawing.Point(590, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 189);
            this.groupBox3.TabIndex = 216;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By ID";
            this.groupBox3.Visible = false;
            // 
            // txtidS
            // 
            this.txtidS.BackColor = System.Drawing.Color.Transparent;
            this.txtidS.BorderThickness = 2;
            this.txtidS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtidS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtidS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtidS.FocusedColor = System.Drawing.Color.Red;
            this.txtidS.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtidS.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txtidS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtidS.ForeColor = System.Drawing.Color.White;
            this.txtidS.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtidS.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtidS.ItemHeight = 30;
            this.txtidS.Items.AddRange(new object[] {
            "--Select--"});
            this.txtidS.Location = new System.Drawing.Point(87, 53);
            this.txtidS.Name = "txtidS";
            this.txtidS.Size = new System.Drawing.Size(328, 36);
            this.txtidS.StartIndex = 0;
            this.txtidS.TabIndex = 233;
            this.txtidS.SelectedIndexChanged += new System.EventHandler(this.txtidS_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Blue;
            this.btnclear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(290, 112);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 49);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Operal_Bank_Management_System.Properties.Resources.icons8_refresh_52px;
            this.pictureBox2.Location = new System.Drawing.Point(421, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 234;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(131, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(609, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "Account Type \r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtEmailid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBgender);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Location = new System.Drawing.Point(31, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 355);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Transparent;
            this.txtaddress.BorderThickness = 2;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.White;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtaddress.Location = new System.Drawing.Point(133, 94);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "Address";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(328, 97);
            this.txtaddress.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 64;
            this.label11.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "Email ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "Name";
            // 
            // txtEmailid
            // 
            this.txtEmailid.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailid.BorderThickness = 2;
            this.txtEmailid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailid.DefaultText = "";
            this.txtEmailid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtEmailid.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtEmailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtEmailid.ForeColor = System.Drawing.Color.White;
            this.txtEmailid.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtEmailid.Location = new System.Drawing.Point(133, 273);
            this.txtEmailid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailid.Name = "txtEmailid";
            this.txtEmailid.PasswordChar = '\0';
            this.txtEmailid.PlaceholderText = "Email ID";
            this.txtEmailid.ReadOnly = true;
            this.txtEmailid.SelectedText = "";
            this.txtEmailid.Size = new System.Drawing.Size(328, 42);
            this.txtEmailid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Gender";
            // 
            // CBgender
            // 
            this.CBgender.BackColor = System.Drawing.Color.Transparent;
            this.CBgender.BorderThickness = 2;
            this.CBgender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CBgender.DefaultText = "";
            this.CBgender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CBgender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CBgender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CBgender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CBgender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CBgender.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.CBgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBgender.ForeColor = System.Drawing.Color.White;
            this.CBgender.HoverState.BorderColor = System.Drawing.Color.Red;
            this.CBgender.Location = new System.Drawing.Point(133, 211);
            this.CBgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBgender.Name = "CBgender";
            this.CBgender.PasswordChar = '\0';
            this.CBgender.PlaceholderText = "Gender";
            this.CBgender.ReadOnly = true;
            this.CBgender.SelectedText = "";
            this.CBgender.Size = new System.Drawing.Size(328, 42);
            this.CBgender.TabIndex = 1;
            this.CBgender.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BorderThickness = 2;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtname.Location = new System.Drawing.Point(133, 30);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Name";
            this.txtname.ReadOnly = true;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(328, 42);
            this.txtname.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Maroon;
            this.btnCancel.FillColor2 = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(869, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CLEAR";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderThickness = 2;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.Green;
            this.btnCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(691, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 52);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtInitB
            // 
            this.txtInitB.BackColor = System.Drawing.Color.Transparent;
            this.txtInitB.BorderThickness = 2;
            this.txtInitB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitB.DefaultText = "";
            this.txtInitB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInitB.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtInitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtInitB.ForeColor = System.Drawing.Color.White;
            this.txtInitB.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtInitB.Location = new System.Drawing.Point(786, 155);
            this.txtInitB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInitB.Name = "txtInitB";
            this.txtInitB.PasswordChar = '\0';
            this.txtInitB.PlaceholderText = "Enter Balance";
            this.txtInitB.SelectedText = "";
            this.txtInitB.Size = new System.Drawing.Size(328, 42);
            this.txtInitB.TabIndex = 5;
            this.txtInitB.TextChanged += new System.EventHandler(this.txtInitB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Initail Balance";
            // 
            // txtacNO
            // 
            this.txtacNO.BackColor = System.Drawing.Color.Transparent;
            this.txtacNO.BorderThickness = 2;
            this.txtacNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtacNO.DefaultText = "";
            this.txtacNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtacNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtacNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtacNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtacNO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtacNO.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtacNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtacNO.ForeColor = System.Drawing.Color.White;
            this.txtacNO.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtacNO.Location = new System.Drawing.Point(164, 36);
            this.txtacNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtacNO.Name = "txtacNO";
            this.txtacNO.PasswordChar = '\0';
            this.txtacNO.PlaceholderText = "ID";
            this.txtacNO.SelectedText = "";
            this.txtacNO.Size = new System.Drawing.Size(328, 38);
            this.txtacNO.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "A/C NO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(44, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 58;
            this.label14.Text = "Cust ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 58);
            this.panel2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(445, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(359, 43);
            this.label15.TabIndex = 69;
            this.label15.Text = "Account Creation";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "AccountCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.AccountCForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailid;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtacNO;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtROI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtInitB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclear;
        private Guna.UI2.WinForms.Guna2ComboBox acctTypeCB;
        private Guna.UI2.WinForms.Guna2ComboBox CBacno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox CBgender;
        private Guna.UI2.WinForms.Guna2ComboBox txtidS;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}