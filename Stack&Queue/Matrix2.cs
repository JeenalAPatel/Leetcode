using System.Collections.Generic;

namespace LeetCode
{
    public class Matrix2
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            var queue = new Queue<(int,int)>();
            var noOfRows = matrix.Length;
            var noOfCols = matrix[0].Length;
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 0; j < noOfCols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        queue.Enqueue((i,j));
                    }
                    matrix[i][j] *= -1;
                }
            }

            while (queue.Count>0)
            {
                
                var (row, col) = queue.Dequeue();
                var depth = matrix[row][col];
                //left
                if (col - 1 >= 0 && matrix[row][col - 1] == -1)
                {
                    queue.Enqueue((row,col-1));
                    matrix[row][col - 1] = depth + 1;
                }
                //right
                if (col + 1 <noOfCols && matrix[row][col + 1] == -1)
                {
                    queue.Enqueue((row,col+1));
                    matrix[row][col + 1] = depth + 1;
                }
                //top
                if (row - 1 >= 0 && matrix[row-1][col] == -1)
                {
                    queue.Enqueue((row-1,col));
                    matrix[row-1][col] = depth + 1;
                }
                //bottom
                if (row + 1 <noOfRows && matrix[row+1][col] == -1)
                {
                    queue.Enqueue((row+1,col));
                    matrix[row+1][col] = depth + 1;
                }
            }

            

            return matrix;
        }
    }
}