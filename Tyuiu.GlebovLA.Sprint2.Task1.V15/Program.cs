using System;
using Tyuiu.GlebovLA.Sprint2.Task1.V15.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Глебов Л.А.";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения и логические операции                           *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович, ПКТБ-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнения, логических операций и          *");
            Console.WriteLine("* арифметических выражений, которая вернет массив:                         *");
            Console.WriteLine("* (True, False, False, False, False, True), при a=415, b=616, c=134, d=127 *");
            Console.WriteLine("****************************************************************************");

            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;

            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Результат:");
            Console.WriteLine("(" + string.Join(", ", res) + ")");

            Console.ReadKey();
        }
    }
}