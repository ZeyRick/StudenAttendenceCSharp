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
            FontAwesome.Sharp.IconButton BackBtn;
            FontAwesome.Sharp.IconButton ClearBtn;
            FontAwesome.Sharp.IconButton ADDbtn;
            this.studentcontrolpanel = new System.Windows.Forms.Panel();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            BackBtn = new FontAwesome.Sharp.IconButton();
            ClearBtn = new FontAwesome.Sharp.IconButton();
            ADDbtn = new FontAwesome.Sharp.IconButton();
            this.studentcontrolpanel.SuspendLayout();
            this.SuspendLayout();
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
            BackBtn.Location = new System.Drawing.Point(560, 420);
            BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(158, 61);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Back";
            BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            ClearBtn.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            ClearBtn.IconColor = System.Drawing.Color.Black;
            ClearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClearBtn.Location = new System.Drawing.Point(364, 420);
            ClearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new System.Drawing.Size(158, 61);
            ClearBtn.TabIndex = 11;
            ClearBtn.Text = "Clear";
            ClearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ClearBtn.UseVisualStyleBackColor = false;
            // 
            // ADDbtn
            // 
            ADDbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            ADDbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(85)))));
            ADDbtn.FlatAppearance.BorderSize = 0;
            ADDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ADDbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            ADDbtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            ADDbtn.IconColor = System.Drawing.Color.Black;
            ADDbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ADDbtn.Location = new System.Drawing.Point(168, 420);
            ADDbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ADDbtn.Name = "ADDbtn";
            ADDbtn.Size = new System.Drawing.Size(158, 61);
            ADDbtn.TabIndex = 10;
            ADDbtn.Text = "ADD ";
            ADDbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ADDbtn.UseVisualStyleBackColor = false;
            ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // studentcontrolpanel
            // 
            this.studentcontrolpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
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
            this.studentcontrolpanel.Controls.Add(BackBtn);
            this.studentcontrolpanel.Controls.Add(ClearBtn);
            this.studentcontrolpanel.Controls.Add(ADDbtn);
            this.studentcontrolpanel.Controls.Add(this.label5);
            this.studentcontrolpanel.Controls.Add(this.label4);
            this.studentcontrolpanel.Controls.Add(this.label3);
            this.studentcontrolpanel.Controls.Add(this.label2);
            this.studentcontrolpanel.Controls.Add(this.label1);
            this.studentcontrolpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentcontrolpanel.Location = new System.Drawing.Point(0, 0);
            this.studentcontrolpanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.studentcontrolpanel.Name = "studentcontrolpanel";
            this.studentcontrolpanel.Size = new System.Drawing.Size(878, 542);
            this.studentcontrolpanel.TabIndex = 6;
            this.studentcontrolpanel.Tag = "isrequired";
            // 
            // cbMajor
            // 
            this.cbMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbMajor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbMajor.ForeColor = System.Drawing.Color.Black;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(594, 35);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(272, 41);
            this.cbMajor.TabIndex = 27;
            this.cbMajor.Tag = "isrequired";
            this.cbMajor.SelectedIndexChanged += new System.EventHandler(this.cbMajor_SelectedIndexChanged);
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
            this.cbShift.Location = new System.Drawing.Point(594, 89);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(272, 41);
            this.cbShift.TabIndex = 26;
            this.cbShift.Tag = "isrequired";
            this.cbShift.SelectedIndexChanged += new System.EventHandler(this.cbShift_SelectedIndexChanged);
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
            this.cbClasses.Location = new System.Drawing.Point(594, 146);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(272, 41);
            this.cbClasses.TabIndex = 25;
            this.cbClasses.Tag = "isrequired";
            this.cbClasses.ValueMember = "ClassID";
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // tbAge
            // 
            this.tbAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(196, 260);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(272, 37);
            this.tbAge.TabIndex = 24;
            this.tbAge.Tag = "isrequired";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDOB.Location = new System.Drawing.Point(196, 219);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(272, 23);
            this.dtpDOB.TabIndex = 23;
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSex.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSex.Enabled = false;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbSex.ForeColor = System.Drawing.Color.Black;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(196, 151);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(272, 41);
            this.cbSex.TabIndex = 22;
            this.cbSex.Tag = "isrequired";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Age : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "BOD : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sex : ";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(196, 36);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(272, 37);
            this.tbID.TabIndex = 17;
            this.tbID.Tag = "isrequired";
            // 
            // tbStuName
            // 
            this.tbStuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbStuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStuName.Location = new System.Drawing.Point(196, 93);
            this.tbStuName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(272, 37);
            this.tbStuName.TabIndex = 13;
            this.tbStuName.Tag = "isrequired";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID of Student :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Major : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 542);
            this.Controls.Add(this.studentcontrolpanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAddStudent";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.studentcontrolpanel.ResumeLayout(false);
            this.studentcontrolpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentcontrolpanel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.ComboBox cbShift;
    }
}