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

        [Theory]
        [InlineData(new int[] {3, 6, -2, -5, 7, 3}, 21)]
        [InlineData(new int[] { 3, 3 }, 9)]
        [InlineData(new int[] { -1000, +1000 }, -1000000)]
        public void AdjancentElementsProductTest(int[] input, int expectedResponse)
        {
            var response = new AdjancentElementsProduct().Solution(input);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 5)]
        [InlineData(3, 13)]
        [InlineData(4, 25)]
        public void ShapeAreaTest(int n, int expectedResponse)
        {
            var response = new ShapeArea().Solution(n);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(new int[] { 6, 2, 3, 8 }, 3)]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 10 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }, 1)]
        public void MakeArrayConsecutiveTest(int[] input, int expectedResponse)
        {
            var response = new MakeArrayConsecutive().Solution(input);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 2, 1 }, false)]
        [InlineData(new int[] { 1, 3, 2}, true)]
        [InlineData(new int[] { 1, 2, 1, 2 }, false)]
        [InlineData(new int[] { 1, 1, 1, 2, 3 }, false)]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 4 }, false)]
        [InlineData(new int[] { 1, 4, 10, 4, 2 }, false)]
        [InlineData(new int[] { 10, 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { 0, -2, 5, 6 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 3, 6 }, true)]
        [InlineData(new int[] { 3, 5, 67, 98, 3 }, true)]
        public void AlmostIncreasingSequenceTest(int[] input, bool expectedResponse)
        {
            var response = new AlmostIncreasingSequence().Solution(input);

            Assert.Equal(expectedResponse, response);
        }
    }
}
