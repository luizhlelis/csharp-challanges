using Xunit;
using SourceCode;

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
    }
}
