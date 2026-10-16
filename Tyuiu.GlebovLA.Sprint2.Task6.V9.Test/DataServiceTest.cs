using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfNextDay()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(1, 15);
            Assert.AreEqual("16.01", res);
        }
    }
}