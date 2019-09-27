using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите P");
            double P = Double.Parse(Console.ReadLine());
            double km = 10.0;
            if (P > 0 && P<50)
            {
                int K = 0;
                double S = 0.0;
                P /= 100;
                while (S < 200)
                {
                    S = S + km * P;
                    K++;
                }
                Console.WriteLine("K = {0}, S = {1}", K, S);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
