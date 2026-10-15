using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GlebovLA.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + y == 578;
            res[1] = x * 2 != y - 269;
            res[2] = x + 300 < y;
            res[3] = x * 5 > y;
            res[4] = x + y <= 600;
            res[5] = x * 4 >= y * 2;

            return res;
        }
    }
}