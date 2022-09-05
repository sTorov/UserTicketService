using Xunit;

namespace UserTicketService.Tests__XUnit_
{
    public class CalculationTests
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
    }
}
