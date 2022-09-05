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

        //Задание 16.2.4 (Проверка корректности вычислений)
        [Test]
        public void Subtract_MustReturnCorrectValue()
        {
            var calculation = new Calculation();

            Assert.That(0 == calculation.Subtraction(1, 1));
        }

        //Задание 16.2.5 (Проверка корректности вычислений)
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculation calculation = new();

            Assert.That(5 == calculation.Division(25, 5));
        }

        //Задание 16.2.6 (Проверка типа исключения)
        [Test]
        public void Division_MustThrowException()
        {
            var calculation = new Calculation();

            Assert.Throws<DivideByZeroException>(() => calculation.Division(5, 0));

            //try
            //{
            //    calculation.Division(10, 0);
            //}
            //catch (Exception e)
            //{
            //    Assert.IsTrue(e is DivideByZeroException);
            //}
        }

        //Пример тестирования сложения
        [Test]
        public void Add_AlwaysReturnsExpectedValue()
        {
            var calculation = new Calculation();

            Assert.That(calculation.Add(200, 10), Is.EqualTo(210));
        }
    }
}
