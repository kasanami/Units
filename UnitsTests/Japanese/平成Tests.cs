using Ksnm.Units.Japanese;

namespace UnitsTests.Japanese
{
    [TestClass()]
    public class 平成Tests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            平成<int> 平成 = 1;
            Assert.AreEqual(1, 平成.Value);

            昭和<int> 昭和 = (昭和<int>)平成;
            Assert.AreEqual(64, 昭和.Value);
        }
    }
}