using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    public class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 100)
                    age = value;
                else
                    age = 18;
            }
        }

        public Student()
        {
            id = 0;
            name = "Unknown";
            age = 18;
        }

        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void Display()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
    internal class T3_Q3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Student 1 (Default Constructor):");
            s1.Display();

            Console.WriteLine();

            Student s2 = new Student(101, "Amit Sharma", 20);
            Console.WriteLine("Student 2 (Parameterized Constructor):");
            s2.Display();

            Console.WriteLine();

            s1.Id = 102;
            s1.Name = "Priya Mehta";
            s1.Age = 22;
            Console.WriteLine("Student 1 (After Setting Properties):");
            s1.Display();
        }
    }
}
