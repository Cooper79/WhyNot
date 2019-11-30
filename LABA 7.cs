
  
using System;

namespace Lab_7
{
    class Program
    {
        static void Reverse(int inp)
        {
            string result = "";
            int counter = inp.ToString().Length;

            for (int i = 0; i < counter; i++)
            {
                int temp = inp % 10;
                inp = inp / 10;
                result += temp;
            }

            int.TryParse(result, out int output);

            Console.WriteLine(output);
        }

        static void Reverse(string inp)
        {
            string output = "";
            int counter = inp.Length;

            for (int i = counter - 1; i >= 0; i--)
            {
                output += inp[i];
            }
            Console.WriteLine(output);
        }

        static void ReverseSplit(double inp)
        {
            string result = "";
            string[] temp = inp.ToString().Split('.', ',');
            for (int i = temp[0].Length - 1; i >= 0; i--)
            {
                result += temp[0][i];
            }
            result += ",";
            for (int i = temp[1].Length - 1; i >= 0; i--)
            {
                result += temp[1][i];
            }
            double.TryParse(result, out double output);
            Console.WriteLine(output);
        }
        static void ReverseSplit(string inp)
        {
            string output = "";
            string[] temp = inp.ToString().Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = temp[i].Length - 1; j >= 0; j--)
                {
                    output += temp[i][j];
                }
                if (temp.Length != i + 1)
                    output += ',';
            }
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            int numberOne;
            bool a;

            do
            {
                Console.Write("Input your number: ");
                a = int.TryParse(Console.ReadLine(), out numberOne);
                if (!a)
                    Console.WriteLine("Your number is wrong :(");
            } while (!a);
            Reverse(numberOne);

            string str = Console.ReadLine();
            Reverse(str);

            double numberTwo;
            do
            {
                Console.Write("Input your number: ");
                a = double.TryParse(Console.ReadLine(), out numberTwo);
                if (!a)
                    Console.WriteLine("Your number is wrong :(");
            } while (!a);
            ReverseSplit(numberTwo);

            str = Console.ReadLine();
            ReverseSplit(str);
        }
    }
}
