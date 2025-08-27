using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string name { get; private set; }
        public int birthmonth { get; private set; }
        public int birthday { get; private set; }

        public Student(string Name, int Bm, int Bd)
        {
            name = Name;
            birthmonth = Bm;
            birthday = Bd;
        }
    }
}
