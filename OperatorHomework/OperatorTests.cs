using NUnit.Framework;

namespace OperatorHomework
{
    [TestFixture]
    public class OperatorsTests
    {
        const object __FILL_ME_IN__ = null;

        [Test]
        public void Plus_Operator_Adds_Integers()
        {
            int actual = 3 + 5;
            Assert.That(actual, Is.EqualTo(8));
        }

        [Test]
        public void Plus_Operator_Adds_Decimals()
        {
            decimal actual = 3.0M + 5.12M;
            Assert.That(actual, Is.EqualTo(8.12M));
        }

        [Test]
        public void Plus_Operator_Adds_Floats()
        {
            float actual = 3.14f + 0.12f;
            Assert.That(actual, Is.EqualTo(3.26f));
        }

        [Test]
        public void Minus_Operator_Subtracts()
        {
            double actual = 3.0 - 2.0;
            Assert.That(actual, Is.EqualTo(1.0));
        }

        [Test]
        public void Division_Operator_Divides()
        {
            // Notice that dividing two integers returns a double?
            // Why do you think it isn't an integer? 
            double actual = 9 / 3;
            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void Multiplication_Operator_Multiplies()
        {
            // Notice that multiplying two integers returns an int?
            // Why is that different from division?
            int actual = 9 * 3;
            Assert.That(actual, Is.EqualTo(27));
        }

        [Test]
        public void Logical_And_Operator_True_True()
        {
            var actual = true && true;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Logical_And_Operator_True_False()
        {
            var actual = true && false;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Logical_And_Operator_False_False()
        {
            var actual = false && false;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Logical_Or_Operator_True_True()
        {
            var actual = true || true;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Logical_Or_Operator_True_False()
        {
            var actual = true || false;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Logical_Or_Operator_False_False()
        {
            var actual = false || false;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Modulus_Returns_The_Remainder_After_Dividing()
        {
            var actual = 9 % 3;
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Modulus_Returns_The_Remainder_After_Dividing_2()
        {
            var actual = 9 % 2;
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Double_Equals_Tests_For_Equality()
        {
            Assert.That(true == true, Is.EqualTo(true));
            Assert.That(true == false, Is.EqualTo(false));
            Assert.That(9 == 9, Is.EqualTo(true));
            Assert.That(3.0 == 3.0f, Is.EqualTo(true));
            Assert.That(3 == 3.0M, Is.EqualTo(true));
            Assert.That(3 == 3.0M, Is.EqualTo(true));
        }

        [Test]
        public void Not_Equals_Tests_For_Inequality()
        {
            Assert.That(true != true, Is.EqualTo(false));
            Assert.That(true != false, Is.EqualTo(true));
            Assert.That(9 != 9, Is.EqualTo(false));
            Assert.That(3.0 != 3.0f, Is.EqualTo(false));
            Assert.That(3 != 3.0M, Is.EqualTo(false));
            Assert.That(3 != 3.0M, Is.EqualTo(false));
        }

        [Test]
        public void Modulus_Can_Be_Used_To_Check_For_Even_Numbers()
        {
            var number = 9;
            var remainder = number % 2;
            var isEven = remainder == 0;
            Assert.That(isEven, Is.EqualTo(false));
        }

        [Test]
        public void Modulus_Can_Be_Used_To_Check_For_Odd_Numbers()
        {
            var number = 9;
            var remainder = number % 2;
            var isOdd = remainder == 1;
            Assert.That(isOdd, Is.EqualTo(true));
        }

        [Test]
        public void Increment_Operator_Adds_One()
        {
            var number = 41;
            number++;
            Assert.That(number, Is.EqualTo(42));
        }

        [Test]
        public void Decrement_Operator_Subtracts_One()
        {
            var number = 43;
            number--;
            Assert.That(number, Is.EqualTo(42));
        }

        [Test]
        public void Relational_Operators_Compare_Numbers()
        {
            Assert.That(3 > 9, Is.EqualTo(false));
            Assert.That(9 > 9, Is.EqualTo(false));
            Assert.That(9 >= 9, Is.EqualTo(true));
            Assert.That(3 < 9, Is.EqualTo(true));
            Assert.That(9 < 9, Is.EqualTo(false));
            Assert.That(9 <= 9, Is.EqualTo(true));
        }
    }
}


