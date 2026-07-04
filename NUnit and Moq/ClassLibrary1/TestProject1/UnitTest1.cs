using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }

        // ✅ Single test
        [Test]
        public void Add_SingleTest()
        {
            Assert.That(calc.Add(2, 3), Is.EqualTo(5));
        }

        // ✅ Parameterised tests (IMPORTANT FOR MARKS)
        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void Add_MultipleCases(int a, int b, int expected)
        {
            Assert.That(calc.Add(a, b), Is.EqualTo(expected));
        }

        // ❌ Example of Ignore attribute
        [Test]
        [Ignore("Demonstration of Ignore attribute")]
        public void Ignored_Test()
        {
            Assert.That(calc.Add(100, 100), Is.EqualTo(200));
        }
    }
}