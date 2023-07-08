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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.BackBtn = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
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
            this.cbTeacher5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbTeacher4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTeacher3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTeacher2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTeacher1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.classesDataGridView = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sATTDataSet = new StudentAttandance.SATTDataSet();
            this.classesTableAdapter = new StudentAttandance.SATTDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager = new StudentAttandance.SATTDataSetTableAdapters.TableAdapterManager();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudyShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(639, 548);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 55);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "ADD ";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.BackBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackBtn.IconColor = System.Drawing.Color.Black;
            this.BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackBtn.Location = new System.Drawing.Point(1195, 539);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(158, 61);
            this.BackBtn.TabIndex = 49;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(988, 542);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 61);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbMajor
            // 
            this.cbMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbMajor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMajor.DisplayMember = "Major";
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbMajor.ForeColor = System.Drawing.Color.Black;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(168, 178);
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
            this.cbShift.Location = new System.Drawing.Point(168, 123);
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
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Major : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Shift : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
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
            this.tbID.Location = new System.Drawing.Point(168, 22);
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
            this.tbRoomNumber.Location = new System.Drawing.Point(168, 77);
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
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
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
            this.cbSub1.Location = new System.Drawing.Point(143, 249);
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
            this.label5.Location = new System.Drawing.Point(28, 249);
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
            this.cbSub2.Location = new System.Drawing.Point(143, 329);
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
            this.label6.Location = new System.Drawing.Point(28, 329);
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
            this.cbSub3.Location = new System.Drawing.Point(143, 413);
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
            this.label7.Location = new System.Drawing.Point(28, 413);
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
            this.cbSub4.Location = new System.Drawing.Point(143, 484);
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
            this.label8.Location = new System.Drawing.Point(28, 484);
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
            this.cbSub5.Location = new System.Drawing.Point(143, 566);
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
            this.label9.Location = new System.Drawing.Point(28, 567);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Subject 5 : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTeacher5);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.cbShift);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbSub4);
            this.panel1.Controls.Add(this.cbTeacher4);
            this.panel1.Controls.Add(this.cbMajor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbSub3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbTeacher3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbSub5);
            this.panel1.Controls.Add(this.cbSub1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTeacher2);
            this.panel1.Controls.Add(this.cbSub2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbRoomNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbTeacher1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 639);
            this.panel1.TabIndex = 1;
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
            this.cbTeacher5.Location = new System.Drawing.Point(143, 603);
            this.cbTeacher5.Name = "cbTeacher5";
            this.cbTeacher5.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher5.TabIndex = 59;
            this.cbTeacher5.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label14.Location = new System.Drawing.Point(84, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Teacher :";
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
            this.cbTeacher4.Location = new System.Drawing.Point(143, 525);
            this.cbTeacher4.Name = "cbTeacher4";
            this.cbTeacher4.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher4.TabIndex = 57;
            this.cbTeacher4.Tag = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(84, 528);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Teacher :";
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
            this.cbTeacher3.Location = new System.Drawing.Point(143, 451);
            this.cbTeacher3.Name = "cbTeacher3";
            this.cbTeacher3.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher3.TabIndex = 55;
            this.cbTeacher3.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(84, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Teacher :";
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
            this.cbTeacher2.Location = new System.Drawing.Point(142, 367);
            this.cbTeacher2.Name = "cbTeacher2";
            this.cbTeacher2.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher2.TabIndex = 53;
            this.cbTeacher2.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(84, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Teacher :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(84, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Teacher :";
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
            this.cbTeacher1.Location = new System.Drawing.Point(143, 288);
            this.cbTeacher1.Name = "cbTeacher1";
            this.cbTeacher1.Size = new System.Drawing.Size(100, 21);
            this.cbTeacher1.TabIndex = 51;
            this.cbTeacher1.Tag = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(804, 540);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 61);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // classesDataGridView
            // 
            this.classesDataGridView.AllowUserToAddRows = false;
            this.classesDataGridView.AllowUserToDeleteRows = false;
            this.classesDataGridView.AllowUserToResizeColumns = false;
            this.classesDataGridView.AllowUserToResizeRows = false;
            this.classesDataGridView.AutoGenerateColumns = false;
            this.classesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.RoomNumber,
            this.Major,
            this.S1,
            this.S2,
            this.S3,
            this.S4,
            this.S5,
            this.StudyShift});
            this.classesDataGridView.DataSource = this.classesBindingSource;
            this.classesDataGridView.Location = new System.Drawing.Point(467, 8);
            this.classesDataGridView.MultiSelect = false;
            this.classesDataGridView.Name = "classesDataGridView";
            this.classesDataGridView.ReadOnly = true;
            this.classesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.classesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classesDataGridView.Size = new System.Drawing.Size(945, 511);
            this.classesDataGridView.TabIndex = 51;
            this.classesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classesDataGridView_CellMouseDoubleClick);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.sATTDataSet;
            // 
            // sATTDataSet
            // 
            this.sATTDataSet.DataSetName = "SATTDataSet";
            this.sATTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendencesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentAttandance.SATTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Major
            // 
            this.Major.DataPropertyName = "Major";
            this.Major.HeaderText = "Major";
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            // 
            // S1
            // 
            this.S1.DataPropertyName = "S1";
            this.S1.HeaderText = "S1";
            this.S1.Name = "S1";
            this.S1.ReadOnly = true;
            // 
            // S2
            // 
            this.S2.DataPropertyName = "S2";
            this.S2.HeaderText = "S2";
            this.S2.Name = "S2";
            this.S2.ReadOnly = true;
            // 
            // S3
            // 
            this.S3.DataPropertyName = "S3";
            this.S3.HeaderText = "S3";
            this.S3.Name = "S3";
            this.S3.ReadOnly = true;
            // 
            // S4
            // 
            this.S4.DataPropertyName = "S4";
            this.S4.HeaderText = "S4";
            this.S4.Name = "S4";
            this.S4.ReadOnly = true;
            // 
            // S5
            // 
            this.S5.DataPropertyName = "S5";
            this.S5.HeaderText = "S5";
            this.S5.Name = "S5";
            this.S5.ReadOnly = true;
            // 
            // StudyShift
            // 
            this.StudyShift.DataPropertyName = "StudyShift";
            this.StudyShift.HeaderText = "StudyShift";
            this.StudyShift.Name = "StudyShift";
            this.StudyShift.ReadOnly = true;
            // 
            // frmAddClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 661);
            this.Controls.Add(this.classesDataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BackBtn);
            this.Name = "frmAddClasses";
            this.Text = "frmAddClasses";
            this.Load += new System.EventHandler(this.frmAddClasses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATTDataSet)).EndInit();
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
        private SATTDataSet sATTDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private SATTDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private SATTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton BackBtn;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.DataGridView classesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn S1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn S3;
        private System.Windows.Forms.DataGridViewTextBoxColumn S4;
        private System.Windows.Forms.DataGridViewTextBoxColumn S5;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudyShift;
    }
}