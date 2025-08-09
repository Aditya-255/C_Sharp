using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    public class Participant
    {
        private string enrolmentNo;
        private string name;

        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Participant()
        {
            enrolmentNo = "Unknown";
            name = "Unnamed Participant";
        }

        public Participant(string enrolNo, string participantName)
        {
            EnrolmentNo = enrolNo;
            Name = participantName;
        }

        public void Display()
        {
            Console.WriteLine("Participant Details:");
            Console.WriteLine($"Enrolment Number: {EnrolmentNo}");
            Console.WriteLine($"Name            : {Name}");
            Console.WriteLine("--------------------------------");
        }
    }
    internal class T3_Q7
    {
        static void Main(string[] args)
        {
            Participant p1 = new Participant();
            p1.EnrolmentNo = "ENR101";
            p1.Name = "Anjali Patel";
            p1.Display();
            
            Participant p2 = new Participant("ENR102", "Ravi Sharma");
            p2.Display();
        }
        }
    }
