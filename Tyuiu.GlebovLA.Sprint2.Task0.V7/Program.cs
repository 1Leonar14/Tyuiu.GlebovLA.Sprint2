using System;
using Tyuiu.GlebovLA.Sprint2.Task0.V7.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Глебов Л. А. | ПКТБ-26-1";

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Операции сравнения и арифметические выражения в C#             *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #7                                                           *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                    *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Составить логическую последовательность из операций сравнения и     *");
            Console.WriteLine("* арифметических выражений. При x = 103 и y = 475 получить результат: *");
            Console.WriteLine("* (True, False, True, True, True, False).                              *");
            Console.WriteLine("************************************************************************");

            int x = 103;
            int y = 475;

            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine();
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("Результат:");

            Console.Write("(");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);

                if (i < res.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(")");

            Console.ReadKey();
        }
    }
}