using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x, y с клавиатуры. Ответ округлите до 3 знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.Write("Значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);

            Console.WriteLine($"Значение функции Z = {res}");
            Console.ReadKey();
        }
    }
}