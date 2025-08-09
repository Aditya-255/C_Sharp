using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    public class Car
    {
        private string color;
        private int speed;

        public Car(string carColor, int carSpeed)
        {
            color = carColor;
            speed = carSpeed;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Car Color: " + color);
            Console.WriteLine("Car Speed: " + speed + " km/h");
        }

        public void Accelerate(int increment)
        {
            speed += increment; 
            Console.WriteLine("Car accelerated. New speed: " + speed + " km/h");
        }

        public void ApplyBrakes(int decrement)
        {
            speed -= decrement; 
            if (speed < 0) speed = 0; 
            Console.WriteLine("Brakes applied. New speed: " + speed + " km/h");
        }
    }
    internal class T3_Q1
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", 60);   
            Car car2 = new Car("Blue", 80);  

            Console.WriteLine("Car 1 Details:");
            car1.DisplayDetails();
            car1.Accelerate(20);
            car1.ApplyBrakes(10);

            Console.WriteLine();

            Console.WriteLine("Car 2 Details:");
            car2.DisplayDetails();
            car2.Accelerate(30);
            car2.ApplyBrakes(50);
        }
    }
}
