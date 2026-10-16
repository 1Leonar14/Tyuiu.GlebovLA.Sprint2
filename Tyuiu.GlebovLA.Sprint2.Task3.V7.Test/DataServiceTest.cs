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

            double x = 2;
            double wait = 50;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}