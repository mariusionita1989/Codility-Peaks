using Codility_Peaks;

namespace Codility_PeaksTests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_Solution_ExampleInput_Returns3()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test_Solution_NoPeaks_Returns0()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Solution_SingleElementArray_Returns0()
        {
            // Arrange
            int[] A = new int[] { 1 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Solution_LowerBoundaryInput_Returns1()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 1 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_Solution_UpperBoundaryInput_Returns0()
        {
            // Arrange
            int N = Solution.RANGE_HIGHEST_VALUE;
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = 1;
            }
            Solution solution = new Solution();

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(0, result);
        }
    }
}