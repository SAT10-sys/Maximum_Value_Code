using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maximum_Value_Code;

namespace Maximum_Value_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase4_1()
        {
            int[] values = {1,23,11,45,12,7};
            Maximum_Value<int> maximumNumber = new Maximum_Value<int>(values);
            int max = maximumNumber.GetMaximumValue();
            Assert.AreEqual(45, max);
        }
        [TestMethod]
        public void TestCase4_2()
        {
            double[] values = { 0.98, 0.076, 0.23, 0.9912, 0.0346};
            Maximum_Value<double> maximumNumber = new Maximum_Value<double>(values);
            double max = maximumNumber.GetMaximumValue();
            Assert.AreEqual(0.9912, max);
        }
        [TestMethod]
        public void TestCase4_3()
        {
            string[] values = {"apple", "ball", "dog", "elephant","cat" };
            Maximum_Value<string> maximumNumber = new Maximum_Value<string>(values);
            string max = maximumNumber.GetMaximumValue();
            Assert.AreEqual("elephant", max);
        }
    }
}
