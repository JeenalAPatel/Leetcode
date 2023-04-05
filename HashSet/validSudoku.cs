using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class validSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var foundSet = new HashSet<(char Location, int Index, char Element)>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    var element = board[i][j];
                    if(element=='.')continue;
                    
                    var rowInfo = ('r', i, element);
                    var columnInfo = ('c', j, element);
                    var box = (i / 3) * 3 + (j / 3);
                    var boxInfo = ('b', box, element);
                    if (foundSet.Contains(rowInfo) || foundSet.Contains(columnInfo) ||
                        foundSet.Contains(boxInfo))
                    {
                        return false;
                    }

                    foundSet.Add(rowInfo);
                    foundSet.Add(columnInfo);
                    foundSet.Add(boxInfo);
                }
            }

            return true;
        }
    }
}