using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int e = 1; e <= 10; e++)
            {
                for (int d = 0; d <= 10; d++)
                {
                    Console.WriteLine(e + " X " + d + " = " + e * d);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
