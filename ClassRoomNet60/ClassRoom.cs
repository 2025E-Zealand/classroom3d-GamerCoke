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

        public void seasonBirthdays()
        {
            int winterBd = 0;
            int springBd = 0;
            int summerBd = 0;
            int autumnBd = 0;
            foreach(Student student in studentList)
            {
                switch (student.Season())
                {
                    case "Winter":
                        winterBd++;
                        break;
                    case "Spring":
                        springBd++;
                        break;
                    case "Summer":
                        summerBd++;
                        break;
                    case "Autumn":
                        autumnBd++;
                        break;
                }
            }
            Console.WriteLine($"{className} has following amount of student-birthdays in each season:\nWinter {winterBd}\nSpring {springBd}\nSummer {summerBd}\nAutumn {autumnBd}\n");
        }

    }
}
