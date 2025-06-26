using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_ValidString_ReturnsCorrectIndex()
        {
            Assert.That(Str.UniqueChar("leetcode"), Is.EqualTo(0)); // 'l'
            Assert.That(Str.UniqueChar("loveleetcode"), Is.EqualTo(2)); // 'v'
        }

        [Test]
        public void UniqueChar_NoUniqueCharacter_ReturnsMinus1()
        {
            Assert.That(Str.UniqueChar("aabbcc"), Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_SingleCharacter_Returns0()
        {
            Assert.That(Str.UniqueChar("z"), Is.EqualTo(0));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinus1()
        {
            Assert.That(Str.UniqueChar(""), Is.EqualTo(-1));
        }
    }
}
