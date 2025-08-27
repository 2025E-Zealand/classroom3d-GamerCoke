using ClassRoomNet60;

Console.WriteLine("Hello, World!\n");

ClassRoom newClass = new ClassRoom();
newClass.className = "3Q";
newClass.semesterStart = new DateTime(2019-08-26);

Student mikkel = new Student("Mikkel Barfod", 12, 15);
Student malthe = new Student("Malthe Anders Bruhn", 9, 14);
Student sara = new Student("Sara Iversen", 8, 9);

newClass.studentList.Add(mikkel);
newClass.studentList.Add(malthe);
newClass.studentList.Add(sara);