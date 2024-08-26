using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAnagrams;

namespace MyAnagrams.tests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_WithValidInput_ShouldReverseWords()
        {
            // Arrange
            string input = "abcd efgh";
            string expected = "dcba hgfe";

            // Act
            string? result = Anagram.Reverse(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WithNullInput_ShouldReturnNull()
        {
            // Arrange
            string? input = null;

            // Act
            string? result = Anagram.Reverse(input);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ReverseWord_WithNonAlphabeticCharacters_ShouldReverseWordKeepingNonAlphabeticCharacters()
        {
            // Arrange
            string word = "a1bcd efg!h";

            // Act
            string result = Anagram.ReverseWord(word);

            // Assert
            Assert.AreEqual("d1cba hgf!e", result);
        }
    }
}
