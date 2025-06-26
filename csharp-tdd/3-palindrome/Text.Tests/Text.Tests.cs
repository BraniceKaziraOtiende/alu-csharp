using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void Palindrome_SimpleWords_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("Racecar"), Is.True);
            Assert.That(Str.IsPalindrome("level"), Is.True);
        }

        [Test]
        public void Palindrome_WithPunctuationAndSpaces_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome("A man, a plan, a canal: Panama."), Is.True);
        }

        [Test]
        public void Palindrome_EmptyString_ReturnsTrue()
        {
            Assert.That(Str.IsPalindrome(""), Is.True);
        }

        [Test]
        public void NotPalindrome_ReturnsFalse()
        {
            Assert.That(Str.IsPalindrome("Hello"), Is.False);
            Assert.That(Str.IsPalindrome("ChatGPT is cool!"), Is.False);
        }

        [Test]
        public void NullInput_ReturnsFalse()
        {
            Assert.That(Str.IsPalindrome(null), Is.False);
        }
    }
}
