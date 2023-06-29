using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttandance.classes
{
     public class Subjects
    {
        int subjectID;
        string subjectName;
        string teacher;

        public int SubjectID { get => subjectID; set => subjectID = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string Teacher { get => teacher; set => teacher = value; }

        public Subjects(int subjectID, string subjectName, string teacher)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            Teacher = teacher;
        }

        public Subjects() { }
    }
}
