using NUnit.Framework;
using MyMath; // ✅ This ensures you can access the Operations class
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_WithPositiveNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { 1, 3, 5, 7, 2 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Max_WithNegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -10, -2, -5, -1 };
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Max_WithNullList_ReturnsZero()
        {
            List<int>? nums = null;
            int result = Operations.Max(nums);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
