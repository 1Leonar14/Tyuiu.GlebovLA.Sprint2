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

            int x = 2;
            int y = 4;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}