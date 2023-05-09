using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrage
            Calculator calc = new();
            //Act
            int result = calc.AddNumbers(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }



        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Arrage
            Calculator ask = new();
            //Act
            bool isOdd = ask.IsOddNumber(2);
            //Assert
            Assert.That(isOdd, Is.EqualTo(false));
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            //Arrage
            Calculator ask = new();
            //Act
            bool isOdd = ask.IsOddNumber(a);
            //Assert
            Assert.That(isOdd, Is.EqualTo(true));
        }



        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOddNumber(a);
        }


        [Test]
        [TestCase(5.4, 10.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrage
            Calculator calc = new();
            //Act
            double result = calc.AddNumbers(a, b);
            //Assert
            Assert.AreEqual(15.9, result, 1);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            //act
            List<int> result = calc.GetOddRange(5, 10);

            //Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }
    }
}
