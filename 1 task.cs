using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hours ruuner will run?");
            int hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is acceleration of ruuner?");
            int ac = Convert.ToInt32(Console.ReadLine());
            int v = hr*hr*ac;
            Console.WriteLine("{0} kilometers runner will run!", v);
            
            Console.ReadKey();
        }
    }
}
