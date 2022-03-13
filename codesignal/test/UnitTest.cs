using System;
using Xunit;
using SourceCode;

namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aabaa", true)]
        [InlineData("abac", false)]
        [InlineData("a", true)]
        public void PalindromeTest(string inputString, bool expectedResponse)
        {
            var response = new Palindrome().Solution(inputString);

            Assert.Equal(expectedResponse, response);
        }
    }
}
