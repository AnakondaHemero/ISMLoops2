using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите number");
            int number;
            int res = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                res = res + number;
            } while (number != 0);
            Console.WriteLine("res = {0},", res);
        }
    }
}
