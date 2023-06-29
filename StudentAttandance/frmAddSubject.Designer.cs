namespace StudentAttandance
{
    partial class frmAddSubject
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
            FontAwesome.Sharp.IconButton btnClear;
            FontAwesome.Sharp.IconButton btnAdd;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubjectName = new System.Windows.Forms.ComboBox();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            BackBtn = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTeacher);
            this.panel1.Controls.Add(BackBtn);
            this.panel1.Controls.Add(btnClear);
            this.panel1.Controls.Add(btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSubjectName);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 421);
            this.panel1.TabIndex = 0;
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
            BackBtn.Location = new System.Drawing.Point(147, 326);
            BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(158, 66);
            BackBtn.TabIndex = 60;
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
            btnClear.Location = new System.Drawing.Point(258, 245);
            btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(158, 66);
            btnClear.TabIndex = 59;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new System.Drawing.Point(40, 249);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(139, 59);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "ADD ";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 34);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 34);
            this.label3.TabIndex = 51;
            this.label3.Text = "Teacher : ";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(174, 40);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(242, 37);
            this.tbID.TabIndex = 55;
            this.tbID.Tag = "isrequired, noclear";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(83)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 56;
            this.label1.Text = "Name : ";
            // 
            // cbSubjectName
            // 
            this.cbSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbSubjectName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSubjectName.DisplayMember = "Major";
            this.cbSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbSubjectName.ForeColor = System.Drawing.Color.Black;
            this.cbSubjectName.FormattingEnabled = true;
            this.cbSubjectName.Location = new System.Drawing.Point(174, 90);
            this.cbSubjectName.Name = "cbSubjectName";
            this.cbSubjectName.Size = new System.Drawing.Size(242, 41);
            this.cbSubjectName.TabIndex = 54;
            this.cbSubjectName.Tag = "isrequired";
            // 
            // cbTeacher
            // 
            this.cbTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbTeacher.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeacher.DisplayMember = "Major";
            this.cbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.cbTeacher.ForeColor = System.Drawing.Color.Black;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(174, 148);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(242, 41);
            this.cbTeacher.TabIndex = 61;
            this.cbTeacher.Tag = "isrequired";
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 446);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddSubject";
            this.Text = "frmAddSubject";
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ComboBox cbSubjectName;
    }
}