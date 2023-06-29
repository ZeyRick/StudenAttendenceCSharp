namespace StudentAttandance
{
    partial class frmAddClasses
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
            FontAwesome.Sharp.IconButton btnAdd;
            FontAwesome.Sharp.IconButton BackBtn;
            FontAwesome.Sharp.IconButton btnClear;
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSub1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSub2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSub3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSub4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSub5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTeacher1 = new System.Windows.Forms.ComboBox();
            this.cbTeacher2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTeacher3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTeacher4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTeacher5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            btnAdd = new FontAwesome.Sharp.IconButton();
            BackBtn = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAdd.IconColor = System.Drawing.Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new System.Drawing.Point(23, 279);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(139, 59);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "ADD ";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbMajor
            // 
            this.cbMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbMajor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMajor.DisplayMember = "Major";
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbMajor.ForeColor = System.Drawing.Color.Black;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(157, 202);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(242, 41);
            this.cbMajor.TabIndex = 33;
            this.cbMajor.Tag = "isrequired";
            // 
            // cbShift
            // 
            this.cbShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbShift.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbShift.DisplayMember = "StuShift";
            this.cbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbShift.ForeColor = System.Drawing.Color.Black;
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbShift.Location = new System.Drawing.Point(157, 135);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(242, 41);
            this.cbShift.TabIndex = 32;
            this.cbShift.Tag = "isrequired";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 34);
            this.label4.TabIndex = 30;
            this.label4.Text = "Major : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 34);
            this.label3.TabIndex = 29;
            this.label3.Text = "Shift : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "Class ID: ";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(157, 24);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(242, 37);
            this.tbID.TabIndex = 34;
            this.tbID.Tag = "isrequired, noclear";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(157, 79);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(242, 37);
            this.tbRoomNumber.TabIndex = 36;
            this.tbRoomNumber.Tag = "isrequired";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "Room : ";
            // 
            // cbSub1
            // 
            this.cbSub1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSub1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSub1.DisplayMember = "StuShift";
            this.cbSub1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSub1.ForeColor = System.Drawing.Color.Black;
            this.cbSub1.FormattingEnabled = true;
            this.cbSub1.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbSub1.Location = new System.Drawing.Point(565, 19);
            this.cbSub1.Name = "cbSub1";
            this.cbSub1.Size = new System.Drawing.Size(210, 33);
            this.cbSub1.TabIndex = 38;
            this.cbSub1.Tag = "";
            this.cbSub1.SelectedIndexChanged += new System.EventHandler(this.cbSub1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(434, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Subject 1 : ";
            // 
            // cbSub2
            // 
            this.cbSub2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSub2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSub2.DisplayMember = "StuShift";
            this.cbSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSub2.ForeColor = System.Drawing.Color.Black;
            this.cbSub2.FormattingEnabled = true;
            this.cbSub2.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbSub2.Location = new System.Drawing.Point(565, 105);
            this.cbSub2.Name = "cbSub2";
            this.cbSub2.Size = new System.Drawing.Size(210, 33);
            this.cbSub2.TabIndex = 40;
            this.cbSub2.Tag = "";
            this.cbSub2.SelectedIndexChanged += new System.EventHandler(this.cbSub2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(434, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Subject 2 : ";
            // 
            // cbSub3
            // 
            this.cbSub3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSub3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSub3.DisplayMember = "StuShift";
            this.cbSub3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSub3.ForeColor = System.Drawing.Color.Black;
            this.cbSub3.FormattingEnabled = true;
            this.cbSub3.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbSub3.Location = new System.Drawing.Point(565, 196);
            this.cbSub3.Name = "cbSub3";
            this.cbSub3.Size = new System.Drawing.Size(210, 33);
            this.cbSub3.TabIndex = 42;
            this.cbSub3.Tag = "";
            this.cbSub3.SelectedIndexChanged += new System.EventHandler(this.cbSub3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(434, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Subject 3 : ";
            // 
            // cbSub4
            // 
            this.cbSub4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSub4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSub4.DisplayMember = "StuShift";
            this.cbSub4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSub4.ForeColor = System.Drawing.Color.Black;
            this.cbSub4.FormattingEnabled = true;
            this.cbSub4.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbSub4.Location = new System.Drawing.Point(565, 272);
            this.cbSub4.Name = "cbSub4";
            this.cbSub4.Size = new System.Drawing.Size(210, 33);
            this.cbSub4.TabIndex = 44;
            this.cbSub4.Tag = "";
            this.cbSub4.SelectedIndexChanged += new System.EventHandler(this.cbSub4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(434, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Subject 4 : ";
            // 
            // cbSub5
            // 
            this.cbSub5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSub5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSub5.DisplayMember = "StuShift";
            this.cbSub5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbSub5.ForeColor = System.Drawing.Color.Black;
            this.cbSub5.FormattingEnabled = true;
            this.cbSub5.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbSub5.Location = new System.Drawing.Point(565, 361);
            this.cbSub5.Name = "cbSub5";
            this.cbSub5.Size = new System.Drawing.Size(210, 33);
            this.cbSub5.TabIndex = 46;
            this.cbSub5.Tag = "";
            this.cbSub5.SelectedIndexChanged += new System.EventHandler(this.cbSub5_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(434, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Subject 5 : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTeacher5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbTeacher4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbTeacher3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbTeacher2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbTeacher1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(BackBtn);
            this.panel1.Controls.Add(btnClear);
            this.panel1.Controls.Add(btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSub5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbSub4);
            this.panel1.Controls.Add(this.cbShift);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbMajor);
            this.panel1.Controls.Add(this.cbSub3);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSub2);
            this.panel1.Controls.Add(this.tbRoomNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbSub1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 447);
            this.panel1.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            BackBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            BackBtn.IconColor = System.Drawing.Color.Black;
            BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackBtn.Location = new System.Drawing.Point(112, 361);
            BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(158, 66);
            BackBtn.TabIndex = 49;
            BackBtn.Text = "Back";
            BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            btnClear.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            btnClear.IconColor = System.Drawing.Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new System.Drawing.Point(213, 272);
            btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(158, 66);
            btnClear.TabIndex = 48;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(506, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Teacher :";
            // 
            // cbTeacher1
            // 
            this.cbTeacher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher1.DisplayMember = "StuShift";
            this.cbTeacher1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher1.Enabled = false;
            this.cbTeacher1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTeacher1.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher1.FormattingEnabled = true;
            this.cbTeacher1.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbTeacher1.Location = new System.Drawing.Point(565, 61);
            this.cbTeacher1.Name = "cbTeacher1";
            this.cbTeacher1.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher1.TabIndex = 51;
            this.cbTeacher1.Tag = "";
            // 
            // cbTeacher2
            // 
            this.cbTeacher2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher2.DisplayMember = "StuShift";
            this.cbTeacher2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher2.Enabled = false;
            this.cbTeacher2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTeacher2.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher2.FormattingEnabled = true;
            this.cbTeacher2.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbTeacher2.Location = new System.Drawing.Point(564, 146);
            this.cbTeacher2.Name = "cbTeacher2";
            this.cbTeacher2.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher2.TabIndex = 53;
            this.cbTeacher2.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(506, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Teacher :";
            // 
            // cbTeacher3
            // 
            this.cbTeacher3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher3.DisplayMember = "StuShift";
            this.cbTeacher3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher3.Enabled = false;
            this.cbTeacher3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTeacher3.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher3.FormattingEnabled = true;
            this.cbTeacher3.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbTeacher3.Location = new System.Drawing.Point(565, 237);
            this.cbTeacher3.Name = "cbTeacher3";
            this.cbTeacher3.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher3.TabIndex = 55;
            this.cbTeacher3.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(506, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Teacher :";
            // 
            // cbTeacher4
            // 
            this.cbTeacher4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher4.DisplayMember = "StuShift";
            this.cbTeacher4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher4.Enabled = false;
            this.cbTeacher4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTeacher4.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher4.FormattingEnabled = true;
            this.cbTeacher4.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbTeacher4.Location = new System.Drawing.Point(565, 317);
            this.cbTeacher4.Name = "cbTeacher4";
            this.cbTeacher4.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher4.TabIndex = 57;
            this.cbTeacher4.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(506, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Teacher :";
            // 
            // cbTeacher5
            // 
            this.cbTeacher5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher5.DisplayMember = "StuShift";
            this.cbTeacher5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher5.Enabled = false;
            this.cbTeacher5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbTeacher5.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher5.FormattingEnabled = true;
            this.cbTeacher5.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbTeacher5.Location = new System.Drawing.Point(565, 401);
            this.cbTeacher5.Name = "cbTeacher5";
            this.cbTeacher5.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher5.TabIndex = 59;
            this.cbTeacher5.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label14.Location = new System.Drawing.Point(506, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Teacher :";
            // 
            // frmAddClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddClasses";
            this.Text = "frmAddClasses";
            this.Load += new System.EventHandler(this.frmAddClasses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSub1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSub2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSub3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSub4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSub5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTeacher5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTeacher4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTeacher3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTeacher2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTeacher1;
        private System.Windows.Forms.Label label10;
    }
}