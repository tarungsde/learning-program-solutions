using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [TearDown]
        public void Teardown()
        {
            _calc = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            var result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
