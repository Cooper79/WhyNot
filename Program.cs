using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your three-digit number: ");
            int q = Convert.ToInt32(Console.ReadLine());
            int l = q % 10;// last number
            int s = q % 100 / 10;// second number
            int f = q / 100;// first number

            int a = f + s + l;

            if ((f + s + l) % 2 == 0)
            {
                Console.WriteLine("Parnoe  {0}",a);
            }
            else
            {
                Console.WriteLine("Neparnoe {0}", a);
            }

            Console.ReadKey();
        }
    }
}
