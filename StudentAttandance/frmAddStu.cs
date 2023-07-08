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
using System.Xml;

namespace StudentAttandance
{
    public partial class frmAddStudent : Form
    {
        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString1);
        List<Classes> classes = new List<Classes>();
        List<Classes> fClasses = new List<Classes>();
        List<string> Major = new List<string>();
        List<string> Shift = new List<string>();
        bool isEditing = false;
        public frmAddStudent()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            loadTable();
            loadClassDB();
            loadClassMajor();
  
        }
        //events
        private void ADDbtn_Click(object sender, EventArgs e)
        {
            if (!ValidationsClass.ValidateTextBox(studentcontrolpanel)) return;
            AddStu();
            loadTable();
        }

        //functions to be called

        //loadStudent
        private string loadlatestID()
        {
            string latestID;
            string sql = "SELECT MAX(StuID) FROM Students";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dr = conn.ExeQueryCmd(sqlCommand);
            if (dr.Read())
            {
                 latestID = (Int32.Parse(dr[0].ToString()) + 1).ToString();
            }
            else
            {
                latestID = "0";
            }
            conn.close();
            
            return latestID;

        }
        //load table
        private void loadTable()
        {
            string sql = "SELECT Students.StuID, Students.StudentName, Students.Sex, Students.DOB, Students.Age, Classes.ClassID, Classes.Major, Classes.StudyShift,  Classes.RoomNumber FROM Students INNER JOIN Classes ON Students.ClassID = Classes.ClassID;";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn.sqlConnection);
            DataTable table = new DataTable();
            da.Fill(table);
            studentsDataGridView.DataSource = table;
            studentsDataGridView.Columns["StuID"].DisplayIndex = 0;
            studentsDataGridView.Columns["ClassID"].Visible = false;
            studentsDataGridView.Refresh();
            conn.close();
            tbID.Text = loadlatestID();
        }
        //load from classes to input
        private void loadClasses(List<Classes> filteredClasses)
        {
            cbClasses.Items.Clear();
 
            cbClasses.SelectedIndex = -1;
            if (filteredClasses.Count == 0) return;

            cbClasses.DisplayMember = "RoomNumber";
            cbClasses.ValueMember = "classId";
            foreach(Classes c in filteredClasses)
            {
                cbClasses.Items.Add(c);
            }
            if (cbClasses.Items.Count > 1)
            {
                cbClasses.Enabled = true;
            }
            else
            {
                cbClasses.SelectedIndex = 0;
                cbClasses.Enabled = false;
            }
        }

        private void loadClassShift(List<Classes> filteredClasses)
        {
            Shift.Clear();
            cbShift.Items.Clear();
            if (filteredClasses.Count < 0) return;

            foreach(Classes c in filteredClasses) {
                
                if (!Shift.Contains(c.StuShift))
                {
                    cbShift.Items.Add(c.StuShift);
                    Shift.Add(c.StuShift);
                }
            }
            if(cbShift.Items.Count > 1) {

                cbShift.SelectedIndex = -1;
                cbClasses.SelectedIndex = -1;
                cbShift.Enabled = true;
            }
            else
            {
                cbShift.SelectedIndex = 0;
                cbShift.Enabled = false;
            }
        }

        private void loadClassMajor()
        {
            Major.Clear();
            cbMajor.Items.Clear();
            foreach (Classes c in classes)
            {

                if (!Major.Contains(c.Major))
                {
                    cbMajor.Items.Add(c.Major);
                    Major.Add(c.Major);
                }

            }

        }

      
        //load from db
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

        //for add student
        private void AddStu()
        {
            string sql;
            string studentName = tbStuName.Text;
            string sex = cbSex.Text;
            string age = tbAge.Text;
            DateTime dob = dtpDOB.Value;
            Classes selectedClass = (Classes)cbClasses.SelectedItem;
            int classId = selectedClass.ClassID;
            if (isEditing)
                sql = "UPDATE Students SET StudentName = @StudentName,  Sex = @Sex, Age = @Age,  DOB = @DOB, ClassID = @ClassID WHERE StuID = @StuID;";
            else
                sql = "INSERT INTO Students (StudentName, Sex, Age, DOB, ClassID) VALUES (@StudentName, @Sex, @Age, @DOB, @ClassID)";
            SqlCommand sqlCommand = new SqlCommand(sql);

            // Bind the parameters to the values from the form.
            sqlCommand.Parameters.AddWithValue("@StudentName", studentName);
            sqlCommand.Parameters.AddWithValue("@Sex", sex);
            sqlCommand.Parameters.AddWithValue("@Age", age);
            sqlCommand.Parameters.AddWithValue("@DOB", dob);
            sqlCommand.Parameters.AddWithValue("@ClassID", classId);
            if (isEditing) sqlCommand.Parameters.AddWithValue("@StuID", Int32.Parse(tbID.Text));

            int count = conn.ExeNonQueryCmd(sqlCommand);
            if (isEditing) disableEdit();
            conn.close();
            MessageBox.Show(count.ToString());

        }


        //classes event

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMajor.SelectedIndex > -1)
            {
                fClasses.Clear();
                foreach(Classes c in classes)
                {
                    if (c.Major == cbMajor.Text) fClasses.Add(c);
                }
                loadClassShift(fClasses);
            }
            else
            {
               
               cbShift.Items.Clear();
               cbShift.SelectedIndex = -1;
               cbShift.Enabled = false;

            }
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Classes> sClasses = new List<Classes>();
            if( cbShift.SelectedIndex > -1)
            {
   
                foreach (Classes c in fClasses)
                {
                    if (c.StuShift == cbShift.Text)
                    {
                        sClasses.Add(c);
                    }
                }

                loadClasses(sClasses);
            }
            else
            {
    
                cbClasses.SelectedIndex = -1;
 
            }
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(cbClasses.SelectedIndex > 0)
            {
                
            }
        }
        //small function for table double click event
        private void enableEdit()
        {
            isEditing = true;
            ADDbtn.Text = "Updaate";
            ClearBtn.Text ="Cancel";
        }

        private void disableEdit()
        {
            isEditing = false;
            ADDbtn.Text = "Add";
            ClearBtn.Text = "Clear";
        }

        private void studentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = studentsDataGridView.SelectedRows[0];

            // Get the values from the selected row
            string stuID = selectedRow.Cells["StuID"].Value.ToString();
            string studentName = selectedRow.Cells["StudentName"].Value.ToString();
            string sex = selectedRow.Cells["Sex"].Value.ToString();
            DateTime dob = (DateTime)selectedRow.Cells["DOB"].Value;
            string age = selectedRow.Cells["Age"].Value.ToString();
            string classId = selectedRow.Cells["ClassID"].Value.ToString();

            // Set the values in the input controls
            tbID.Text = stuID;
            tbStuName.Text = studentName;
            cbSex.Text = sex;
            dtpDOB.Value = dob;
            tbAge.Text = age;
            foreach(Classes c in classes)
            {
 
                if (c.ClassID.ToString() == classId)
                {
                    cbMajor.Text = c.Major;
                    cbShift.Text = c.StuShift;
                    cbClasses.SelectedItem = c; 
                }
            }

            enableEdit();
        }
        //get stu age small function for DOB value change

        private int getAge()
        {
            DateTime today = DateTime.Today;
            DateTime dob = dtpDOB.Value;
            int age = (int)(today.Year - dob.Year);
            return age;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            int age = getAge();
            if(age > 100 || age < 18)
            {
                MessageBox.Show ("Invalid Age");
                tbAge.Text = "";
                return;
            }
            tbAge.Text = age.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            disableEdit();
            tbID.Text = loadlatestID();
            tbAge.Text = "";
            tbStuName.Text = "";
            cbSex.SelectedIndex = -1;
            cbMajor.SelectedIndex = -1;
            cbClasses.SelectedIndex = -1;
        }
    }
}
