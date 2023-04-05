using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class FloodFill
    {
        public int[][] FloodFills(int[][] image, int sr, int sc, int newColor)
        {
            var queue = new Queue<(int, int)>();
            var numOfRows = image.Length;
            var numOfColumns = image[0].Length;
            var oldColor = image[sr][sc];
            if (oldColor == newColor)
            {
                return image;
            }

            queue.Enqueue((sr, sc));
            image[sr][sc] = newColor;
            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();

                // Left
                if (row - 1 >= 0 && image[row - 1][col] == oldColor)
                {
                    queue.Enqueue((row - 1, col));
                    image[row - 1][col] = newColor;
                }

                // Right
                if (row + 1 < numOfRows && image[row + 1][col] == oldColor)
                {
                    queue.Enqueue((row + 1, col));
                    image[row + 1][col] = newColor;
                }

                // Top
                if (col - 1 >= 0 && image[row][col - 1] == oldColor)
                {
                    queue.Enqueue((row, col - 1));
                    image[row][col - 1] = newColor;
                }

                // Bottom
                if (col + 1 < numOfColumns && image[row][col + 1] == oldColor)
                {
                    queue.Enqueue((row, col + 1));
                    image[row][col + 1] = newColor;
                }
            }

            return image;
        }
    }
}