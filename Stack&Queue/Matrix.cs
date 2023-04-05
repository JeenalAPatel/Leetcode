using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Matrix
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            var queue = new Queue<(int, int, int)>();
            var numOfRows = matrix.Length;
            var numOfColumns = matrix[0].Length;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        queue.Enqueue((i, j, 0));
                    }

                    matrix[i][j] += -1;
                }
            }

            var depthQueue = new Queue<(int,int,int)>(queue);

            while (depthQueue.Count > 0)
            {
                var (row, col, depth) = depthQueue.Dequeue();

                if (row - 1 >= 0 && matrix[row - 1][col] == 0)
                {
                    matrix[row-1][col] = depth + 1;
                    depthQueue.Enqueue((row - 1, col, depth + 1));
                }

                if (row + 1 < numOfRows && matrix[row + 1][col] == 0)
                {
                    depthQueue.Enqueue((row + 1, col, depth + 1));
                    matrix[row+1][col] = depth + 1;
                }
                
                if (col - 1 >= 0 && matrix[row][col - 1] == 0)
                {
                    depthQueue.Enqueue((row, col - 1, depth + 1));
                    matrix[row][col-1] = depth + 1;
                }
                
                if (col + 1 < numOfColumns && matrix[row][col + 1] == 0)
                {
                    depthQueue.Enqueue((row, col + 1, depth + 1));
                    matrix[row][col+1] = depth + 1;
                }
            }

            while (queue.Count > 0)
            {
                var (row, col, depth) = queue.Dequeue();
                matrix[row][col] = 0;
            }

            return matrix;
        }
    }
}