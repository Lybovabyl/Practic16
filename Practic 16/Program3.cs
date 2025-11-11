using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Money
    {
        public int R { get; set; }
        public int K { get; set; }

        public Money(int r, int k)
        {
            R = r;
            K = k;
        }

      
        public static Money operator +(Money m1, Money m2)
        {
            return new Money(m1.R + m2.R, m1.K + m2.K);
        }

     
        public static bool operator ==(Money m1, Money m2)
        {
            if ((m1 is null && m2 is null)) return true;
            if (m1 is null || m2 is null) return false;
            return m1.R == m2.R && m1.K == m2.K;
        }

       
        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1 == m2);
        }
         public override string ToString()
        {
            return $"{R} руб {K} коп";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var m1 = new Money(10, 50);
            var m2 = new Money(5, 75);
            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 == new Money(10, 50));
        }
    }
}