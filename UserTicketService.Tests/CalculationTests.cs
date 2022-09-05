using NUnit.Framework;

namespace UserTicketService.Tests__NUnit_
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void Multiplication_MustReturnNotNull()
        {
            Calculation calculation = new Calculation();

            Assert.AreEqual(8, calculation.Multiplication(2, 4));
        }

        //Задание 16.2.4
        [Test]
        public void Subtract_MustReturnCorrectValue()
        {
            var calculation = new Calculation();

            Assert.That(0 == calculation.Subtraction(1, 1));
        }

        //Задание 16.2.5
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculation calculation = new();

            Assert.That(5 == calculation.Division(25, 5));
        }
    }
}
