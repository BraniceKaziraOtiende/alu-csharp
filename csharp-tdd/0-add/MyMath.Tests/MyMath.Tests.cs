using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            int result = Operations.Add(3, 5);
            Assert.That(result, Is.EqualTo(8));
        }
    }
}
