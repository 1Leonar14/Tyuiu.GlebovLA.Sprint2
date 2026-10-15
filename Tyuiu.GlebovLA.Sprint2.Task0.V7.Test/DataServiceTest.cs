using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task0.V7.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCompareOperations()
        {
            DataService ds = new DataService();

            int x = 103;
            int y = 475;

            bool[] res = ds.GetCompareOperations(x, y);

            bool[] wait = { false, true, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}