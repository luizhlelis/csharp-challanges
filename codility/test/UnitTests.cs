using Xunit;
using SourceCode;
using FluentAssertions;

namespace Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(32, 0)]
        [InlineData(15, 0)]
        public void ShouldReturnBigestBinaryGap(int number, int expectedResponse)
        {
            var response = new BinaryGap().Solution(number);
            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 5, new int[] { 4, 1, 2, 3 })]
        public void ShouldReturnCiclCyclicRotationArray(int[] A, int K, int[] expectedResponse)
        {
            var response = new CyclicRotation().Solution(A, K);

            response
                .Should()
                .BeEquivalentTo(expectedResponse);
        }

        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9 , 7 , 9 }, 7)]
        [InlineData(new int[] { 9, 3, 9, 3, 7, 7, 7 }, 7)]
        [InlineData(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 7)]
        [InlineData(new int[] { 7, 7, 1, 1, 1, 1, 1 }, 1)]
        public void OddOccurrencesInArrayTest(int[] A, int expectedResponse)
        {
            var response = new OddOccurrencesInArray().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void FrogJmpTest(int X, int Y, int D, int expectedResponse)
        {
            var response = new FrogJmp().Solution(X, Y, D);

            Assert.Equal(expectedResponse, response);
        }
    }
}
