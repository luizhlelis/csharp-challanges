using System;
using Xunit;
using SourceCode;

namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2022, 21)]
        [InlineData(2000, 20)]
        public void CenturyTest(int year, int expectedResponse)
        {
            var response = new Century().Solution(year);

            Assert.Equal(expectedResponse, response);
        }

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
