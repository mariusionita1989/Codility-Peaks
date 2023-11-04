using System.Runtime.CompilerServices;

namespace Codility_Peaks
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int[] peaks = new int[N]; // Array to store peak positions
                int peakCount = 0;
                // Find peaks in the array and store their positions
                for (int i = 1; i < N - 1; i++)
                {
                    if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    {
                        peaks[peakCount] = i;
                        peakCount++;
                    }
                }

                if (peakCount == 0)
                    return 0; // No peaks, so no blocks can be formed
                
                // Try to divide the array into blocks of different sizes
                for (int blockSize = 1; blockSize <= N; blockSize++)
                {
                    if (N % blockSize == 0)
                    {
                        int blockCount = N / blockSize;
                        int currentBlock = 0;
                        bool isPossible = true;
                        // Check if each block contains at least one peak
                        for (int i = 0; i < peakCount; i++)
                        {
                            if (peaks[i] / blockSize > currentBlock)
                            {
                                isPossible = false;
                                break;
                            }
                            if (peaks[i] / blockSize == currentBlock)
                                currentBlock++;
                        }

                        if (isPossible && currentBlock == blockCount)
                            return blockCount;
                    }
                }

                return 0; // Unable to form blocks with peaks
            }

            return -1;
        }
    }
}
