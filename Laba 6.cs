using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<int> arr = new List<int>();
            List<string> qwerty = new List<string>(); //initialization a list
            string inp; //initialization a line
            Console.WriteLine("Input N: ");
            
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input something: ");
                inp = Console.ReadLine(); //input


                qwerty.Add(inp); //add

                arr.Add(inp.Length);

                Console.WriteLine($"Quanity of elements in this line is: {inp.Length}"); //output quantity of elements in line
                Console.WriteLine("***");
            }

            Console.WriteLine("------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"The {i + 1} line is: "); // output lines from list
                Console.WriteLine($"{qwerty[i]}");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"{qwerty[i]}, {qwerty[j]}");
                    }
                }
            }




            Console.ReadLine();

        }
    }
}