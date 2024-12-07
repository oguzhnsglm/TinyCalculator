using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyCalculator;

namespace TinyCalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            Calculator calc = new Calculator();
            try
            {
                int result = calc.Calculate("abcd");
                Assert.Fail(); // Hatalý giriþte bu noktaya ulaþýlmamalý
            }
            catch (InvalidOperationException)
            {
                // Beklenen bir istisna, test baþarýlý
            }
        }

        [TestMethod]
        public void OnePlusOne()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("1+1");
            Assert.AreEqual(2, result); // 1+1 = 2 olmalý
        }
        void DoSumTest(string input, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoPlusTwo()
        {
            DoSumTest("2+2", 4);
        }

        [TestMethod]
        public void TwoMinusOne()
        {
            DoSumTest("2-1", 1);
        }

        [TestMethod]
        public void FiveMinusTwo()
        {
            DoSumTest("5-2", 3);
        }

        [TestMethod]
        public void FiveTimesTwo()
        {
            DoSumTest("5*2", 10);
        }

        [TestMethod]
        public void EightDividedByTwo()
        {
            DoSumTest("8/2", 4);
        }

        [TestMethod]
        public void EightDividedByFour()
        {
            DoSumTest("8/4", 2);
        }


    }
}