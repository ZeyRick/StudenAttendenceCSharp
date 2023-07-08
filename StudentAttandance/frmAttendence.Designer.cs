namespace StudentAttandance
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
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.cStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cS1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cS5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.cS5});
            this.dataGridView1.Location = new System.Drawing.Point(2, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbClassFilter
            // 
            this.cbClassFilter.FormattingEnabled = true;
            this.cbClassFilter.Location = new System.Drawing.Point(352, 38);
            this.cbClassFilter.Name = "cbClassFilter";
            this.cbClassFilter.Size = new System.Drawing.Size(121, 21);
            this.cbClassFilter.TabIndex = 1;
            this.cbClassFilter.SelectedIndexChanged += new System.EventHandler(this.cbClassFilter_SelectedIndexChanged);
            // 
            // cbWeek
            // 
            this.cbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbWeek.Location = new System.Drawing.Point(72, 38);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(121, 21);
            this.cbWeek.TabIndex = 2;
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
            this.cS1.HeaderText = "Subject 1";
            this.cS1.Items.AddRange(new object[] {
            "P",
            "A",
            "0"});
            this.cS1.Name = "cS1";
            // 
            // cS2
            // 
            this.cS2.HeaderText = "Subject 2";
            this.cS2.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS2.Name = "cS2";
            // 
            // cS3
            // 
            this.cS3.HeaderText = "Subject 3";
            this.cS3.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS3.Name = "cS3";
            // 
            // cS4
            // 
            this.cS4.HeaderText = "Subject 4";
            this.cS4.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS4.Name = "cS4";
            // 
            // cS5
            // 
            this.cS5.HeaderText = "Subject 5";
            this.cS5.Items.AddRange(new object[] {
            "P",
            "A"});
            this.cS5.Name = "cS5";
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.cbWeek);
            this.Controls.Add(this.cbClassFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAttendence";
            this.Text = "frmAttendence";
            this.Load += new System.EventHandler(this.frmAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbClassFilter;
        private System.Windows.Forms.ComboBox cbWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS4;
        private System.Windows.Forms.DataGridViewComboBoxColumn cS5;
    }
}