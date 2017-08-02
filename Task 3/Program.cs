using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double u = 0;

            if (x * x + (y - 1) * (y - 1) <= 1 && y <= 1 - x * x) u = x - y;
            else u = x * y + 7;
            Console.WriteLine(u);
            Console.ReadLine();
        }
    }
}
