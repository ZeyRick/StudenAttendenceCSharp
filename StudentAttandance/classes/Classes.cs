using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttandance.classes
{
    public class Classes
    {
        public int ClassID { get; set; }
        public string RoomNumber { get; set; }
        public string Major { get; set; }
        public int S1 { get; set; }
        public int S2 { get; set; }
        public int S3 { get; set; }
        public int S4 { get; set; }
        public int S5 { get; set; }
        public string StuShift { get; set; }

        public Classes(int classID, string roomNumber, string major, int s1, int s2, int s3, int s4, int s5, string stuShift)
        {
            ClassID = classID;
            RoomNumber = roomNumber;
            Major = major;
            S1 = s1;
            S2 = s2;
            S3 = s3;
            S4 = s4;
            S5 = s5;
            StuShift = stuShift;
        }

        public Classes()
        {

        }

    }
}
