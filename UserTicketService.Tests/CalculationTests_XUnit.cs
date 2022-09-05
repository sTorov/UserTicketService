using Xunit;

namespace UserTicketService.Tests
{
    public class CalculationTests_XUnit
    {
        [Fact]
        public void Multiplication_MustReturnNotNull()
        {
            Calculation calculation = new Calculation();

            Assert.Equal(8, calculation.Multiplication(4, 2));
        }

        //Задание 16.2.7 (Проверка корректности вычислений)
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculation = new Calculation();

            Assert.True(5 == calculation.Subtraction(10, 5));
        }

        //Задание 16.2.8 (Поверка корректности вычислений)
        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            var calculation = new Calculation();

            Assert.True(100 == calculation.Division(1000, 10));
        }

        //Задание 16.2.9 (Проверка исключения DivideByZeroException)
        [Fact]
        public void Division_MustThrowException()
        {
            var calculation = new Calculation();

            Assert.Throws<DivideByZeroException>(() => calculation.Division(17, 0));
        }
    }
}

