
namespace Operal_Bank_Management_System
{
    partial class CustomerForm
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRegistration = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dobpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CBgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMobno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
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
            this.pnlCustomer.Controls.Add(this.btnCancel);
            this.pnlCustomer.Controls.Add(this.btnRegistration);
            this.pnlCustomer.Controls.Add(this.dobpicker);
            this.pnlCustomer.Controls.Add(this.CBgender);
            this.pnlCustomer.Controls.Add(this.txtMobno);
            this.pnlCustomer.Controls.Add(this.txtEmailid);
            this.pnlCustomer.Controls.Add(this.txtaddress);
            this.pnlCustomer.Controls.Add(this.txtname);
            this.pnlCustomer.Controls.Add(this.txtid);
            this.pnlCustomer.Controls.Add(this.label15);
            this.pnlCustomer.Controls.Add(this.label1);
            this.pnlCustomer.Controls.Add(this.label14);
            this.pnlCustomer.Controls.Add(this.label13);
            this.pnlCustomer.Controls.Add(this.label12);
            this.pnlCustomer.Controls.Add(this.label9);
            this.pnlCustomer.Controls.Add(this.label11);
            this.pnlCustomer.Controls.Add(this.label10);
            this.pnlCustomer.Location = new System.Drawing.Point(16, 66);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1180, 614);
            this.pnlCustomer.TabIndex = 0;
            this.pnlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomer_Paint);
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
            this.btnCancel.Location = new System.Drawing.Point(614, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 52);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CLEAR";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BorderColor = System.Drawing.Color.White;
            this.btnRegistration.BorderRadius = 10;
            this.btnRegistration.BorderThickness = 2;
            this.btnRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistration.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistration.FillColor = System.Drawing.Color.Green;
            this.btnRegistration.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistration.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(266, 468);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(300, 52);
            this.btnRegistration.TabIndex = 11;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // dobpicker
            // 
            this.dobpicker.BorderColor = System.Drawing.Color.White;
            this.dobpicker.BorderThickness = 2;
            this.dobpicker.Checked = true;
            this.dobpicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dobpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.dobpicker.ForeColor = System.Drawing.Color.White;
            this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobpicker.Location = new System.Drawing.Point(227, 247);
            this.dobpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobpicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(328, 42);
            this.dobpicker.TabIndex = 1;
            this.dobpicker.Value = new System.DateTime(2023, 2, 3, 11, 1, 40, 931);
            // 
            // CBgender
            // 
            this.CBgender.BackColor = System.Drawing.Color.Transparent;
            this.CBgender.BorderThickness = 2;
            this.CBgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBgender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CBgender.FocusedColor = System.Drawing.Color.Red;
            this.CBgender.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.CBgender.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.CBgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBgender.ForeColor = System.Drawing.Color.White;
            this.CBgender.HoverState.BorderColor = System.Drawing.Color.Red;
            this.CBgender.HoverState.ForeColor = System.Drawing.Color.Black;
            this.CBgender.ItemHeight = 30;
            this.CBgender.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female",
            "Other"});
            this.CBgender.Location = new System.Drawing.Point(745, 123);
            this.CBgender.Name = "CBgender";
            this.CBgender.Size = new System.Drawing.Size(328, 36);
            this.CBgender.StartIndex = 0;
            this.CBgender.TabIndex = 3;
            // 
            // txtMobno
            // 
            this.txtMobno.BackColor = System.Drawing.Color.Transparent;
            this.txtMobno.BorderThickness = 2;
            this.txtMobno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobno.DefaultText = "";
            this.txtMobno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMobno.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtMobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMobno.ForeColor = System.Drawing.Color.White;
            this.txtMobno.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtMobno.Location = new System.Drawing.Point(745, 242);
            this.txtMobno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobno.MaxLength = 10;
            this.txtMobno.Name = "txtMobno";
            this.txtMobno.PasswordChar = '\0';
            this.txtMobno.PlaceholderText = "Enter Mobile Number";
            this.txtMobno.SelectedText = "";
            this.txtMobno.Size = new System.Drawing.Size(328, 42);
            this.txtMobno.TabIndex = 5;
            this.txtMobno.TextChanged += new System.EventHandler(this.txtMobno_TextChanged);
            this.txtMobno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobno_KeyPress);
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
            this.txtEmailid.Location = new System.Drawing.Point(745, 178);
            this.txtEmailid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailid.Name = "txtEmailid";
            this.txtEmailid.PasswordChar = '\0';
            this.txtEmailid.PlaceholderText = "Enter Email ID";
            this.txtEmailid.SelectedText = "";
            this.txtEmailid.Size = new System.Drawing.Size(328, 42);
            this.txtEmailid.TabIndex = 4;
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
            this.txtaddress.Location = new System.Drawing.Point(227, 310);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderText = "Enter Address";
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(328, 97);
            this.txtaddress.TabIndex = 2;
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
            this.txtname.Location = new System.Drawing.Point(227, 182);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Enter Name";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(328, 42);
            this.txtname.TabIndex = 0;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Transparent;
            this.txtid.BorderThickness = 2;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtid.Location = new System.Drawing.Point(227, 123);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "ID";
            this.txtid.ReadOnly = true;
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(328, 42);
            this.txtid.TabIndex = 67;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(359, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(463, 43);
            this.label15.TabIndex = 69;
            this.label15.Text = "Customer Registration";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(626, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Gender";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(108, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 23);
            this.label14.TabIndex = 58;
            this.label14.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(108, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(108, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 62;
            this.label12.Text = "DOB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(626, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "Email ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(108, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 64;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(626, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 66;
            this.label10.Text = "Mobile No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 58);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.FocusedColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(816, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(380, 52);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Red;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(416, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(380, 52);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReg
            // 
            this.btnReg.BorderColor = System.Drawing.Color.White;
            this.btnReg.BorderThickness = 2;
            this.btnReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReg.FillColor = System.Drawing.Color.Red;
            this.btnReg.FocusedColor = System.Drawing.Color.Blue;
            this.btnReg.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(16, 6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(380, 52);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "REGISTRATION";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Shown += new System.EventHandler(this.CustomerForm_Shown);
            this.panel1.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2GradientButton btnReg;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtMobno;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailid;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobpicker;
        private Guna.UI2.WinForms.Guna2ComboBox CBgender;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnRegistration;
    }
}