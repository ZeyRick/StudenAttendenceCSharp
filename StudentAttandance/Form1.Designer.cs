namespace StudentAttandance
{
    partial class Form1
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnAddSub = new FontAwesome.Sharp.IconButton();
            this.DataListBtnSIdeControl = new FontAwesome.Sharp.IconButton();
            this.btnClasses = new FontAwesome.Sharp.IconButton();
            this.btnAttendance = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.Closebtn = new FontAwesome.Sharp.IconButton();
            this.Minimizebtn = new FontAwesome.Sharp.IconButton();
            this.FullScreenbtn = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.panelSidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panelSidebar.Controls.Add(this.btnStudent);
            this.panelSidebar.Controls.Add(this.btnAddSub);
            this.panelSidebar.Controls.Add(this.DataListBtnSIdeControl);
            this.panelSidebar.Controls.Add(this.btnClasses);
            this.panelSidebar.Controls.Add(this.btnAttendance);
            this.panelSidebar.Controls.Add(this.Home);
            this.panelSidebar.Controls.Add(this.panel4);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(212, 566);
            this.panelSidebar.TabIndex = 1;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSub.FlatAppearance.BorderSize = 0;
            this.btnAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSub.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAddSub.IconColor = System.Drawing.Color.Black;
            this.btnAddSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSub.Location = new System.Drawing.Point(0, 312);
            this.btnAddSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(212, 54);
            this.btnAddSub.TabIndex = 16;
            this.btnAddSub.Text = "Add Subject";
            this.btnAddSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // DataListBtnSIdeControl
            // 
            this.DataListBtnSIdeControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataListBtnSIdeControl.FlatAppearance.BorderSize = 0;
            this.DataListBtnSIdeControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataListBtnSIdeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataListBtnSIdeControl.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.DataListBtnSIdeControl.IconColor = System.Drawing.Color.Black;
            this.DataListBtnSIdeControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DataListBtnSIdeControl.Location = new System.Drawing.Point(0, 254);
            this.DataListBtnSIdeControl.Margin = new System.Windows.Forms.Padding(2);
            this.DataListBtnSIdeControl.Name = "DataListBtnSIdeControl";
            this.DataListBtnSIdeControl.Size = new System.Drawing.Size(212, 58);
            this.DataListBtnSIdeControl.TabIndex = 13;
            this.DataListBtnSIdeControl.Text = "Data List";
            this.DataListBtnSIdeControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataListBtnSIdeControl.UseVisualStyleBackColor = true;
            // 
            // btnClasses
            // 
            this.btnClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasses.FlatAppearance.BorderSize = 0;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.btnClasses.IconColor = System.Drawing.Color.Black;
            this.btnClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClasses.Location = new System.Drawing.Point(0, 200);
            this.btnClasses.Margin = new System.Windows.Forms.Padding(2);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(212, 54);
            this.btnClasses.TabIndex = 12;
            this.btnClasses.Text = "Class";
            this.btnClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.btnAttendance.IconColor = System.Drawing.Color.Black;
            this.btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAttendance.Location = new System.Drawing.Point(0, 146);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(212, 54);
            this.btnAttendance.TabIndex = 11;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.Home.IconColor = System.Drawing.Color.Black;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.Location = new System.Drawing.Point(0, 92);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(212, 54);
            this.Home.TabIndex = 10;
            this.Home.Text = "Home";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 92);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Attandance";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(235)))));
            this.panelHeader.Controls.Add(this.iconButton4);
            this.panelHeader.Controls.Add(this.Closebtn);
            this.panelHeader.Controls.Add(this.Minimizebtn);
            this.panelHeader.Controls.Add(this.FullScreenbtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(212, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 58);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraginForm);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(235)))));
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(14)))), ((int)(((byte)(131)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(1, 7);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(197, 42);
            this.iconButton4.TabIndex = 11;
            this.iconButton4.Text = "Dashboard";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Closebtn.IconColor = System.Drawing.Color.Black;
            this.Closebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Closebtn.IconSize = 25;
            this.Closebtn.Location = new System.Drawing.Point(775, 0);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(24, 19);
            this.Closebtn.TabIndex = 10;
            this.Closebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Minimizebtn.FlatAppearance.BorderSize = 0;
            this.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Minimizebtn.IconColor = System.Drawing.Color.Black;
            this.Minimizebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizebtn.IconSize = 30;
            this.Minimizebtn.Location = new System.Drawing.Point(724, 0);
            this.Minimizebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(24, 19);
            this.Minimizebtn.TabIndex = 10;
            this.Minimizebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Minimizebtn.UseVisualStyleBackColor = false;
            // 
            // FullScreenbtn
            // 
            this.FullScreenbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.FullScreenbtn.FlatAppearance.BorderSize = 0;
            this.FullScreenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullScreenbtn.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.FullScreenbtn.IconColor = System.Drawing.Color.Black;
            this.FullScreenbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FullScreenbtn.IconSize = 25;
            this.FullScreenbtn.Location = new System.Drawing.Point(750, 0);
            this.FullScreenbtn.Margin = new System.Windows.Forms.Padding(2);
            this.FullScreenbtn.Name = "FullScreenbtn";
            this.FullScreenbtn.Size = new System.Drawing.Size(24, 19);
            this.FullScreenbtn.TabIndex = 9;
            this.FullScreenbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FullScreenbtn.UseVisualStyleBackColor = false;
            this.FullScreenbtn.Click += new System.EventHandler(this.FullScreenbtn_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(212, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 512);
            this.panelMain.TabIndex = 3;
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnStudent.IconColor = System.Drawing.Color.Black;
            this.btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudent.Location = new System.Drawing.Point(0, 366);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(212, 54);
            this.btnStudent.TabIndex = 17;
            this.btnStudent.Text = "Students";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 566);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton DataListBtnSIdeControl;
        private FontAwesome.Sharp.IconButton btnClasses;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton Closebtn;
        private FontAwesome.Sharp.IconButton Minimizebtn;
        private FontAwesome.Sharp.IconButton FullScreenbtn;
        private FontAwesome.Sharp.IconButton btnAddSub;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnStudent;
    }
}

