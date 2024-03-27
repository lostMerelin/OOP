using OOP;
using Xunit;
namespace Test1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3, 1, 3, 1, 1)]
        public void plus(int a1, int a2, int b1, int b2, int t1, int t2)
        {
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            RationalNumber expect = new RationalNumber(t1, t2);

            // Act
            RationalNumber c = num1+ num2;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }
        [Theory]
        [InlineData(2, 3, 1, 3, 1, 3)]
        public void minus(int a1, int a2, int b1, int b2, int t1, int t2)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            RationalNumber expect = new RationalNumber(t1, t2);

            // Act
            RationalNumber c = num2 - num1;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }
        [Theory]
        [InlineData(2, 5, 3, 5, 6, 25)]
        public void ymnoj(int a1, int a2, int b1, int b2, int t1, int t2)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            RationalNumber expect = new RationalNumber(t1, t2);

            // Act
            RationalNumber c = num2 * num1;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }
        [Theory]
        [InlineData(2, 5, 3, 5, 2, 3)]
        public void razdelit(int a1, int a2, int b1, int b2, int t1, int t2)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            RationalNumber expect = new RationalNumber(t1, t2);

            // Act
            RationalNumber c = num1 / num2;

            // Assert
            Assert.Equal(expect.Numerator, c.Numerator);
            Assert.Equal(expect.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, -2, 5)]
        public void ynarminus(int a1, int a2, int b1, int b2, int t1, int t2)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber except = new RationalNumber(t1, t2);

            // Act
            RationalNumber c = -num1;

            // Assert
            Assert.Equal(except.Numerator, c.Numerator);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        public void ravno_ravno(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 == num2;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        public void ne_ravno(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 != num2;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        public void menishe(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 < num2;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        public void bolishe(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 > num2;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, true)]
        public void menishe_or_ravno(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 <= num2;

            // Assert
            Assert.Equal(expect, c);
        }

        [Theory]
        [InlineData(2, 5, 3, 5, false)]
        public void bolishe_or_ravno(int a1, int a2, int b1, int b2, bool t)
        {
            // Arrange
            RationalNumber num1 = new RationalNumber(a1, a2);
            RationalNumber num2 = new RationalNumber(b1, b2);
            bool expect = t;

            // Act
            bool c = num1 >= num2;

            // Assert
            Assert.Equal(expect, c);
        }
    }
}