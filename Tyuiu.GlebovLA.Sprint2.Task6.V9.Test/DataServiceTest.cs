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

            string res1 = ds.FindDateOfNextDay(1, 15);
            Assert.AreEqual("16.01", res1);

            string res2 = ds.FindDateOfNextDay(2, 28);
            Assert.AreEqual("01.03", res2);

            string res3 = ds.FindDateOfNextDay(4, 30);
            Assert.AreEqual("01.05", res3);

            string res4 = ds.FindDateOfNextDay(12, 30);
            Assert.AreEqual("31.12", res4);
        }
    }
}