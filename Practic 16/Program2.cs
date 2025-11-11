using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{

    public class Score
    {
        private int math;
        private int russian;
        private int physics;
         public int this[string subject]
        {
            get
            {
                switch (subject.ToLower())
                {
                    case "математика": return math;
                    case "русский": return russian;
                    case "физика": return physics;
                    default: return 0;
                }
            }
            set
            {
                switch (subject.ToLower())
                {
                    case "математика": math = value; break;
                    case "русский": russian = value; break;
                    case "физика": physics = value; break;
                }
            }
        }
         public override string ToString()
        {
            return $"Математика: {math}, Русский: {russian}, Физика: {physics}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Score();
            s["Математика"] = 5;
            s["Русский"] = 4;
            Console.WriteLine(s["Математика"]);
            Console.WriteLine(s);

        }
    }
}
