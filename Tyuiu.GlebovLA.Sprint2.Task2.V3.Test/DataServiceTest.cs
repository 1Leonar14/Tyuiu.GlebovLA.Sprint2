using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task2.V3.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPointInsideShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(10, 4));
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(13, 13));
        }

        [TestMethod]
        public void CheckPointOutsideShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(6, 4));
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 10));
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        }
    }
}