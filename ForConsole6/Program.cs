using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            int number = N;
            double result = 0.0;
            if (N > 0)
            {
                double element;
            for (int i = 1; i <= N; i++)
            {
                element = Math.Pow(i, N - i + 1);
                result += element;
            }
                Console.WriteLine("Result = {0}", result);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
