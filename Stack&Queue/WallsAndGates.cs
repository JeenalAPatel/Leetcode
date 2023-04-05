using System.Collections.Generic;
namespace LeetCode
{
    public class WallsAndGates
    {
        public static void WallsAndGate(int[][] rooms)
        {
            var numOfRows = rooms.Length;
            var numOfColumns = rooms[0].Length;
            var queue = new Queue<(int, int)>();
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    var element = rooms[i][j];
                    
                    if (element == 0)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }
            var INF = 2147483647;

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();
                var curVal = rooms[row][col];
                //left
                if (col - 1 >= 0 && rooms[row][col - 1] == INF)
                {
                    rooms[row][col - 1] = curVal + 1;
                    queue.Enqueue((row, col - 1));
                }

                //right
                if (col + 1 < numOfColumns && rooms[row][col + 1] == INF)
                {
                    rooms[row][col + 1] = curVal + 1;
                    queue.Enqueue((row, col + 1));
                }

                //top
                if (row - 1 >= 0 && rooms[row - 1][col] == INF)
                {
                    rooms[row - 1][col] = curVal + 1;
                    queue.Enqueue((row - 1, col));
                }

                //bottom
                if (row + 1 < numOfRows && rooms[row + 1][col] == INF)
                {
                    rooms[row + 1][col] = curVal + 1;
                    queue.Enqueue((row + 1, col));
                }
            }
        }
    }
}