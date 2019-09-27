using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            if (N > 1)
            {
                int K=0;
                double res = 0.0;
                while (res < N)
                {
                    res = Math.Pow(3,K);
                    K++;
                }
                Console.WriteLine("K = {0}", K);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
