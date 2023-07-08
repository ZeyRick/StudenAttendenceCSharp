using StudentAttandance.classes;
using StudentAttandance.functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttandance
{
    public partial class frmAddClasses : Form
    {

        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString);
        List<Classes> classes = new List<Classes>();
        List<Subjects> subjects = new List<Subjects>();
        bool isEditing = false;
        public frmAddClasses()
        {
            InitializeComponent();
        }

        private void frmAddClasses_Load(object sender, EventArgs e)
        {
            this.classesTableAdapter.Fill(this.sATTDataSet.Classes);
            loadClassDB();
            loadId();
            loadMajor();

            loadSubjectDB();
            loadSubInputs();
        }

        //functions

        //add classes to data base
        //function for addCLasses
        private dynamic getSelectedSubject(ComboBox cbSubject, ComboBox cbTeacher)
        {
            if (cbSubject.SelectedIndex < 0) return DBNull.Value;
            if (cbTeacher.Items.Count == 1) {
                Subjects s = (Subjects)cbSubject.SelectedItem;
                return s.SubjectID;
            }
            foreach (Subjects s in subjects)
            {
                if(s.Teacher.Equals(cbTeacher.Text) && s.SubjectName.Equals(cbSubject.Text))
                {
                   
                    return s.SubjectID;
                }
            }
            return DBNull.Value;
        }
        private void addClasses()
        {
            string sql;
            if (isEditing)
                sql = "UPDATE Classes SET RoomNumber=@roomnumber, Major=@major, S1=@s1, S2=@s2, S3=@s3, S4=@s4, S5=@s5, StudyShift=@stushift WHERE ClassID=@classId;";
            else
                sql = "INSERT INTO Classes(RoomNumber, Major, S1, S2, S3, S4, S5, StudyShift) VALUES(@roomnumber, @major, @s1, @s2, @s3, @s4, @s5, @stushift)";
            SqlCommand sqlCommand = new SqlCommand(sql);
            var s1 = getSelectedSubject(cbSub1,cbTeacher1);
            var s2 = getSelectedSubject(cbSub2, cbTeacher2);
            var s3 = getSelectedSubject(cbSub3, cbTeacher3);
            var s4 = getSelectedSubject(cbSub4, cbTeacher4);
            var s5 = getSelectedSubject(cbSub5, cbTeacher5);
            sqlCommand.Parameters.AddWithValue("@roomnumber", tbRoomNumber.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@major", cbMajor.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@s1", s1);
            sqlCommand.Parameters.AddWithValue("@s2", s2);
            sqlCommand.Parameters.AddWithValue("@s3", s3);
            sqlCommand.Parameters.AddWithValue("@s4", s4);
            sqlCommand.Parameters.AddWithValue("@s5", s5);
            sqlCommand.Parameters.AddWithValue("@stushift", cbShift.Text.Trim());
            if (isEditing) sqlCommand.Parameters.AddWithValue("@classId", tbID.Text.Trim());

            int count = conn.ExeNonQueryCmd(sqlCommand);
            conn.close();
            this.classesTableAdapter.Fill(this.sATTDataSet.Classes);
            MessageBox.Show("Affected Data :" + count + " Row");
        }

        //load subject and load input for subject
        private void loadTeacherInput(ComboBox cbTeacher, ComboBox cbSubject)
        {
            if (cbSubject.SelectedItem == null)
            {
                cbTeacher.Tag = String.Empty;
                return;
            }
            cbTeacher.Items.Clear();
            cbTeacher.Tag += "isrequired : ";
            List<string> teachers = new List<string>();
            Subjects selectedSubject = (Subjects)cbSubject.SelectedItem;

            foreach(Subjects s in subjects)
            {
                if (!teachers.Contains(s.Teacher) && selectedSubject.SubjectName == s.SubjectName)
                {
                    cbTeacher.Items.Add(s.Teacher);
                    teachers.Add(s.Teacher);
                }
            }
            if (teachers.Count > 1)
            {
                cbTeacher.Enabled = true;

            }
            else
            {
                cbTeacher.Enabled = false;
                cbTeacher.SelectedIndex = 0;
            }
        }
        private void loadSubInputs()
        {
            cbSub1.Items.Clear() ;
            cbSub2.Items.Clear();
            cbSub3.Items.Clear();
            cbSub4.Items.Clear();
            cbSub5.Items.Clear();
            List<string> subs = new List<string>();
            foreach(Subjects s in subjects)
            {
                if (!subs.Contains(s.SubjectName))
                {
                    cbSub1.Items.Add(s);
                    cbSub2.Items.Add(s);
                    cbSub3.Items.Add(s);
                    cbSub4.Items.Add(s);
                    cbSub5.Items.Add(s);
                    subs.Add(s.SubjectName);
                }
               
            }

            cbSub1.DisplayMember = "SubjectName";
            cbSub1.ValueMember = "SubjectID";
            cbSub2.DisplayMember = "SubjectName";
            cbSub2.ValueMember = "SubjectID";
            cbSub3.DisplayMember = "SubjectName";
            cbSub3.ValueMember = "SubjectID";
            cbSub4.DisplayMember = "SubjectName";
            cbSub4.ValueMember = "SubjectID";
            cbSub5.DisplayMember = "SubjectName";
            cbSub5.ValueMember = "SubjectID";
        }
        private void loadSubjectDB()
        {
            string sql = "SELECT * FROM Subjects";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dataReader = conn.ExeQueryCmd(sqlCommand);

            while (dataReader.Read())
            {
                // Create a new class object.
                Subjects sub = new Subjects(
                    Convert.ToInt32(dataReader["SubjectID"]),
                    dataReader["SubjectName"].ToString(),
                    dataReader["Teacher"].ToString()
                );
                // Add the class object to the list.
                subjects.Add(sub);
            }

            conn.close();
        }
        //load classes and load input for classes
        private void loadId()
        {
            if (classes.Count < 1)
            {
                tbID.Text = 1.ToString();
            }
            else
            {
                Classes c = classes.Last<Classes>();
                tbID.Text = (c.ClassID + 1).ToString();
            }
            
        }
        private void loadMajor()
        {
            cbMajor.Items.Clear();
            List<string> Major = new List<string>();
           
            foreach (Classes c in classes)
            {
                
                if (!Major.Contains(c.Major))
                {
                    cbMajor.Items.Add(c.Major);
                    Major.Add(c.Major);
                }
            }
        }
        private void loadClassDB()
        {
            classes.Clear();
            string sql = "SELECT * FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dataReader = conn.ExeQueryCmd(sqlCommand);
            
            while (dataReader.Read())
            {
                Nullable<int> s1;
                if (dataReader["S1"] != DBNull.Value) s1 = Convert.ToInt32(dataReader["S1"]);
                else s1 = null;

                Nullable<int> s2;
                if (dataReader["S2"] != DBNull.Value) s2 = Convert.ToInt32(dataReader["S2"]);
                else s2 = null;

                Nullable<int> s3;
                if (dataReader["S3"] != DBNull.Value) s3 = Convert.ToInt32(dataReader["S3"]);
                else s3 = null;

                Nullable<int> s4;
                if (dataReader["S4"] != DBNull.Value) s4 = Convert.ToInt32(dataReader["S4"]);
                else s4 = null;

                Nullable<int> s5;
                if (dataReader["S5"] != DBNull.Value) s5 = Convert.ToInt32(dataReader["S5"]);
                else s5 = null;
                // Create a new class object.
                Classes class1 = new Classes(
                    Convert.ToInt32(dataReader["ClassID"]),
                    dataReader["RoomNumber"].ToString(),
                    dataReader["Major"].ToString(),
                    s1,
                    s2,
                    s3,
                    s4,
                    s5,
                    dataReader["StudyShift"].ToString());

                // Add the class object to the list.
                classes.Add(class1);
            }
            conn.close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!ValidationsClass.ValidateTextBox(panel1)) return;
            addClasses();
            ValidationsClass.ClearInputs(panel1);
            loadClassDB();
            loadId();
            loadMajor();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ValidationsClass.ClearInputs(panel1);
            
        }

        private void cbSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeacherInput(cbTeacher1, (ComboBox)sender);

        }

        private void cbSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeacherInput(cbTeacher2, (ComboBox)sender);
        }

        private void cbSub3_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeacherInput(cbTeacher3, (ComboBox)sender);
        }

        private void cbSub4_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeacherInput(cbTeacher4, (ComboBox)sender);
        }

        private void cbSub5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeacherInput(cbTeacher5, (ComboBox)sender);
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sATTDataSet);

        }


        //small function for update
        private void enableUpdate()
        {

            btnAdd.Text = "Update";
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            isEditing = true;

            string classId = classesDataGridView.SelectedRows[0].Cells["ClassID"].Value.ToString().Trim();
            string RoomNumber = classesDataGridView.SelectedRows[0].Cells["RoomNumber"].Value.ToString().Trim();
            string Major = classesDataGridView.SelectedRows[0].Cells["Major"].Value.ToString().Trim();
            string s1 = classesDataGridView.SelectedRows[0].Cells["S1"].Value.ToString().Trim();
            string s2 = classesDataGridView.SelectedRows[0].Cells["S2"].Value.ToString().Trim();
            string s3 = classesDataGridView.SelectedRows[0].Cells["S3"].Value.ToString().Trim();
            string s4 = classesDataGridView.SelectedRows[0].Cells["S4"].Value.ToString().Trim();
            string s5 = classesDataGridView.SelectedRows[0].Cells["S5"].Value.ToString().Trim();
            string studyShift = classesDataGridView.SelectedRows[0].Cells["StudyShift"].Value.ToString().Trim();

            tbID.Text = classId;
            tbRoomNumber.Text = RoomNumber;
            cbShift.Text = studyShift;
            cbMajor.Text = Major;

            foreach ( Subjects s in subjects)
            {

                if ( s.SubjectID.ToString() == s1) {  cbSub1.Text = s.SubjectName; cbTeacher1.Text = s.Teacher; }
                if (s.SubjectID.ToString() == s2) {  cbSub2.Text = s.SubjectName; cbTeacher2.Text = s.Teacher; }
                if (s.SubjectID.ToString() == s3) {  cbSub3.Text = s.SubjectName; cbTeacher3.Text = s.Teacher; }
                if (s.SubjectID.ToString() == s4) {  cbSub4.Text = s.SubjectName; cbTeacher4.Text = s.Teacher; }
                if (s.SubjectID.ToString() == s5) {  cbSub5.Text = s.SubjectName; cbTeacher5.Text = s.Teacher; }
            }  


        }
        private void cancelUpdate()
        {
            btnAdd.Text = "Add";
            btnCancel.Visible = false;
            isEditing = false;

            ValidationsClass.ClearInputs(panel1);
            loadId();
        }

        private void classesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            enableUpdate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelUpdate();
        }
    }
}
