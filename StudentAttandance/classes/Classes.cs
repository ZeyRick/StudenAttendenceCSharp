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
        public Nullable<int>[] Subjects { get; set; }
        public string StuShift { get; set; }

        public Classes(int classID, string roomNumber, string major, Nullable<int> s1, Nullable<int> s2, Nullable<int> s3, Nullable<int> s4, Nullable<int> s5, string stuShift)
        {
            Subjects = new Nullable<int>[5] {
                s1, s2, s3, s4, s5
            };
            ClassID = classID;
            RoomNumber = roomNumber;
            Major = major;
            StuShift = stuShift;
        }

        public Classes()
        {

        }

    }
}
