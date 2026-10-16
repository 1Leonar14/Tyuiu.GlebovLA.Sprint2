using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GlebovLA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int x, int y)
        {
            int daysInMonth = x switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,

                _ => throw new ArgumentException("Неверный номер месяца")
            };

            if (y < daysInMonth)
            {
                return $"{y + 1:D2}.{x:D2}";
            }
            else
            {
                return $"01.{x + 1:D2}";
            }
        }
    }
}