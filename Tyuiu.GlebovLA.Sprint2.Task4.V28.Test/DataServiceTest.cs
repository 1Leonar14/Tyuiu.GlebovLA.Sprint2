using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x1 = 1;
            double y1 = 10;
            double wait1 = 13;
            double res1 = ds.Calculate(x1, y1);
            Assert.AreEqual(wait1, res1);

            double x2 = 5;
            double y2 = 2;
            double wait2 = 4.771;
            double res2 = ds.Calculate(x2, y2);
            Assert.AreEqual(wait2, res2);
        }
    }
}