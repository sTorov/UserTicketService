using Xunit;

namespace Tasks.Tests
{

    /*
     * Программист начал разрабатывать приложение Calculator при помощи подхода TDD. Он написал первые тесты для будущего класса
     * Реализуйте код класса Calculator, который успешно пройдет данные тесты.
     */

    public class Task16_4_3_Tests_XUnit //CalculatorTests
    {
        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}
