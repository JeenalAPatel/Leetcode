using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace LeetCodeArray
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
    
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var noOfRows = matrix.Length;
            var noOfCols = matrix[0].Length;
            var minRow = 0;
            var maxRow = noOfRows - 1;
            var minCol = 0;
            var maxCol = noOfCols - 1;
            
            var i = 0;
            var j = 0;
            var list = new List<int>();
            var direction = Direction.Right;
            
            while (list.Count < (noOfRows * noOfCols))
            {
                list.Add(matrix[i][j]);

                if (direction == Direction.Right)
                {
                    if (j < maxCol)
                    {
                        j += 1;    
                    }
                    else
                    {
                        direction = Direction.Down;
                        i += 1;
                        minRow += 1;
                    }
                }
                else if (direction == Direction.Down)
                {
                    if (i < maxRow)
                    {
                        i += 1;    
                    }
                    else
                    {
                        direction = Direction.Left;
                        j -= 1;
                        maxCol -= 1;
                    }
                    
                }
                else if (direction == Direction.Left)
                {
                    if (j > minCol)
                    {
                        j -= 1;
                    }
                    else
                    {
                        direction = Direction.Up;
                        i -= 1;
                        maxRow -= 1;
                    }
                }
                else if (direction == Direction.Up)
                {
                    if (i > minRow)
                    {
                        i -= 1;
                    }
                    else
                    {
                        direction = Direction.Right;
                        j += 1;
                        minCol += 1;
                    }
                }
            }

            return list;
        }
    }
}