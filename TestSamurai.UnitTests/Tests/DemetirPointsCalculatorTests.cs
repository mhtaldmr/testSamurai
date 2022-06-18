using NUnit.Framework;
using TestSamurai.Fundementals;

namespace TestSamurai.UnitTests.Tests
{
    [TestFixture]
    public class DemetirPointsCalculatorTests
    {
        private DemeritPointsCalculator _points;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _points = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_GivingSpeedOutofRange_ThrowsAnException(int input)
        {
            //Act
            //Assert
            Assert.That(()=> _points.CalculateDemeritPoints(input), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_SpeedIsInRange_ReturnsDemetirPoints(int input, int expectedResult)
        {
            //Act
            var result = _points.CalculateDemeritPoints(input);
            //Assert
            Assert.That(() => result, Is.EqualTo(expectedResult));
        }
    }
}
