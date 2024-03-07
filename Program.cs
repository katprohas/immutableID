using System.Collections.Generic;
namespace Immutable
{
    class Program
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            //constructor sets immutable int property and initializes rest to default
            public Student(int i)
            {
                Id = i;
                FirstName = string.Empty;
                LastName = string.Empty;
            }

        }//end Student
        public static void Main(string[] args)
        {
            Student student1 = new Student(10);
            student1.FirstName = "John";
            student1.LastName = "Doe";
            Student student2 = new Student(20, "Jane", "Doe");

            Console.WriteLine($"{student1.Id}, {student1.FirstName}, {student1.LastName}");
            Console.WriteLine();
            Console.WriteLine($"{student2.Id}, {student2.FirstName}, {student2.LastName}");
        }
    }//end program
} //end namespace