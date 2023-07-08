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
using System.Windows.Controls;
using System.Windows.Forms;

namespace StudentAttandance
{
    public partial class frmAttendence : Form
    {
        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString1);
        List<Classes> classes = new List<Classes>();
        List<AttStatus> status = new List<AttStatus>();
        List<Subjects> subjects = new List<Subjects>();
        int rowCount = 0;
        public frmAttendence()
        {
            InitializeComponent();

            initDG();
            //clear class detaails   
            Classes c = (Classes)cbClassFilter.SelectedItem;
            Subjects s = (Subjects)cbSub.SelectedItem;
            lbClass.Text = "";
            lbClassRoom.Text = "";
            lbMajor.Text = "";
            lbShift.Text = "";
            lbStudentCount.Text = "";
            lbSubject.Text = "";
            lbTeacher.Text = "";
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {
            loadClassDB();
            loadClasses(classes);
        }


        //init datagridviews's combo box
        private void initDG()
        {
            //Present: P
            //Absent: A
            //Late: L
            //Excused: E
            //Unexcused: U
            status.Add(new AttStatus() { Name = "", Id = 0 });
            status.Add(new AttStatus() { Name = "P", Id = 1 });
            status.Add(new AttStatus() { Name = "A", Id = 2 });
            status.Add(new AttStatus() { Name = "L", Id = 3 });
            status.Add(new AttStatus() { Name = "E", Id = 4 });
            status.Add(new AttStatus() { Name = "U", Id = 5 });

            var cbo = dataGridView1.Columns[3] as DataGridViewComboBoxColumn;
            cbo.DataSource = status;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Name";

            var cb1 = dataGridView1.Columns[4] as DataGridViewComboBoxColumn;
            cb1.DataSource = status;
            cb1.ValueMember = "Id";
            cb1.DisplayMember = "Name";


            var cb2 = dataGridView1.Columns[5] as DataGridViewComboBoxColumn;
            cb2.DataSource = status;
            cb2.ValueMember = "Id";
            cb2.DisplayMember = "Name";


            var cb3 = dataGridView1.Columns[6] as DataGridViewComboBoxColumn;
            cb3.DataSource = status;
            cb3.ValueMember = "Id";
            cb3.DisplayMember = "Name";


            var cb4 = dataGridView1.Columns[7] as DataGridViewComboBoxColumn;
            cb4.DataSource = status;
            cb4.ValueMember = "Id";
            cb4.DisplayMember = "Name";
        }

        //function loading 

        //load input
        private void loadClasses(List<Classes> classes)
        {
            cbClassFilter.Items.Clear();

            cbClassFilter.SelectedIndex = -1;
            if (classes.Count == 0) return;

            cbClassFilter.DisplayMember = "RoomNumber";
            cbClassFilter.ValueMember = "classId";
            foreach (Classes c in classes)
            {
                cbClassFilter.Items.Add(c);
            }
        }

        //load classes from db


        private void loadClassDB()
        {
            string sql = "SELECT * FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dataReader = conn.ExeQueryCmd(sqlCommand);
            while (dataReader.Read())
            {
                Nullable<int> s1;
                Nullable<int> s2;
                Nullable<int> s3;
                Nullable<int> s4;
                Nullable<int> s5;
                if (dataReader["S1"] != DBNull.Value) s1 = Convert.ToInt32(dataReader["S1"]);
                else s1 = null;
                if (dataReader["S2"] != DBNull.Value) s2 = Convert.ToInt32(dataReader["S2"]);
                else s2 = null;
                if (dataReader["S3"] != DBNull.Value) s3 = Convert.ToInt32(dataReader["S3"]);
                else s3 = null;
                if (dataReader["S4"] != DBNull.Value) s4 = Convert.ToInt32(dataReader["S4"]);
                else s4 = null;
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
        //switch case for loadSutdentssFromDB
        private int getAttStatus(string s)
        {
            if (s.Trim().Equals(string.Empty)) return status[0].Id;
            switch (s.Trim())
            {
                case "P":  return status[1].Id;
                case "A":  return status[2].Id;
                case "L": return status[3].Id;
                case "E": return status[4].Id;
                case "U": return status[5].Id;
                default: return status[0].Id;
            }
        }
        private void loadStudentsFromDB()
        {
            dataGridView1.Rows.Clear();
            rowCount = 0;
            Classes c = (Classes) cbClassFilter.SelectedItem;
            Subjects s = (Subjects)cbSub.SelectedItem;

            string sql = "SELECT * FROM Students WHERE ClassID = @ClassID";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Parameters.AddWithValue("@ClassID", c.ClassID);
            SqlDataReader reader = conn.ExeQueryCmd(sqlCommand);
            while (reader.Read())
            {
                string stuid = reader["StuID"].ToString();
                string stuname = reader["StudentName"].ToString();
                string sex = reader["Sex"].ToString();
                dataGridView1.Rows.Add(stuid, stuname, sex);

                rowCount++;
            }
            conn.close();

            sql = "SELECT Attendence.AttID, Attendence.StuID,  Attendence.W1, Attendence.W2, Attendence.W3, Attendence.W4, Attendence.W5\r\nFROM Students\r\nINNER JOIN Attendence ON Students.StuID = Attendence.StuID AND Students.classid = @ClassID AND Attendence.SubID = @SubID;";
            sqlCommand = new SqlCommand(sql);
            sqlCommand.Parameters.AddWithValue("@ClassID", c.ClassID);
            sqlCommand.Parameters.AddWithValue("@SubID", s.SubjectID);
            reader = conn.ExeQueryCmd(sqlCommand);
            while (reader.Read())
            {
                string attId = reader["AttID"].ToString();
                string stuId = reader["StuID"].ToString();
                var s1Str = reader["W1"].ToString();
                var s2Str = reader["W2"].ToString();
                var s3Str = reader["W3"].ToString();
                var s4Str = reader["W4"].ToString();
                var s5Str = reader["W5"].ToString();

                int s1 = getAttStatus(s1Str);
                int s2 = getAttStatus(s2Str);
                int s3 = getAttStatus(s3Str);
                int s4 = getAttStatus(s4Str);
                int s5 = getAttStatus(s5Str);

                for (int i = 0; i < rowCount; i++)
                {
                    //Debug.Print(dataGridView1.Rows[i].Cells["cStuID"].Value.ToString() + " == " + stuId + " ::: " + (dataGridView1.Rows[i].Cells["cStuID"].Value.ToString() == stuId));
                    if (dataGridView1.Rows[i].Cells["cStuID"].Value.ToString() == stuId)
                    {
                        dataGridView1.Rows[i].Cells["cS1"].Value = s1;
                        dataGridView1.Rows[i].Cells["cS2"].Value = s2;
                        dataGridView1.Rows[i].Cells["cS3"].Value = s3;
                        dataGridView1.Rows[i].Cells["cS4"].Value = s4;
                        dataGridView1.Rows[i].Cells["cS5"].Value = s5;
                        dataGridView1.Rows[i].Cells["cAttID"].Value = attId;
                    }
                   
                }

                
            }
                
            conn.close();
        }

        //combo box change event
        private void loadSubjectInput()
        {
            cbSub.Items.Clear();    
            Classes c = (Classes)cbClassFilter.SelectedItem;
            List<int> addedSub = new List<int>();

            string sql = "SELECT * FROM Subjects WHERE SubjectID=@s1 OR SubjectID=@s2 OR SubjectID=@s3 OR SubjectID=@s4 OR SubjectID=@s5";
            SqlCommand sqlCommand = new SqlCommand(sql);
            if(c.Subjects[0] != null) 
                sqlCommand.Parameters.AddWithValue("@s1", c.Subjects[0]);
            else
                sqlCommand.Parameters.AddWithValue("@s1", DBNull.Value);
            if (c.Subjects[1] != null) 
                sqlCommand.Parameters.AddWithValue("@s2", c.Subjects[1]);
            else
                sqlCommand.Parameters.AddWithValue("@s2", DBNull.Value);
            if (c.Subjects[2] != null)
                sqlCommand.Parameters.AddWithValue("@s3", c.Subjects[2]);
            else
                sqlCommand.Parameters.AddWithValue("@s3", DBNull.Value);
            if (c.Subjects[3] != null)
                sqlCommand.Parameters.AddWithValue("@s4", c.Subjects[3]);
            else
                sqlCommand.Parameters.AddWithValue("@s4", DBNull.Value);
            if (c.Subjects[4] != null)
                sqlCommand.Parameters.AddWithValue("@s5", c.Subjects[4]);
            else
                sqlCommand.Parameters.AddWithValue("@s5", DBNull.Value);

            SqlDataReader reader = conn.ExeQueryCmd(sqlCommand);

            foreach (Nullable<int> s in c.Subjects)
            {
                if (!s.HasValue) continue;

                while (reader.Read())
                {
                    // Create a new class object.
                    Subjects sub = new Subjects(
                        Convert.ToInt32(reader["SubjectID"]),
                        reader["SubjectName"].ToString(),
                        reader["Teacher"].ToString()
                    );
                    sub.SubjectName = sub.SubjectName.Trim() + " (" + sub.Teacher.Trim() + ")";
                    // Add the class object to the list.
                    if (!addedSub.Contains(sub.SubjectID))
                    {
                        cbSub.Items.Add(sub);
                        addedSub.Add(sub.SubjectID);
                    }
                }
            }
            if (cbSub.Items.Count > 0) cbSub.Enabled = true;
            else cbSub.Enabled = false;
            cbSub.DisplayMember = "SubjectName";
            cbSub.ValueMember = "SubjectID";
            conn.close();
        }


        private void cbChanged()
        {
            //clear class detaails   
            lbClass.Text = "";
            lbClassRoom.Text = "";
            lbMajor.Text = "";
            lbShift.Text = "";
            lbStudentCount.Text ="";
            lbSubject.Text = "";
            lbTeacher.Text = "";

            if (cbClassFilter.SelectedIndex < 0 || cbSub.SelectedIndex < 0) return;
            loadStudentsFromDB();

            //show class detaails   
            Classes c = (Classes) cbClassFilter.SelectedItem;
            Subjects s = (Subjects) cbSub.SelectedItem;
            lbClass.Text = c.ClassID.ToString();
            lbClassRoom.Text = c.RoomNumber.ToString();
            lbMajor.Text = c.Major.ToString();
            lbShift.Text = c.StuShift.ToString();
            lbStudentCount.Text = rowCount.ToString();
            lbSubject.Text = s.SubjectName.ToString();
            lbTeacher.Text = s.Teacher.ToString();
            
        }
        private void cbClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubjectInput();
            cbChanged();
        }

        private void cbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChanged();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the cell that has been changed
            if (dataGridView1.Rows.Count < 1) return;
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            string attid = dataGridView1.Rows[rowIndex].Cells["cAttID"].Value.ToString();
            Debug.Print(attid);
            string sql = "UPDATE Attendence SET W1=@w1, W2=@w2, W3=@w3, W4=@w4, W5=@w5 WHERE AttID =@AttID";
            SqlCommand sqlCommand = new SqlCommand(sql);

            string w1 = dataGridView1.Rows[rowIndex].Cells["cS1"].Value.ToString();
            Debug.Print(w1);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the cell that has been changed
            if (dataGridView1.Rows.Count < 1) return;
            int rowIndex = e.RowIndex;

            string sql = "UPDATE Attendence SET W1=@w1, W2=@w2, W3=@w3, W4=@w4, W5=@w5 WHERE AttID =@AttID";
            SqlCommand sqlCommand = new SqlCommand(sql);

            string attid = dataGridView1.Rows[rowIndex].Cells["cAttID"].Value.ToString();
            int w1Index = Int32.Parse(dataGridView1.Rows[rowIndex].Cells["cS1"].Value.ToString());
            int w2Index = Int32.Parse(dataGridView1.Rows[rowIndex].Cells["cS2"].Value.ToString());
            int w3Index = Int32.Parse(dataGridView1.Rows[rowIndex].Cells["cS3"].Value.ToString());
            int w4Index = Int32.Parse(dataGridView1.Rows[rowIndex].Cells["cS4"].Value.ToString());
            int w5Index = Int32.Parse(dataGridView1.Rows[rowIndex].Cells["cS5"].Value.ToString());

            string w1 = status[w1Index].Name;
            string w2 = status[w2Index].Name;
            string w3 = status[w3Index].Name;
            string w4 = status[w4Index].Name;
            string w5 = status[w5Index].Name;

            sqlCommand.Parameters.AddWithValue("@w1", w1);
            sqlCommand.Parameters.AddWithValue("@w2", w2);
            sqlCommand.Parameters.AddWithValue("@w3", w3);
            sqlCommand.Parameters.AddWithValue("@w4", w4);
            sqlCommand.Parameters.AddWithValue("@w5", w5);
            sqlCommand.Parameters.AddWithValue("@AttID", attid);

            int count = conn.ExeNonQueryCmd(sqlCommand);
            conn.close();

            MessageBox.Show("Effected Rows : " + count.ToString());
        }
    }
}
