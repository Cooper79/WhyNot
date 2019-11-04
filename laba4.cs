using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Input N: "); // 6 {2,1,5,4,9,6}
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int mip = 0, map = 0; // MIP= Minimal Point, MAP= Maximum Point (номер макс и мин элементов)


            Console.WriteLine("------------------");

            for (int i=0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int min = arr[0], max = arr[0];

            for (int i = 0; i < N; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                    mip = i;
                }
            }

            for (int i = 0; i < N; i++) 
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    map = i;
                }
            }


            Console.WriteLine("------------------");

            Console.WriteLine($"minimun{min}, maximum{max}, mip{mip + 1}, map{map + 1}");

            

            if (mip < map)
            {
                for(int i=mip; i < N / 2; i++)
                {
                    int tmp = arr[i];
                    arr[i] = arr[N - i - 1];
                    arr[N - i - 1] = tmp;
                }
            } else if (map < mip)
            {
                for(int i = map; i < N / 2; i++)
                {
                    int tmp = arr[i];
                    arr[i] = arr[N - i - 1];
                    arr[N - i - 1] = tmp;
                }
            }

            Console.WriteLine("----------------------");


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
