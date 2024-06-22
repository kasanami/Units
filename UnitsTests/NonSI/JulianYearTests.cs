using Ksnm.Units.NonSI;

namespace UnitsTests.SI
{
    [TestClass()]
    public class JulianYearTests
    {
        [TestMethod()]
        public void Test()
        {
            JulianYear<int> y = 1;
            Assert.AreEqual(1, y.Value);
        }
    }
}