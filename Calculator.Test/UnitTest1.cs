using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionTest()
        {
            // Arrange
            double a = 24;
            double b = 12;
            double sum = a + b;

            // Act
            double addition = Calculator.Program.Addition(a, b);

            // Assert
            Assert.Equal(addition, sum);
        }

        [Fact]
        public void AdditionArrayTest()
        {
            // Arrange
            double[] numbers = new double[] { 20, 4, 5, 1 };
            double sum = 30;

            // Act
            double addition = Calculator.Program.Addition(numbers);

            // Assert
            Assert.Equal(addition, sum);
        }

        [Fact]
        public void SubtractionTest()
        {
            // Arrange
            double a = 24;
            double b = 12;
            double difference = a - b;

            // Act
            double subtraction = Calculator.Program.Subtraction(a, b);

            // Assert
            Assert.Equal(subtraction, difference);
        }

        [Fact]
        public void SubtractionArrayTest()
        {
            // Arrange
            double[] numbers = new double[] { 20, 4, 5, 1 };
            double difference = 10;

            // Act
            double subtraction = Calculator.Program.Subtraction(numbers);

            // Assert

            Assert.Equal(subtraction, difference);
        }

        [Fact]
        public void MultiplicationTest()
        {
            // Arrange
            double a = 3;
            double b = 15;
            double product = a * b;

            // Act
            double multiplication = Calculator.Program.Multiplication(a, b);

            // Assert
            Assert.Equal(multiplication, product);
        }

        [Fact]
        public void DivisionTest()
        {
            // Arrange
            double a = 15;
            double b = 3;
            double quotient = a / b;

            // Act
            double division = Calculator.Program.Division(a, b);

            // Assert
            Assert.Equal(division, quotient);
        }

        [Fact]
        public void DivisionZeroTest()
        {
            // Arrange
            double a = 15;
            double b = 0;
            double c = -15;
            double quotient1 = double.PositiveInfinity;
            double quotient2 = double.NegativeInfinity;

            int d = 10;
            int e = 0;
            double quotient3 = double.NaN;

            // Act
            double division1 = Calculator.Program.Division(a, b);
            double division2 = Calculator.Program.Division(c, b);

            double division3 = Calculator.Program.Division(d, e);

            // Assert
            Assert.Equal(division1, quotient1);
            Assert.Equal(division2, quotient2);

            Assert.Equal(division3, quotient3);
        }
    }
}
