using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.THE_FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the while loop for reference");
            Console.WriteLine();

            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine("the value of i is " + i  + "in the while loop. ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("the for loop");
            Console.WriteLine();

            for(i = 0; i <= 5; i++)
            {
                Console.WriteLine("the value if i is " + i + "in the for loop.");

                Console.Read();
            }
        }

    }
}
