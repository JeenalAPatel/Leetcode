namespace LeetCodeArray
{
    public class DiagonalTraverse2
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            var goingUp = true;
            var numOfRows = matrix.Length;
            if (numOfRows == 0)
            {
                return new int[0];
            }

            var numOfCols = matrix[0].Length;
            var i = 0;
            var j = 0;
            var output = new int[numOfRows * numOfCols];
            var counter = 0;

            while (counter < (numOfRows * numOfCols))
            {
                output[counter] = matrix[i][j];

                if (goingUp && (i == 0 || j == numOfCols - 1))
                {
                    goingUp = !goingUp;

                    if (j < numOfCols - 1)
                    {
                        j += 1;
                    }
                    else
                    {
                        i += 1;
                    }
                }
                else if (!goingUp && (j == 0 || i == numOfRows - 1))
                {
                    goingUp = !goingUp;

                    if (i < numOfRows - 1)
                    {
                        i += 1;
                    }
                    else
                    {
                        j += 1;
                    }
                }
                else if (goingUp)
                {
                    i -= 1;
                    j += 1;
                }
                else if (!goingUp)
                {
                    i += 1;
                    j -= 1;
                }

                counter += 1;
            }

            return output;
        }
    }
}