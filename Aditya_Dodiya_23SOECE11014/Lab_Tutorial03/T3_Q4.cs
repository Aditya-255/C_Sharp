using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    public class Learner
    {
        // Private data members
        private int id;
        private string name;
        private int age;

        // Public properties
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
                    age = 18; // default fallback age
            }
        }

        // Default constructor
        public Learner()
        {
            id = 0;
            name = "Unknown";
            age = 18;
        }

        // Parameterized constructor
        public Learner(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        // Method to display learner details
        public void Display()
        {
            Console.WriteLine("Learner Details:");
            Console.WriteLine($"ID   : {id}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
            Console.WriteLine("--------------------------");
        }
    }
    internal class T3_Q4
    {
        static void Main(string[] args)
        {
            // Array of 5 learners
            Learner[] learners = new Learner[5];

            // Initialize learners using parameterized constructor
            learners[0] = new Learner(201, "Amit Sharma", 20);
            learners[1] = new Learner(202, "Priya Mehta", 21);
            learners[2] = new Learner(203, "Ravi Kumar", 22);
            learners[3] = new Learner(204, "Sneha Patel", 19);
            learners[4] = new Learner(205, "Rahul Joshi", 23);

            // Display all learners
            Console.WriteLine("=== Learner List ===\n");
            foreach (Learner l in learners)
            {
                l.Display();
            }
        }
    }
}
