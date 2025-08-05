using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructors:one kind of speacial method
//its name is same as class name
//never return value
//used to initialize private  members of a class
/*
 * =>Default constructor:if you don't define any constructor,compiler will create a default constructor
 * =>parameterized constructor:if you define a constructor with parameters,compiler will not create a default constructor
 * =>copy constructor:if you define a constructor with one parameter of same class type,compiler will not create a default constructor
 * we wont to create a new object from existing object provide same set of values to all memebers of a class 
 * =>static constructor:if you define a static constructor,compiler will not create a default constructor
 * static keyword with constructor,, static consructor not take arguments
 * called only once ,initialize the static members which belongs to class 
 * =>Private constructor:if you define a private constructor,compiler will not create a default constructor
 * parivate and paramiter less ,
 * when all members are class are static 
 * never allow to create objects
 */
//initialies a object or data members

namespace CSharp_NVB
{
    class Student
    {
        int rno;
        string name;
        public Student()
        {
            Console.Write("Enter the rollno: ");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name: ");
            name = Console.ReadLine();

        }
        public void showdata()
        {
            Console.WriteLine(rno);
            Console.WriteLine(name);
        }
    }
    internal class Constructor
    {
        public static void Main()
        {
            Student s=new Student();
            s.showdata();

            Student s1 = new Student();
            s1.showdata();

            Student s2 = new Student();
            s2.showdata();

            Student s3 = new Student();
            s3.showdata();
        }
    }
}
