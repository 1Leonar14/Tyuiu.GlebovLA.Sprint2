using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if                                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X, Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) попадает в заштрихованную область.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ попадает в заштрихованную область.");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}