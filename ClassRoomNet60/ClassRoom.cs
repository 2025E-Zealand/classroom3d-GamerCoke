using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string className { get; set; }
        public List<Student> studentList { get; set; }
        public DateTime semesterStart { get; set; }

        public ClassRoom()
        {
            studentList = new();
        }
    }
}
