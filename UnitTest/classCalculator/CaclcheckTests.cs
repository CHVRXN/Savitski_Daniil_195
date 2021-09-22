using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
     [TestClass()]
    public class CalculatorCheckerTests
    {
        [TestMethod()]
        public void ValidateCalculatorTest_plus_ReturnTrue()
        {
            double n1 = 1;
            double n2 = 9;
            string op = "+";
            double result = 10;
            double actual = CalculatorChecker.ValidateCalculator(n1, n2, op);
            Assert.AreEqual(result, actual);

        }


        [TestMethod]
        public void ValidateCalculatorTest_Minus_ReturnTrue()
        {
            double n1 = 30;
            double n2 = 5;
            string op = "-";
            double result = 25;
            double actual = CalculatorChecker.ValidateCalculator(n1, n2, op);
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void ValidateCalculatorTest_multiply_ReturnTrue()
        {
            double n1 = 7;
            double n2 = 3;
            string op = "*";
            double result = 21;

            double actual = CalculatorChecker.ValidateCalculator(n1, n2, op);
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void ValidateCalculatorTest_divide_ReturnTrue()
        {
            double n1 = 12;
            double n2 = 2;
            string op = "/";
            double result = 6;

            double actual = CalculatorChecker.ValidateCalculator(n1, n2, op);
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Вы не можете делить на ноль ")]
        public void ValidateCalculatorTest_divide_ReturnFalse()
        {
            double n1 = 1;
            double n2 = 0;


            string op = "/";
            double actual = CalculatorChecker.ValidateCalculator(n1, n2, op);

        }




    }
}