using NUnit.Framework;
using System.Runtime.InteropServices;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [Test] 
        public void GetOutput_InputIsOnlyDivisibleByThree_ReturnFizz() {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsOnlyDivisibleByFive_ReturnBuzz() {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleByThreeAndFive_ReturnFizzBuzz() {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleByThreeOrFive_ReturnTheSameNumberAsString() {
            var result = FizzBuzz.GetOutput(2);
            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
