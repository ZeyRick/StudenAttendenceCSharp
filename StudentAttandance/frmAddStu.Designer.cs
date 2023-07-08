namespace StudentAttandance
{
    partial class frmAddStudent
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
            this.ADDbtn = new FontAwesome.Sharp.IconButton();
            this.ClearBtn = new FontAwesome.Sharp.IconButton();
            this.BackBtn = new FontAwesome.Sharp.IconButton();
            this.sATTDataSet = new StudentAttandance.SATTDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentcontrolpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sATTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.studentcontrolpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADDbtn
            // 
            this.ADDbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ADDbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.ADDbtn.FlatAppearance.BorderSize = 0;
            this.ADDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.ADDbtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ADDbtn.IconColor = System.Drawing.Color.Black;
            this.ADDbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ADDbtn.Location = new System.Drawing.Point(249, 566);
            this.ADDbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(158, 61);
            this.ADDbtn.TabIndex = 10;
            this.ADDbtn.Text = "ADD ";
            this.ADDbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ADDbtn.UseVisualStyleBackColor = false;
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.ClearBtn.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.ClearBtn.IconColor = System.Drawing.Color.Black;
            this.ClearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClearBtn.Location = new System.Drawing.Point(445, 566);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(158, 61);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(641, 566);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(158, 61);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // sATTDataSet
            // 
            this.sATTDataSet.DataSetName = "SATTDataSet";
            this.sATTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 481);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 427);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Major : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID of Student :";
            // 
            // tbStuName
            // 
            this.tbStuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbStuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStuName.Location = new System.Drawing.Point(222, 145);
            this.tbStuName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(272, 37);
            this.tbStuName.TabIndex = 13;
            this.tbStuName.Tag = "isrequired";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(222, 88);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(272, 37);
            this.tbID.TabIndex = 17;
            this.tbID.Tag = "isrequired";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sex : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "BOD : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Age : ";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSex.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbSex.ForeColor = System.Drawing.Color.Black;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(222, 207);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(272, 41);
            this.cbSex.TabIndex = 22;
            this.cbSex.Tag = "isrequired";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDOB.Location = new System.Drawing.Point(222, 272);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(272, 23);
            this.dtpDOB.TabIndex = 23;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // tbAge
            // 
            this.tbAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAge.Enabled = false;
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(222, 310);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(272, 37);
            this.tbAge.TabIndex = 24;
            this.tbAge.Tag = "isrequired";
            // 
            // cbClasses
            // 
            this.cbClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbClasses.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbClasses.DisplayMember = "ClassID";
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.Enabled = false;
            this.cbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbClasses.ForeColor = System.Drawing.Color.Black;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(159, 481);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(272, 41);
            this.cbClasses.TabIndex = 25;
            this.cbClasses.Tag = "isrequired";
            this.cbClasses.ValueMember = "ClassID";
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // cbShift
            // 
            this.cbShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbShift.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift.Enabled = false;
            this.cbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbShift.ForeColor = System.Drawing.Color.Black;
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Location = new System.Drawing.Point(159, 424);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(272, 41);
            this.cbShift.TabIndex = 26;
            this.cbShift.Tag = "isrequired";
            this.cbShift.SelectedIndexChanged += new System.EventHandler(this.cbShift_SelectedIndexChanged);
            // 
            // cbMajor
            // 
            this.cbMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbMajor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbMajor.ForeColor = System.Drawing.Color.Black;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(159, 370);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(272, 41);
            this.cbMajor.TabIndex = 27;
            this.cbMajor.Tag = "isrequired";
            this.cbMajor.SelectedIndexChanged += new System.EventHandler(this.cbMajor_SelectedIndexChanged);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AllowUserToResizeColumns = false;
            this.studentsDataGridView.AllowUserToResizeRows = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(542, 88);
            this.studentsDataGridView.MultiSelect = false;
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGridView.Size = new System.Drawing.Size(544, 438);
            this.studentsDataGridView.TabIndex = 27;
            this.studentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentsDataGridView_CellMouseDoubleClick);
            // 
            // studentcontrolpanel
            // 
            this.studentcontrolpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.studentcontrolpanel.Controls.Add(this.studentsDataGridView);
            this.studentcontrolpanel.Controls.Add(this.cbMajor);
            this.studentcontrolpanel.Controls.Add(this.cbShift);
            this.studentcontrolpanel.Controls.Add(this.cbClasses);
            this.studentcontrolpanel.Controls.Add(this.tbAge);
            this.studentcontrolpanel.Controls.Add(this.dtpDOB);
            this.studentcontrolpanel.Controls.Add(this.cbSex);
            this.studentcontrolpanel.Controls.Add(this.label8);
            this.studentcontrolpanel.Controls.Add(this.label7);
            this.studentcontrolpanel.Controls.Add(this.label6);
            this.studentcontrolpanel.Controls.Add(this.tbID);
            this.studentcontrolpanel.Controls.Add(this.tbStuName);
            this.studentcontrolpanel.Controls.Add(this.BackBtn);
            this.studentcontrolpanel.Controls.Add(this.ClearBtn);
            this.studentcontrolpanel.Controls.Add(this.ADDbtn);
            this.studentcontrolpanel.Controls.Add(this.label5);
            this.studentcontrolpanel.Controls.Add(this.label4);
            this.studentcontrolpanel.Controls.Add(this.label3);
            this.studentcontrolpanel.Controls.Add(this.label2);
            this.studentcontrolpanel.Controls.Add(this.label1);
            this.studentcontrolpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentcontrolpanel.Location = new System.Drawing.Point(0, 0);
            this.studentcontrolpanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.studentcontrolpanel.Name = "studentcontrolpanel";
            this.studentcontrolpanel.Size = new System.Drawing.Size(1107, 650);
            this.studentcontrolpanel.TabIndex = 6;
            this.studentcontrolpanel.Tag = "isrequired";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 650);
            this.Controls.Add(this.studentcontrolpanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAddStudent";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sATTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.studentcontrolpanel.ResumeLayout(false);
            this.studentcontrolpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SATTDataSet sATTDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Panel studentcontrolpanel;
        private FontAwesome.Sharp.IconButton ADDbtn;
        private FontAwesome.Sharp.IconButton ClearBtn;
        private FontAwesome.Sharp.IconButton BackBtn;
    }
}