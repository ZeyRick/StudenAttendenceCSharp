using StudentAttandance.classes;
using StudentAttandance.functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttandance
{
    public partial class frmAttendence : Form
    {
        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString1);
        List<Classes> classes = new List<Classes>();
        public frmAttendence()
        {
            InitializeComponent();
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {
            loadClassDB();
            loadClasses(classes);
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
        private void loadStudentsFromDB()
        {
            int rowCount = 0;
            Classes c = (Classes) cbClassFilter.SelectedItem;
            string sql = "SELECT Attendence.StuID,  Attendence.W1, " +
                " Attendence.W2,  Attendence.W3,  Attendence.W4,  Attendence.W5," +
                "Attendence.SubID, Students.StudentName, Students.Sex, Students.DOB," +
                " Students.Age FROM Attendence INNER JOIN Students ON " +
                "Students.ClassID = @ClassID AND Attendence.SubID = @SubID";
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Parameters.AddWithValue("@ClassID", c.ClassID);
            sqlCommand.Parameters.AddWithValue("@SubID", 1);
            SqlDataReader reader = conn.ExeQueryCmd(sqlCommand);


            while(reader.Read())
            {
                bool isAdded = false;

                string stuid = reader["StuID"].ToString();
                string stuname = reader["StudentName"].ToString();
                string sex = reader["Sex"].ToString();
                string s1 = reader["W1"].ToString();
                string s2 = reader["W2"].ToString();
                string s3 = reader["W3"].ToString();
                string s4 = reader["W4"].ToString();
                string s5 = reader["W5"].ToString();

                dataGridView1.Rows.Add(stuid, stuname, sex);


                dataGridView1.Rows[rowCount].Cells[3].Value = 1;

                rowCount++;
              

            }
                
            conn.close();
        }

        //combo box change event
        private void cbChanged()
        {
            if (cbClassFilter.SelectedIndex < 0 || cbWeek.SelectedIndex < 0) return;
            loadStudentsFromDB();
        }
        private void cbClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStudentsFromDB();
            cbChanged();
        }

        private void cbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChanged();
        }
    }
}
