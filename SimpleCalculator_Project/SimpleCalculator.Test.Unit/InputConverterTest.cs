using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            //setting up data for unit tests
            //processing the data through the method that is to be tested
            //comparing the result gotten from processing against original assumption.
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumber(inputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "%";
            double convertedNumber = _inputConverter.ConvertInputToNumber(inputNumber);
        }
    }
}
