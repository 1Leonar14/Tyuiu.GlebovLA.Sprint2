using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task3.V7.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x1 = 2;
            double wait1 = 50;
            double res1 = ds.Calculate(x1);
            Assert.AreEqual(wait1, res1);

            double x2 = 0;
            double wait2 = 0.75;
            double res2 = ds.Calculate(x2);
            Assert.AreEqual(wait2, res2);

            double x3 = -1;
            double wait3 = 64;
            double res3 = ds.Calculate(x3);
            Assert.AreEqual(wait3, res3);

            double x4 = -12;
            double wait4 = -16756480;
            double res4 = ds.Calculate(x4);
            Assert.AreEqual(wait4, res4);
        }
    }
}