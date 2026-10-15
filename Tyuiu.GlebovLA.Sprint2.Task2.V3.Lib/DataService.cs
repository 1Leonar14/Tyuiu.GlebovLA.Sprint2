namespace Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            switch (y)
            {
                case 3:
                    return (x >= 3 && x <= 5) || (x >= 9 && x <= 12);

                case 4:
                    return (x >= 3 && x <= 5) || (x >= 9 && x <= 10);

                case 5:
                    return x >= 3 && x <= 10;

                case 6:
                case 7:
                case 8:
                    return x >= 7 && x <= 13;

                case 9:
                    return (x >= 4 && x <= 8) || (x >= 11 && x <= 12);

                case 10:
                    return x == 4 || x == 7 || x == 11 || x == 12;

                case 11:
                    return x == 3 || x == 4 || x == 7 ||
                           (x >= 11 && x <= 13);

                case 12:
                case 13:
                    return x == 4 || x == 7 || (x >= 11 && x <= 13);

                default:
                    return false;
            }
        }
    }
}