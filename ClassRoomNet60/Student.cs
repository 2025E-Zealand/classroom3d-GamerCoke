using System;
using System.Collections.Generic;
using System.Data;
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
            if (!(Bm >= 1 && Bm <= 12))
                throw new Exception("Invalid birthmonth, has to be between 1 & 12");
            birthmonth = Bm;
            if (!(Bd >= 1 && Bd <=31))
                throw new Exception("Invalid birthday, has to be between 1 & 31");
            birthday = Bd; 
        }

        public string Season()
        {
            string returnString = "";
            switch (birthmonth)
            {
                case 12:
                case 1:
                case 2:
                    returnString = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    returnString = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    returnString = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    returnString = "Autumn";
                    break;
            }
            return $"{returnString}";
        }
    }
}
