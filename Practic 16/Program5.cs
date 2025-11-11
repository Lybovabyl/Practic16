using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
           
        }

      
        public static bool operator >(Time t1, Time t2)
        {
            if (t1.Hours != t2.Hours)
                return t1.Hours > t2.Hours;
            if (t1.Minutes != t2.Minutes)
                return t1.Minutes > t2.Minutes;
                return t1.Seconds > t2.Seconds;
        }

        public static bool operator <(Time t1, Time t2)
        {
            return !(t1 > t2) && t1 != t2;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if ((t1 is null && t2 is null)) return true;
            if (t1 is null || t2 is null) return false;
            return t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds == t2.Seconds;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return Hours;
                if (index == 1) return Minutes;
                if (index == 2) return Seconds;
                return 0;
            }
            set
            {
                if (index == 0) Hours = value;
                if (index == 1) Minutes = value;
                if (index == 2) Seconds = value;
            }
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Time(14, 35, 9);
            var t2 = new Time(9, 10, 5);
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1[1]);
            t1[2] = 59;
            Console.WriteLine(t1);
        }
    } }
    


