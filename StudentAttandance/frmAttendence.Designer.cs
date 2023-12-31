﻿namespace StudentAttandance
{
    partial class frmAttendence
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbClassFilter = new System.Windows.Forms.ComboBox();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.lbStudentCount = new System.Windows.Forms.Label();
            this.lbClassRoom = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cS1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cAttID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStuID,
            this.cStuName,
            this.cSex,
            this.cS1,
            this.cS2,
            this.cS3,
            this.cS4,
            this.cS5,
            this.cAttID});
            this.dataGridView1.Location = new System.Drawing.Point(2, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // cbClassFilter
            // 
            this.cbClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassFilter.FormattingEnabled = true;
            this.cbClassFilter.Location = new System.Drawing.Point(468, 78);
            this.cbClassFilter.Name = "cbClassFilter";
            this.cbClassFilter.Size = new System.Drawing.Size(121, 21);
            this.cbClassFilter.TabIndex = 1;
            this.cbClassFilter.SelectedIndexChanged += new System.EventHandler(this.cbClassFilter_SelectedIndexChanged);
            // 
            // cbSub
            // 
            this.cbSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSub.Enabled = false;
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSub.Location = new System.Drawing.Point(665, 78);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(121, 21);
            this.cbSub.TabIndex = 2;
            this.cbSub.SelectedIndexChanged += new System.EventHandler(this.cbSub_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject :";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(82, 9);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(55, 13);
            this.lbClass.TabIndex = 5;
            this.lbClass.Text = "Class ID : ";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(82, 57);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(49, 13);
            this.lbSubject.TabIndex = 6;
            this.lbSubject.Text = "Subject :";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Location = new System.Drawing.Point(255, 33);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(53, 13);
            this.lbTeacher.TabIndex = 7;
            this.lbTeacher.Text = "Teacher :";
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Location = new System.Drawing.Point(82, 81);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(34, 13);
            this.lbShift.TabIndex = 8;
            this.lbShift.Text = "Shift :";
            // 
            // lbStudentCount
            // 
            this.lbStudentCount.AutoSize = true;
            this.lbStudentCount.Location = new System.Drawing.Point(255, 9);
            this.lbStudentCount.Name = "lbStudentCount";
            this.lbStudentCount.Size = new System.Drawing.Size(55, 13);
            this.lbStudentCount.TabIndex = 9;
            this.lbStudentCount.Text = "Students :";
            // 
            // lbClassRoom
            // 
            this.lbClassRoom.AutoSize = true;
            this.lbClassRoom.Location = new System.Drawing.Point(82, 33);
            this.lbClassRoom.Name = "lbClassRoom";
            this.lbClassRoom.Size = new System.Drawing.Size(69, 13);
            this.lbClassRoom.TabIndex = 10;
            this.lbClassRoom.Text = "ClassRoom : ";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(255, 57);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(42, 13);
            this.lbMajor.TabIndex = 11;
            this.lbMajor.Text = "Major : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Major : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ClassRoom : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Students :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Shift :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Teacher :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Subject :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Class ID : ";
            // 
            // cStuID
            // 
            this.cStuID.HeaderText = "StudentID";
            this.cStuID.Name = "cStuID";
            this.cStuID.ReadOnly = true;
            // 
            // cStuName
            // 
            this.cStuName.HeaderText = "StudentName";
            this.cStuName.Name = "cStuName";
            this.cStuName.ReadOnly = true;
            // 
            // cSex
            // 
            this.cSex.HeaderText = "Sex";
            this.cSex.Name = "cSex";
            this.cSex.ReadOnly = true;
            // 
            // cS1
            // 
            this.cS1.HeaderText = "Week 1";
            this.cS1.Items.AddRange(new object[] {
            "P",
            "A",
            "0"});
            this.cS1.Name = "cS1";
            // 
            // cS2
            // 
            this.cS2.HeaderText = "Week 2";
            this.cS2.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS2.Name = "cS2";
            // 
            // cS3
            // 
            this.cS3.HeaderText = "Week 3";
            this.cS3.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS3.Name = "cS3";
            // 
            // cS4
            // 
            this.cS4.HeaderText = "Week 4";
            this.cS4.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS4.Name = "cS4";
            // 
            // cS5
            // 
            this.cS5.HeaderText = "Week 5";
            this.cS5.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS5.Name = "cS5";
            // 
            // cAttID
            // 
            this.cAttID.HeaderText = "AttID";
            this.cAttID.Name = "cAttID";
            this.cAttID.ReadOnly = true;
            this.cAttID.Visible = false;
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMajor);
            this.Controls.Add(this.lbClassRoom);
            this.Controls.Add(this.lbStudentCount);
            this.Controls.Add(this.lbShift);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.cbClassFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAttendence";
            this.Text = "frmAttendence";
            this.Load += new System.EventHandler(this.frmAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbClassFilter;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Label lbStudentCount;
        private System.Windows.Forms.Label lbClassRoom;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS4;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAttID;
    }
}