using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 2 && x <= 3) && (y >= 3 && y <= 5)) return true;
            if ((x >= 5 && x <= 8) && (y >= 3 && y <= 4)) return true;
            if ((x >= 2 && x <= 8) && (y == 5)) return true;
            if ((x >= 9 && x <= 11) && (y >= 5 && y <= 8)) return true;
            if ((x >= 1 && x <= 2) && (y >= 10 && y <= 12)) return true;
            if ((x >= 4 && x <= 7) && (y >= 9 && y <= 12)) return true;
            if ((x >= 9 && x <= 10) && (y >= 11 && y <= 13)) return true;
            if (x == 8 && y == 10) return true;
            return false;
        }
    }
}