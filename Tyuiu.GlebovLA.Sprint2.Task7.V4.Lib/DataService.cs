using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GlebovLA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;

            if ((y >= 0) && (y <= Math.Sqrt(1 - Math.Pow(x, 2))) && (x >= -1) && (x <= 1))
            {
                res = true;
            }

            return res;
        }
    }
}