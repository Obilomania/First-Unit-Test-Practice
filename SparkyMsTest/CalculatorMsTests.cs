﻿using Sparky;

namespace SparkyMsTest
{
    [TestClass]
    public class CalculatorMsTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrage
            Calculator calc = new();
            //Act
            int result = calc.AddNumbers(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }
    }
}
