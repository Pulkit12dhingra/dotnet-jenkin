using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace Calc_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Arithmatic_Calculations obj = new Arithmatic_Calculations();
            int sumValue= obj.Add(2, 3);
            Assert.AreEqual(5, sumValue);
        }

        [TestMethod]
        public void TestSub()
        {
            Arithmatic_Calculations obj = new Arithmatic_Calculations();
            int sumValue = obj.Substract(3, 2);
            Assert.AreEqual(1, sumValue);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Arithmatic_Calculations obj = new Arithmatic_Calculations();
            int sumValue = obj.Multiply(3, 2);
            Assert.AreEqual(6, sumValue);
        }

        [TestMethod]
        public void TestDivide()
        {
            Arithmatic_Calculations obj = new Arithmatic_Calculations();
            int sumValue = obj.Divide(4, 2);
            Assert.AreEqual(2, sumValue);
        }
    }
}
