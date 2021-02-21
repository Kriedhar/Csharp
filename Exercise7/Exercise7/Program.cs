using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insert a Fahrenheit temperature: ");
            float fahr = float.Parse(Console.ReadLine());

            float celsius = (fahr - 32) / 9 * 5;

            Console.WriteLine(fahr + " degrees fahrenheir equals to " + celsius + " degrees celsius");

        }
    }
}
