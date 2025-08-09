using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    public class Clock
    {
        private int hour;
        private int min;
        private int sec;

        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        public Clock(int h, int m, int s)
        {
            hour = (h >= 0 && h < 24) ? h : 0;
            min = (m >= 0 && m < 60) ? m : 0;
            sec = (s >= 0 && s < 60) ? s : 0;
        }

        public void IncrementSecond()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        public void DisplayTime()
        {
            Console.WriteLine($"Time: {hour:D2}:{min:D2}:{sec:D2}");
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return min;
        }

        public int GetSeconds()
        {
            return sec;
        }
    }
    internal class T3_Q2
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();
            Console.WriteLine("Clock 1 (Default Constructor):");
            clock1.DisplayTime();

            clock1.IncrementSecond();
            Console.WriteLine("After incrementing one second:");
            clock1.DisplayTime();

            Console.WriteLine();

            Clock clock2 = new Clock(23, 59, 59);
            Console.WriteLine("Clock 2 (Parameterized Constructor):");
            clock2.DisplayTime();

            clock2.IncrementSecond();
            Console.WriteLine("After incrementing one second:");
            clock2.DisplayTime();

            Console.WriteLine($"Hour: {clock2.GetHour()}");
            Console.WriteLine($"Minute: {clock2.GetMinute()}");
            Console.WriteLine($"Second: {clock2.GetSeconds()}");
        }
    }
}
