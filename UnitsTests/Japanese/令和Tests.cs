using Ksnm.Units.Japanese;

namespace UnitsTests.Japanese
{
    [TestClass()]
    public class 令和Tests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            令和<int> 令和 = 1;
            Assert.AreEqual(1, 令和.Value);

            平成<int> 平成 = (平成<int>)令和;
            Assert.AreEqual(31, 平成.Value);

            昭和<int> 昭和 = (昭和<int>)令和;
            Assert.AreEqual(94, 昭和.Value);

            令和 = 6;
            昭和 = (昭和<int>)令和;
            Assert.AreEqual(99, 昭和.Value);
        }
    }
}