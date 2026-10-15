using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x1 = 2;
            int y1 = 4;
            bool wait1 = true;
            bool res1 = ds.CheckDotInShadedArea(x1, y1);
            Assert.AreEqual(wait1, res1);

            int x2 = 1;
            int y2 = 1;
            bool wait2 = false;
            bool res2 = ds.CheckDotInShadedArea(x2, y2);
            Assert.AreEqual(wait2, res2);

            int x3 = 10;
            int y3 = 13;
            bool wait3 = true;
            bool res3 = ds.CheckDotInShadedArea(x3, y3);
            Assert.AreEqual(wait3, res3);
        }
    }
}