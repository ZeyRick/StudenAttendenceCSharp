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
        public frmAddStudent()
        {
            InitializeComponent();
            cbMajor.Items.Add("");
            cbShift.Items.Add("");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadClassDB();
            loadClassMajor();
            
        }
        //events
        private void ADDbtn_Click(object sender, EventArgs e)
        {
            if (!ValidationsClass.ValidateTextBox(studentcontrolpanel)) return;
            AddStu();

        }

        //functions to be called
        //load from classes to input
        private void loadClasses(List<Classes> filteredClasses)
        {
            cbClasses.Items.Clear();
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

            foreach(Classes c in filteredClasses) {
                if (!Shift.Contains(c.StuShift))
                {
                    cbShift.Items.Add(c.StuShift);
                    Shift.Add(c.StuShift);
                }
            }
            if(cbShift.Items.Count > 1) {
                Debug.Print("asdsa");
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
                    dataReader["StudyShift"].ToString());

                // Add the class object to the list.
                classes.Add(class1);
            }
            
            conn.close();
        }

        //for student
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
        //get stu age
        private int getAge()
        {
            DateTime today = DateTime.Today;
            DateTime dob = dtpDOB.Value;
            int age = (int)(today.Year - dob.Year);
            return age;
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
               cbShift.Enabled = false;

            }
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Classes> sClasses = new List<Classes>();
            if( cbShift.SelectedIndex > -1)
            {
                foreach(Classes c in fClasses)
                {

                   if (c.StuShift != cbShift.Text) sClasses.Add(c);

                }

                loadClasses(sClasses);
            }
            else
            {
                loadClasses(fClasses);
            }
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(cbClasses.SelectedIndex > 0)
            {
                
            }
        }

  
    }
}
