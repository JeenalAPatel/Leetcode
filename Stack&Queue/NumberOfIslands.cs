using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            var numOfIslands = 0;
            var numOfRows = grid.Length;
            var numOfColumns = grid[0].Length;
            var visitedIndexes = new HashSet<(int row, int col)>();
            var queue = new Queue<(int row, int col)>();
            for (var i = 0; i < numOfRows; i++)
            {
                for (var j = 0; j < numOfColumns; j++)
                {
                    var element = grid[i][j];

                    if (element != '1' || visitedIndexes.Contains((i, j))) continue;

                    numOfIslands += 1;

                    

                    queue.Enqueue((i, j));
                    visitedIndexes.Add((i, j));

                    while (queue.Count > 0)
                    {
                        var (row, col) = queue.Dequeue();

                        // Check left neighbor
                        if (col - 1 >= 0 && grid[row][col - 1] == '1' && !visitedIndexes.Contains((row, col - 1)))
                        {
                            queue.Enqueue((row, col - 1));
                            visitedIndexes.Add((row, col - 1));
                        }

                        // Check right neighbor
                        if (col + 1 < numOfColumns && grid[row][col + 1] == '1' &&
                            !visitedIndexes.Contains((row, col + 1)))
                        {
                            queue.Enqueue((row, col + 1));
                            visitedIndexes.Add((row, col + 1));
                        }

                        // Check top neighbor
                        if (row - 1 >= 0 && grid[row - 1][col] == '1' && !visitedIndexes.Contains((row - 1, col)))
                        {
                            queue.Enqueue((row - 1, col));
                            visitedIndexes.Add((row - 1, col));
                        }

                        // Check bottom neighbor
                        if (row + 1 < numOfRows && grid[row + 1][col] == '1' &&
                            !visitedIndexes.Contains((row + 1, col)))
                        {
                            queue.Enqueue((row + 1, col));
                            visitedIndexes.Add((row + 1, col));
                        }
                    }
                }
            }

            return numOfIslands;
        }
    }
}