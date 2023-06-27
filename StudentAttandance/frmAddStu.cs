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
        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString);
        List<Classes> classes = new List<Classes>();

        public frmAddStudent()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sattDataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.sattDataSet1.Students);
            // TODO: This line of code loads data into the 'sattDataSet1.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.sattDataSet1.Classes);
            loadClassId();
        }
        //events
        private void ADDbtn_Click(object sender, EventArgs e)
        {
            if (!ValidationsClass.ValidateTextBox(studentcontrolpanel)) return;
            AddStu();

        }

        //functions to be called

        //load from db
        private void loadClassId()
        {
            string sql = "SELECT * FROM Classes";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dataReader = conn.ExeQueryCmd(sqlCommand);
            while (dataReader.Read())
            {
                // Create a new class object.
                Classes class1 = new Classes(
                    Convert.ToInt32(dataReader["ClassID"]),
                    dataReader["RoomNumber"].ToString(),
                    dataReader["Major"].ToString(),
                    Convert.ToInt32(dataReader["S1"]),
                    Convert.ToInt32(dataReader["S2"]),
                    Convert.ToInt32(dataReader["S3"]),
                    Convert.ToInt32(dataReader["S4"]),
                    Convert.ToInt32(dataReader["S5"]),
                    dataReader["StuShift"].ToString());

                // Add the class object to the list.
                classes.Add(class1);
            }
            conn.close();
        }

        private void AddStu()
        {
           
            string studentName = tbStuName.Text;
            string sex = cbSex.Text;
            string age = getAge().ToString();
            int classId = Convert.ToInt32(tbID.Text);

            string sql = "INSERT INTO Students (StudentName, Sex, Age, ClassID) VALUES (@StudentName, @Sex, @Age, @ClassID)";
            SqlCommand sqlCommand = new SqlCommand(sql);

            // Bind the parameters to the values from the form.
            sqlCommand.Parameters.AddWithValue("@StudentName", studentName);
            sqlCommand.Parameters.AddWithValue("@Sex", sex);
            sqlCommand.Parameters.AddWithValue("@Age", age);
            sqlCommand.Parameters.AddWithValue("@ClassID", classId);

            int count = conn.ExeNonQueryCmd(sqlCommand);

            MessageBox.Show(count.ToString());

        }

        private int getAge()
        {
            DateTime today = DateTime.Today;
            DateTime dob = dtpDOB.Value;
            int age = (int)(today.Year - dob.Year);
            return age;
        }

    }
}
