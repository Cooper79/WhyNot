using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input N: "); //quanity of rows
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input M: "); //quantity of columns
            int m = Convert.ToInt32(Console.ReadLine());
           
            int[,] arr = new int[n, m];
            int plus = 0, minus = 0, nomer = 0;

            for (int i = 0; i < n; i++) // input
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[" + i + "][" + j + "]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

           for (int i = 0; i < n; i++) //search row
            {
                for(int j = 0; j < m; j++)
                {
                    
                    if (arr[i, j] > 0)
                    {
                        plus++;
                    }

                    if (arr[i, j] < 0)
                    {
                        minus++;
                    }

                   

                    
                }

                if (plus == minus)
                {

                    Console.WriteLine($"Number of row {i}");
                }

                else
                {
                    Console.WriteLine("This row does not meet the condition");
                }

                plus = 0;
                minus = 0;
            }


            for (int j = 0; j < m; j++) //search column
            {
                for (int i = 0; i < n; i++)
                {

                    if (arr[i, j] > 0)
                    {
                        plus++;
                    }

                    if (arr[i, j] < 0)
                    {
                        minus++;
                    }




                }

                if (plus == minus)
                {

                    Console.WriteLine($"Number of column {j}");
                }

                else
                {
                    Console.WriteLine("This column does not meet the condition");
                }

                plus = 0;
                minus = 0;
            }


            for (int i = 0; i < n; i++) // output
            {
                Console.WriteLine("\n");

                for(int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t ");
                }
            }

            Console.ReadLine();
        }
    }
}
