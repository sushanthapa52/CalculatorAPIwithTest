using CalcLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class LogicTest
    {
            [TestMethod]
            public void Add_ShouldReturnCorrectResult()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(3, 4);

                // Assert
                Assert.AreEqual(7, result);
            }
            [TestMethod]
            public void Add_ShouldReturnCorrectResultForPositiveNumbers()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(3, 4);

                // Assert
                Assert.AreEqual(7, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForNegativeNumbers()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(-3, -4);

                // Assert
                Assert.AreEqual(-7, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForMixedNumbers()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(-3, 4);

                // Assert
                Assert.AreEqual(1, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForZero()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(0, 7);

                // Assert
                Assert.AreEqual(7, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForDecimalNumbers()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Add(3.5m, 2.5m);

                // Assert
                Assert.AreEqual(6, result);
            }

        // test for modulo
            [TestMethod]
            public void Modulo_ShouldReturnCorrectResult()
            {
                // Arrange
                CalculatorLogicService calculator = new CalculatorLogicService();

                // Act
                decimal result = calculator.Modulo(10, 3);

                // Assert
                Assert.AreEqual(1, result);
            }
        // test for subtraction logic
        [TestMethod]
        public void Subtract_ShouldReturnCorrectResultForPositiveNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Subtract(8, 3);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResultForNegativeNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Subtract(-3, -4);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResultForMixedNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Subtract(-3, 4);

            // Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResultForZero()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Subtract(7, 0);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResultForDecimalNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Subtract(5.5m, 2.5m);

            // Assert
            Assert.AreEqual(3, result);
        }
        //test for multiply
        [TestMethod]
        public void Multiply_ShouldReturnCorrectResultForPositiveNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Multiply(3, 4);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResultForNegativeNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Multiply(-3, -4);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResultForMixedNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Multiply(-3, 4);

            // Assert
            Assert.AreEqual(-12, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnZeroForMultiplyingByZero()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Multiply(7, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResultForDecimalNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Multiply(2.5m, 2);

            // Assert
            Assert.AreEqual(5, result);
        }
        // test for division
        [TestMethod]
        public void Divide_ShouldReturnCorrectResultForPositiveNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Divide(8, 2);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectResultForNegativeNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Divide(-12, -4);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectResultForMixedNumbers()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act
            decimal result = calculator.Divide(-15, 3);

            // Assert
            Assert.AreEqual(-5, result);
        }
        [TestMethod]
        public void Divide_ShouldThrowExceptionForDivideByZero()
        {
            // Arrange
            CalculatorLogicService calculator = new CalculatorLogicService();

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(7, 0));
        }

    }
}
