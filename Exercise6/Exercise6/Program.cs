using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());

            float cosine = (float)Math.Cos(angle * Math.PI / 180);
            float sine = (float)Math.Sin(angle * Math.PI / 180);

            Console.WriteLine("The sine of " + angle + " degrees is: " + sine);
            Console.WriteLine("The cosine of " + angle + " degrees is: " + cosine);
        }
    }
}
