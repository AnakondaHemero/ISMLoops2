using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите K");
            int K = int.Parse(Console.ReadLine());
            if (N > 0 && K > 0)
            {
                double S;
                S = 0.0;
                for (int i = 1; i <= N; i++)
                {
                    S = S + Math.Pow(i,K);
                }
                Console.WriteLine("S = {0}", S);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
