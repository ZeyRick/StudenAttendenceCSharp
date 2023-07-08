using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttandance.classes
{
    internal class Students
    {
        int StuID;
        string StudentName;
        string Sex;
        string DOB;
        int Age;
        int ClassID;

        public int stuID { get => StuID; set => StuID = value; }
        public string studentName { get => StudentName; set => StudentName = value; }
        public string sex { get => Sex; set => Sex = value; }
        public string dob { get => DOB; set => DOB = value; }
        public int age { get => Age; set => Age = value; }
        public int classID { get => ClassID; set => ClassID = value; }
    }
}
