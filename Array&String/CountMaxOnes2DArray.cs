namespace LeetCodeArray
{
    public class CountMaxOnes2DArray
    {
        public int maxOnes(int[][] nums)
        {
            var noOfRows = nums.Length;
            var noOfCols = nums[0].Length;

            var max = 0;
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = max; j < noOfCols; j++)
                {
                    var element = nums[i][j];
                    if (element != 1)
                    {
                        break;
                    }

                    max += 1;
                }
               
            }
            return max;
        }
    }
}