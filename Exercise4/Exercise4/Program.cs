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
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            int change = secondAltitude - firstAltitude;

            Console.WriteLine("The difference between both altitudes is: " + change);
        }
    }
}
