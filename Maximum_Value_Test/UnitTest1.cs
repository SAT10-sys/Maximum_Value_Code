using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maximum_Value_Code;

namespace Maximum_Value_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            int maximumInteger = maximumValue.GetMaximumInteger(11, 2, 8);
            Assert.AreEqual(11, maximumInteger);
        }
        [TestMethod]
        public void TestCase1_2()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            int maximumInteger = maximumValue.GetMaximumInteger(30, 46, 18);
            Assert.AreEqual(46, maximumInteger);
        }
        [TestMethod]
        public void TestCase1_3()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            int maximumInteger = maximumValue.GetMaximumInteger(1, 4, 8);
            Assert.AreEqual(8, maximumInteger);
        }
    }
}
