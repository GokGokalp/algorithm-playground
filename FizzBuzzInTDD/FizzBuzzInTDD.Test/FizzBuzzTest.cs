using FizzBuzzInTDD;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsDivisableThree_WhenEnteredANumberThatDivisableByThree_ShouldReturnTrue()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 3;

            //Act
            bool result = fizzBuzzHelper.IsDivisableThree(number);

            //Assert
            Assert.True(result);
        }

        [Test]
        public void IsDivisableThree_WhenEnteredANumberThatNotDivisableByThree_ShouldReturnFalse()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 5;

            //Act
            bool result = fizzBuzzHelper.IsDivisableThree(number);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void IsDivisableFive_WhenEnteredANumberThatDivisableByFive_ShouldReturnTrue()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 5;

            //Act
            bool result = fizzBuzzHelper.IsDivisableFive(number);

            //Assert
            Assert.True(result);
        }

        [Test]
        public void IsDivisableFive_WhenEnteredANotNumberThatDivisableByFive_ShouldReturnFalse()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 3;

            //Act
            bool result = fizzBuzzHelper.IsDivisableFive(number);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void GetFizzBuzzByNumber_WhenEnteredANumberThatDivisableByThree_ShouldReturnFizz()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 3;
            string expected = "Fizz";

            //Act
            string result = fizzBuzzHelper.GetFizzBuzzByNumber(number);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzzByNumber_WhenEnteredANumberThatDivisableByFive_ShouldReturnBuzz()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 5;
            string expected = "Buzz";

            //Act
            string result = fizzBuzzHelper.GetFizzBuzzByNumber(number);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzzByNumber_WhenEnteredANumberThatDivisableByThreeAndFive_ShouldReturnFizzBuzz()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 15;
            string expected = "FizzBuzz";

            //Act
            string result = fizzBuzzHelper.GetFizzBuzzByNumber(number);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzzByNumber_WhenEnteredANumberThatNotDivisableByThreeOrFive_ShouldReturnGivenNumber()
        {
            //Arrange
            FizzBuzzHelper fizzBuzzHelper = new FizzBuzzHelper();
            int number = 1;
            string expected = "1";

            //Act
            string result = fizzBuzzHelper.GetFizzBuzzByNumber(number);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}