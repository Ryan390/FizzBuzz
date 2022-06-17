using FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        private Generator _generator;

        [SetUp]
        public void SetUp()
        {
            _generator = new Generator();
        }
        
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        public void NonDivisibleInput_Returns_Input(int input, string expectedResult)
        {
           var actualResult =  _generator.GenerateFizzBuzzFor(input);
           
           Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void DivisibleByThree_Returns_Fizz(int input)
        {
            var actualResult =  _generator.GenerateFizzBuzzFor(input);
           
            Assert.That(actualResult, Is.EqualTo("Fizz"));
        }
        
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void DivisibleByFive_Returns_Buzz(int input)
        {
            var actualResult =  _generator.GenerateFizzBuzzFor(input);
           
            Assert.That(actualResult, Is.EqualTo("Buzz"));
        }
        
        [TestCase(15)]
        [TestCase(30)]
        public void DivisibleByThreeAndFive_Returns_FizzBuzz(int input)
        {
            var actualResult =  _generator.GenerateFizzBuzzFor(input);
           
            Assert.That(actualResult, Is.EqualTo("FizzBuzz"));
        }
    }
}