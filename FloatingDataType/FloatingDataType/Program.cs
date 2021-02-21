using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingDataType
{
    /// <summary>
    /// Floating Point Data Types lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demostrates floating point data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 10000;

            // calculate and print points per second

            float pointsPerSecond = (float) score / totalSecondsPlayed;
            Console.WriteLine("Points per Second: " + pointsPerSecond);

            Console.WriteLine();

        }
    }
}
