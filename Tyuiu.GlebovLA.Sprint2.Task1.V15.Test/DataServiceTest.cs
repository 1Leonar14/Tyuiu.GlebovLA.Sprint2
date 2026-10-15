using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint2.Task1.V15.Lib;

namespace Tyuiu.GlebovLA.Sprint2.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLogicOperations()
        {
            DataService ds = new DataService();

            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = { true, false, false, false, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}