using TestSamurai.Fundementals;

namespace TestSamurai.UnitTests.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private string _output;
        
        [SetUp]
        public void Setup()
        {
            _output = " ";
        }

        [Test]
        public void GetOutput_WhenInputIsDividible3_GettingFizz()
        {
            //Arrange
            //Act
            _output = FizzBuzz.GetOutput(3);
            //Assert
            Assert.That(_output, Is.EqualTo("Fizz"));
            Assert.That(_output, Is.Not.EqualTo("Buzz"));
        }


        [Test]
        public void GetOutput_WhenInputIsDividible5_GettingBuzz()
        {
            //Arrange
            //Act
            _output = FizzBuzz.GetOutput(5);
            //Assert
            Assert.That(_output, Is.EqualTo("Buzz"));
            Assert.That(_output, Is.Not.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDividible3and5_GettingFizzBuzz()
        {
            //Arrange
            //Act
            _output = FizzBuzz.GetOutput(15);
            //Assert
            Assert.That(_output, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsNotDividible3and5_GettingSameNumber()
        {
            //Arrange
            //Act
            _output = FizzBuzz.GetOutput(7);
            //Assert
            Assert.That(_output, Is.EqualTo("7"));
        }
    }
}