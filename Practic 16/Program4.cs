using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Vector
    {
        private double X, Y, Z;
        public Vector(double x, double y, double z)
        {
            X= x;
            Y = y;
           Z = z;
        }
        public static double operator *(Vector v1, Vector v2)
        {
        return v1.X  * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        } 
        public double this[ int index]
        {
            get
            {
                if (index == 0) return X;
                if (index == 1) return Y;
                if (index == 2) return Z;
                return 0;
            }
            set
            {
                if (index == 0) X = value;
                if (index == 1) Y = value;
                if (index == 2) Z = value;
                
            }
           
        }
        public override string ToString()
        {
            return $"[{X},{Y},{Z}]";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);

        }
    }
}
