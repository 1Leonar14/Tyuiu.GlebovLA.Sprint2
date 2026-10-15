using System;
using Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Проверка точки в заштрихованной области";

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                *");
            Console.WriteLine("* Проверка принадлежности точки заштрихованной области     *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович, ПКТБ-26-1         *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите X (от 1 до 15): ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                return;
            }

            Console.Write("Введите Y (от 1 до 15): ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                return;
            }

            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                Console.WriteLine("Ошибка: координаты должны быть от 1 до 15.");
                return;
            }

            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}