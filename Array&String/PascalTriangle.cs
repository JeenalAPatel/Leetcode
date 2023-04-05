using System.Collections.Generic;

namespace LeetCodeArray
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            if (numRows == 0)
            {
                return result;
            }

            result.Add(new List<int>() {1});

            for (int row = 1; row < numRows; row++)
            {
                var rowList = new List<int>() {1};

                for (int j = 0; j < row - 1; j++)
                {
                    var prevRow = result[row - 1];
                    var newNumber = prevRow[j] + prevRow[j + 1];
                    rowList.Add(newNumber);
                }
                
                rowList.Add(1);
                result.Add(rowList);
            }
            
            return result;
        }
    }
}