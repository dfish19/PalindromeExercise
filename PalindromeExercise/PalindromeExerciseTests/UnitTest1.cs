using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bob", true)]
        [InlineData("hannah", true)]
        [InlineData("madam", true)]
        [InlineData("Donte", false)]
        public void Test1(string word, bool expected)
        {
            var create = new WordSmith();
            var actual = create.IsAPalindrome(word);
            Assert.Equal(expected,actual);
        }
    }
}
