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
    public partial class frmAddSubject : Form
    {
        SQLConnection conn = new SQLConnection(StudentAttandance.Properties.Settings.Default.SATTConnectionString);
        List<Subjects> subjects = new List<Subjects>();
        bool isEditing = false;
        public frmAddSubject()
        {
            InitializeComponent();
        }

        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sATTDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.sATTDataSet.Subjects);
            loadSubjectDB();
            loadSubjectID();
            load_Teacher_SubjectName();
        }
        //load input teacher and subjectname
        private void load_Teacher_SubjectName()
        {

            List<string> teachers = new List<string>();
            List<string> subject = new List<string>();
            cbSubjectName.Items.Clear();
            cbTeacher.Items.Clear();
            foreach(Subjects s in subjects)
            {
                if (!teachers.Contains(s.Teacher))
                {
                    teachers.Add(s.Teacher);
                    cbTeacher.Items.Add(s.Teacher);
                }
                if (!subject.Contains(s.SubjectName))
                {
                    subject.Add(s.SubjectName);
                    cbSubjectName.Items.Add(s.SubjectName);
                }
            }
        }
        //add subject into db
        private void addSubject()
        {
            string subjectName = cbSubjectName.Text.Trim();
            string teacher = cbTeacher.Text.Trim();
            string sql;
            if (!isEditing)
            {
                foreach (Subjects subject in subjects)
                {
                    if (subject.SubjectName.Equals(subjectName) && subject.Teacher.Equals(teacher))
                    {
                        MessageBox.Show("Teacher already teaching that subject");
                        return;
                    }
                }
                sql = "INSERT INTO Subjects(SubjectName, Teacher) VALUES(@subjectname, @teacher)";
            }
            
            else sql = "UPDATE Subjects SET SubjectName=@subjectname, Teacher=@teacher WHERE SubjectID=@subID";

            SqlCommand sqlCommand = new SqlCommand(sql);
            if(isEditing) sqlCommand.Parameters.AddWithValue("@subID", tbID.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@subjectname", subjectName);
            sqlCommand.Parameters.AddWithValue("@teacher", teacher);
            int count = conn.ExeNonQueryCmd(sqlCommand);
            MessageBox.Show("Affected : " + count + " Row");
            conn.close();
        }
        //load input "ID"
        private void loadSubjectID()
        {
            if (subjects.Count < 1)
            {
                tbID.Text = 1.ToString();
            }
            else
            {
                Subjects c = subjects.Last<Subjects>();
                tbID.Text = (c.SubjectID + 1).ToString();
            }

        }

        //load subject from db
        private void loadSubjectDB()
        {
            string sql = "SELECT * FROM Subjects";
            SqlCommand sqlCommand = new SqlCommand(sql);
            SqlDataReader dataReader = conn.ExeQueryCmd(sqlCommand);
            List<Subjects> s = new List<Subjects>();
            while (dataReader.Read())
            {
                // Create a new class object.
                Subjects sub = new Subjects(
                    Convert.ToInt32(dataReader["SubjectID"]),
                    dataReader["SubjectName"].ToString(),
                    dataReader["Teacher"].ToString()
                );
                // Add the class object to the list.
                s.Add(sub);
            }
            subjects = s;
            conn.close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationsClass.ValidateTextBox(panel1)) return;
            addSubject();
            ValidationsClass.ClearInputs(panel1);
            loadSubjectDB();
            loadSubjectID();
            load_Teacher_SubjectName();
            this.subjectsTableAdapter.Fill(this.sATTDataSet.Subjects);
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sATTDataSet);

        }

        private void subjectsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            enableUpdate();

        }

        //small function for update
        private void enableUpdate()
        {

            btnAdd.Text = "Update";
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            isEditing = true;

            string id = subjectsDataGridView.SelectedRows[0].Cells[0].Value.ToString().Trim();
            string subjectName = subjectsDataGridView.SelectedRows[0].Cells[1].Value.ToString().Trim();
            string teacher = subjectsDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
            tbID.Text = id;
            cbSubjectName.Text = subjectName;
            cbTeacher.Text = teacher;
        }
        private void cancelUpdate()
        {
            btnAdd.Text = "Add";
            btnCancel.Visible = false;
            isEditing = false;

            ValidationsClass.ClearInputs(panel1);
            loadSubjectID();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelUpdate();
        }
    }
}
