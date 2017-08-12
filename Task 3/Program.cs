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
            // Считываем значение x
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            // Считываем значение y
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            double u = 0;       // Результат

            // Вычисляем значение u в зависимости от принадлежности точки зашрихованной области
            if (x * x + (y - 1) * (y - 1) <= 1 && y <= 1 - x * x)
                u = x - y;
            else u = x * y + 7;

            // Выводим результат
            Console.WriteLine(u);
            Console.ReadLine();
        }
    }
}
