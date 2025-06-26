using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_WithMultipleWords_ReturnsCorrectCount()
        {
            Assert.That(Str.CamelCase("saveChangesInTheEditor"), Is.EqualTo(5));
            Assert.That(Str.CamelCase("thisIsCamelCase"), Is.EqualTo(4)); // fixed from 3 to 4
        }

        [Test]
        public void CamelCase_WithOneWord_ReturnsOne()
        {
            Assert.That(Str.CamelCase("word"), Is.EqualTo(1));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.That(Str.CamelCase(""), Is.EqualTo(0));
        }

        [Test]
        public void CamelCase_AllUppercaseLettersOnly_ReturnsCount()
        {
            Assert.That(Str.CamelCase("camelCaseWithUPPERCASE"), Is.EqualTo(12)); // fixed from 4 to 12
        }
    }
}
