using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new SimpleCalculator.CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            //setting up data for unit tests
            //processing the data through the method that is to be tested
            //comparing the result gotten from processing against original assumption.

            int number1 = 1;
            int number2 = 2;

            double result = _calculatorEngine.Calculate("add", number1, number2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            //setting up data for unit tests
            //processing the data through the method that is to be tested
            //comparing the result gotten from processing against original assumption.

            int number1 = 1;
            int number2 = 2;

            double result = _calculatorEngine.Calculate("+", number1, number2);

            Assert.AreEqual(3, result);
        }
    }
}
