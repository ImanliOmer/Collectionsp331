namespace CollectionsP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Group> groups = new List<Group>();

            //var group = new Group()
            //{
            //    Name = "P331"
            //};

            //AddGroup(groups, group);


            //var group2 = new Group()
            //{
            //    Name = "P331"
            //};
            //AddGroup(groups, group2);

            //var group3 = new Group()
            //{
            //    Name = "p322"
            //};
            //AddGroup(groups, group3);

            //var group4 = new Group()
            //{
            //    Name="P222"
            //};

            //foreach (var groupList in groups) 
            //{
            //    Console.WriteLine(groupList.GetDetails());
            //}
            ////////////////////////////////////////////////////////**Task2**///////////////////////////////////////////////////////////////////////////

            List<Student> students = new List<Student>();

            var student1 = new Student
            {
                Name = "Omer",
                Surname = "Imanov",
                PIN = 2003
            };

            AddStudent(students, student1);

            var student2 = new Student()
            {
                Name = "Huseyn",
                Surname = "Elizahde",
                PIN = 2004
            };

            AddStudent(students, student2);

            var student3 = new Student
            {
                Name = "Alyar",
                Surname = "Musayev",
                PIN = 2004
            };

            foreach (var studentList in students)  
            {
                Console.WriteLine(studentList.GetDetails());
            }

            Console.WriteLine(CountwLetter(students));



            static void AddStudent(List<Student> students, Student student)
            {
                if (!students.Any(s => s.PIN == student.PIN))
                {
                    students.Add(student);
                }
            }


            int CountwLetter(List<Student> students)
            {
                students.Count(s => s.Name.Contains("a"));
                return students.Count;
            }

        }


        //class Group
        //{
        //    public string Name { get; set; }

        //    public Group(string name)
        //    {
        //        Name = name;
        //    }

        //    public Group()
        //    {
        //    }

        //    public string GetDetails()
        //    {
        //        return $"Group name: {Name}";
        //    }
        //}



        //static void AddGroup(List<Group> groups, Group group)
        //{
        //    if (!groups.Any(g => g.Name == group.Name))
        //    {
        //        groups.Add(group);
        //    }
        //}
        ///////////////////////////////////////////////////////////////////**TASK2**////////////////////////////////////////////////////////////////////////////////
        class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int PIN { get; set; }

            public Student(string name, string surname, int pin)
            {
                
            }

            public Student()
            {
            }

            public string GetDetails()
            {
                return $"Name: {Name}\n Surname: {Surname}\n Pin: {PIN}";
            }
        }

     


    }
}