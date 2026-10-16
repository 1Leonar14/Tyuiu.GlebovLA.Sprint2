using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* x (порядковый номер месяца) и y (число). По заданным x и y определить   *");
            Console.WriteLine("* дату следующего дня (принять, что x и y не характеризуют 31 декабря).   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.Write("Введите номер месяца (x): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число (y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();

            string res = ds.FindDateOfNextDay(x, y);

            Console.WriteLine($"Дата следующего дня: {res}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}