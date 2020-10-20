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
        [TestMethod]
        public void TestCase2_1()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            double maximumDouble = maximumValue.GetMaximumFloatingPointValue(12.35, 2.0, 4.67);
            Assert.AreEqual(12.35, maximumDouble);
        }
        [TestMethod]
        public void TestCase2_2()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            double maximumDouble = maximumValue.GetMaximumFloatingPointValue(12.35,22.0, 4.67);
            Assert.AreEqual(22.0, maximumDouble);
        }
        [TestMethod]
        public void TestCase2_3()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            double maximumDouble = maximumValue.GetMaximumFloatingPointValue(12.35, 2.0,44.67);
            Assert.AreEqual(44.67, maximumDouble);
        }
        [TestMethod]
        public void TestCase3_1()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            string maximumString = maximumValue.GetMaximumString("Peach", "Orange", "Apple");
            Assert.AreEqual("Peach", maximumString);
        }
        [TestMethod]
        public void TestCase3_2()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            string maximumString = maximumValue.GetMaximumString("Orange", "Peach", "Apple");
            Assert.AreEqual("Peach", maximumString);
        }
        [TestMethod]
        public void TestCase3_3()
        {
            Maximum_Value maximumValue = new Maximum_Value();
            string maximumString = maximumValue.GetMaximumString("Apple", "Orange", "Peach");
            Assert.AreEqual("Peach", maximumString);
        }
    }
}
