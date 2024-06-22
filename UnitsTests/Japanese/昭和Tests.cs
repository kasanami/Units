using Ksnm.Units.Japanese;

namespace UnitsTests.Japanese
{
    [TestClass()]
    public class 昭和Tests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            昭和<int> 昭和 = 1;
            Assert.AreEqual(1, 昭和.Value);
        }
    }
}