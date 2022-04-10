using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Addition()
        {
            // Arrange
            double a = 24;
            double b = 12;
            double sum1 = a + b;

            double[] numbers = new double[] { 20, 4, 5, 1 };
            double sum2 = 30;

            // Act
            double addition1 = Calculator.Program.Addition(a, b);
            double addition2 = Calculator.Program.Addition(numbers);

            // Assert
            Assert.Equal(addition1, sum1);
            Assert.Equal(addition2, sum2);
        }

        [Fact]
        public void Subtraction()
        {
            // Arrange
            double a = 24;
            double b = 12;
            double difference1 = a - b;

            double[] numbers = new double[] { 20, 4, 5, 1 };
            double difference2 = 10;

            // Act
            double subtraction1 = Calculator.Program.Subtraction(a, b);
            double subtraction2 = Calculator.Program.Subtraction(numbers);

            // Assert
            Assert.Equal(subtraction1, difference1);
            Assert.Equal(subtraction2, difference2);
        }
    }
}
