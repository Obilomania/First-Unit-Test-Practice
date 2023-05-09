using NUnit.Framework;
using NUnit.Framework.Internal;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class GradingNUnitTests
    {
        private GradingCalculator grading;
        [SetUp]
        public void SetUp()
        {
            grading = new GradingCalculator();
        }

        [Test]
        public void GradingCalc_InputScore95Attendance90_GetAGrade()
        {
            grading.Score = 95;
            grading.AttendancePercentage = 90;
            string result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("A"));
        }

        [Test]
        public void GradingCalc_InputScore85Attendance90_GetBGrade()
        {
            grading.Score = 85;
            grading.AttendancePercentage = 90;
            string result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("B"));
        }

        [Test]
        public void GradingCalc_InputScore65Attendance90_GetCGrade()
        {
            grading.Score = 65;
            grading.AttendancePercentage = 90;
            string result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void GradingCalc_InputScore95Attendance65_GetBGrade()
        {
            grading.Score = 95;
            grading.AttendancePercentage = 65;
            string result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("B"));
        }


        [Test]
        [TestCase(95, 55)]
        [TestCase(65, 55)]
        [TestCase(50, 90)]
        public void GradingCalc_FailureScenerios_GetFGrade(int score, int attendance)
        {
            grading.Score = score;
            grading.AttendancePercentage = attendance;
            string result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("F"));
        }

        [Test]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string GradingCalc_AlllGradeLoficalScenerios_GradeOutPut(int score, int attendance)
        {
            grading.Score = score;
            grading.AttendancePercentage = attendance;
            return grading.GetGrade();
        }
    }
}
