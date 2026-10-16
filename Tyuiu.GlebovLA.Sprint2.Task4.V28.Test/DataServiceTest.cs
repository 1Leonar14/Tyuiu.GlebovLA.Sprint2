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
            double x = 1;
            double y = 10;
            double wait = 13;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}