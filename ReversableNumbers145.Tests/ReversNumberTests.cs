using FluentAssertions;
using NUnit.Framework;
using ReversableNumber145;

namespace ReversableNumbers145.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(321, ExpectedResult = 123)]
        [TestCase(678, ExpectedResult = 876)]
        [TestCase(98765, ExpectedResult = 56789)]
        [TestCase(12, ExpectedResult = 21)]
        public int GivenANumber_ReturnTheReverseOrderOfThatNumber(int number) => ReverseNumbers.FlipNumber(number);


        [TestCase(45, ExpectedResult = 45 + 54)]
        [TestCase(121, ExpectedResult = 121 + 121)]
        [TestCase(395, ExpectedResult = 395 + 593)]
        [TestCase(79, ExpectedResult = 79 + 97)]
        public int GivenNumberAndFlippedNumber_ReturnItsSum(int number) => ReverseNumbers.AddNumberWithFlip(number);
        

        [TestCase(99, ExpectedResult = true)]
        [TestCase(1313, ExpectedResult = true)]
        [TestCase(194, ExpectedResult = false)]
        public bool GivenAddedNumber_DeterminIfAllDigitsAreOdd(int number) => ReverseNumbers.AllDigitsAreOdd(number);        
    }
}