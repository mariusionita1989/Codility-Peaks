# Codility-Peaks
A non-empty array A consisting of N integers is given.</br>
A peak is an array element which is larger than its neighbors.</br>
More precisely, it is an index P such that 0 < P < N − 1,  A[P − 1] < A[P] and A[P] > A[P + 1].

For example, the following array A:</br>
A[0]  = 1</br>
A[1]  = 2</br>
A[2]  = 3</br>
A[3]  = 4</br>
A[4]  = 3</br>
A[5]  = 4</br>
A[6]  = 1</br>
A[7]  = 2</br>
A[8]  = 3</br>
A[9]  = 4</br>
A[10] = 6</br>
A[11] = 2</br>
has exactly three peaks: 3, 5, 10.

We want to divide this array into blocks containing the same number of elements.</br> 
More precisely, we want to choose a number K that will yield the following blocks:</br>
A[0], A[1], ..., A[K − 1],</br>
A[K], A[K + 1], ..., A[2K − 1],</br>
...</br>
A[N − K], A[N − K + 1], ..., A[N − 1].</br>
What's more, every block should contain at least one peak.</br>
Notice that extreme elements of the blocks (for example A[K − 1] or A[K]) can also be peaks,</br>
but only if they have both neighbors (including one in an adjacent blocks).</br>
The goal is to find the maximum number of blocks into which the array A can be divided.

Array A can be divided into blocks as follows:</br>
one block (1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2). This block contains three peaks.</br>
two blocks (1, 2, 3, 4, 3, 4) and (1, 2, 3, 4, 6, 2). Every block has a peak.</br>
three blocks (1, 2, 3, 4), (3, 4, 1, 2), (3, 4, 6, 2). Every block has a peak.</br> 
Notice in particular that the first block (1, 2, 3, 4) has a peak at A[3], because A[2] < A[3] > A[4],</br> 
even though A[4] is in the adjacent block.</br>
However, array A cannot be divided into four blocks, (1, 2, 3), (4, 3, 4), (1, 2, 3) and (4, 6, 2),</br> 
because the (1, 2, 3) blocks do not contain a peak.</br> 
Notice in particular that the (4, 3, 4) block contains two peaks: A[3] and A[5].</br>
The maximum number of blocks that array A can be divided into is three.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N integers,</br> 
returns the maximum number of blocks into which A can be divided.</br>
If A cannot be divided into some number of blocks, the function should return 0.

For example, given:</br>
A[0]  = 1</br>
A[1]  = 2</br>
A[2]  = 3</br>
A[3]  = 4</br>
A[4]  = 3</br>
A[5]  = 4</br>
A[6]  = 1</br>
A[7]  = 2</br>
A[8]  = 3</br>
A[9]  = 4</br>
A[10] = 6</br>
A[11] = 2</br>
the function should return 3, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [0..1,000,000,000].
