using NUnit.Framework;
using System;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            NUnit.Framework.Assert.That(calculator.Additional(-100, 100) == 0);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            NUnit.Framework.Assert.That(calculator.Subtraction(100, 200) == -100);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            NUnit.Framework.Assert.That(calculatorTest.Miltiplication(3, 100) == 300);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            NUnit.Framework.Assert.That(calculator.Division(90, -2) == -45);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => calculator.Division(100, 0));
        }
    }
}