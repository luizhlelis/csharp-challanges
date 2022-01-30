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

        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        [InlineData(new int[] { 5, 4, 1, 2 }, 3)]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 2 }, 1)]
        [InlineData(new int[] { 1 }, 2)]
        [InlineData(new int[] { 1, 3 }, 2)]
        [InlineData(new int[] { 4, 3, 1, 2 }, 5)]
        [InlineData(new int[] { 4, 3, 5, 2 }, 1)]
        public void PermMissingElemTest(int[] A, int expectedResponse)
        {
            var response = new PermMissingElem().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Fact]
        public void ShouldReturn10PermMissingElemTest()
        {
            int[] A = new int[100000];

            A[0] = 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (i == 9)
                {
                    A[i] = A[i - 1] + 2;
                    continue;
                }
                A[i] = A[i-1] + 1;
            }

            var response = new PermMissingElem().Solution(A);

            Assert.Equal(10, response);
        }

        [Theory]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [InlineData(1, new int[] { 1 }, 0)]
        [InlineData(5, new int[] { 1 }, -1)]
        public void FrogRiverOneTest(int X, int[] A, int expectedResponse)
        {
            var response = new FrogRiverOne().Solution(X, A);

            Assert.Equal(expectedResponse, response);
        }

        [Fact]
        public void ShouldReturn99999FrogRiverOneTest()
        {
            int[] A = new int[100000];

            for (int i = 0; i < A.Length; i++)
                A[i] = i + 1;

            var response = new FrogRiverOne().Solution(100000, A);

            Assert.Equal(99999, response);
        }


        [Fact]
        public void ShouldReturn9FrogRiverOneTest()
        {
            int[] A = new int[100000];

            for (int i = 0; i < A.Length; i++)
                A[i] = i + 1;

            var response = new FrogRiverOne().Solution(10, A);

            Assert.Equal(9, response);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 1, 1 }, 5)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 0, 0 }, 0)]
        public void PassingCarsTest(int[] A, int expectedResponse)
        {
            var response = new PassingCars().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Fact]
        public void ShouldReturnMinusOnePassingCars()
        {
            int[] A = new int[100000];

            for (int i = 0; i < A.Length; i++)
            {
                if (i < 50000)
                    A[i] = 0;
                else
                    A[i] = 1;
            }

            var response = new PassingCars().Solution(A);

            Assert.Equal(-1, response);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        //[InlineData(new int[] { 1, 1 }, 1)]
        public void NumberOfDiscIntersectionsTest(int[] A, int expectedResponse)
        {
            var response = new NumberOfDiscIntersections().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1}, 3)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        public void DistinctTest(int[] A, int expectedResponse)
        {
            var response = new Distinct().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { 10, 50, 5, 1 }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { }, 0)]
        public void TriangleTest(int[] A, int expectedResponse)
        {
            var response = new Triangle().Solution(A);

            Assert.Equal(expectedResponse, response);
        }

        [Theory]
        [InlineData("{[()()]}", 1)]
        [InlineData("([)()]", 0)]
        [InlineData("}()[]", 0)]
        [InlineData("{{[[]]}}", 1)]
        [InlineData("([(())])", 0)]
        [InlineData("(dsadasd)", 1)]
        [InlineData("(", 0)]
        [InlineData("", 1)]
        public void BracketsTest(string S, int expectedResponse)
        {
            var response = new Brackets().Solution(S);

            Assert.Equal(expectedResponse, response);
        }
    }
}
