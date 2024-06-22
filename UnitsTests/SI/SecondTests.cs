using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ksnm.Units;
using Ksnm.Units.SI;

namespace UnitsTests.SI
{
    [TestClass()]
    public class SecondTests
    {
        [TestMethod()]
        public void Test()
        {
            Second<int> s = 1;
            Assert.AreEqual(1, s.Value);
        }
    }
}