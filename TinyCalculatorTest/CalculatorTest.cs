using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyCalculator;

namespace TinyCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }
    }
}
