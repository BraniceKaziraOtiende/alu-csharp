using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void TestDivideNormalMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int[,] expected = { { 2, 4 }, { 6, 8 } };
            int[,]? result = Matrix.Divide(matrix, 2);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivideByZero()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int[,]? result = Matrix.Divide(matrix, 0);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void TestNullMatrix()
        {
            int[,]? result = Matrix.Divide(null, 2);

            Assert.That(result, Is.Null);
        }
    }
}
