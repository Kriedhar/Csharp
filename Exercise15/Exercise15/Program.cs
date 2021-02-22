using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********");
            Console.WriteLine("1-NewGame\n2-LoadGame\n3-Options\n4-Quit");
            Console.WriteLine("**********");
            int answer = int.Parse(Console.ReadLine());

            if(answer == 1 || answer == 2)
            {
                Console.WriteLine("Loading Game...");
            }
            else if(answer == 3)
            {
                Console.WriteLine("Loading Menu...");
            }
            else if(answer == 4)
            {
                Console.WriteLine("Byeee!");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }

            switch (answer)
            {
                case 1:
                case 2:
                    Console.WriteLine("Loading Game...");
                    break;
                case 3:
                    Console.WriteLine("Loading Menu...");
                    break;
                case 4:
                    Console.WriteLine("Byeee!");
                    break;
                default:
                    Console.WriteLine("Incorrect Answer");
                    break;
            }
        }
    }
}
