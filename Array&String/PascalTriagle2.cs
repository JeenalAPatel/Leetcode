using System.Collections.Generic;

namespace LeetCodeArray
{
    public class PascalTriagle2
    {
        public  List<int>GetRow(int rowIndex)
        {
            var list = new List<IList<int>>();
            var listInd = new List<int>();
            listInd.Add(1);
            if (rowIndex == 0) return listInd;
            list.Add(new List<int>(){1});   
            for (int row = 1; row < rowIndex+1; row++)
            {
                var newList=new List<int>(){1};
                for (int j = 0; j < row-1; j++)
                {
                    
                    var ans = list[row - 1][j] + list[row - 1][j + 1];
                    newList.Add(ans);
                    if (row == rowIndex)
                    {
                        
                        listInd.Add(ans);
                       
                    }
                }
                newList.Add(1);
                list.Add(newList);
                
            }
            listInd.Add(1);

            return listInd;
        }
    }
}
// var list = new List<IList<int>>();
// list.Add(new List<int>(){1});
// var result = new List<int>();
// for (int row = 1; row < rowIndex+1; row++)
// {
//     var newList = new List<int>() {1};
//     for (int j = 0; j < row-1; j++)
//     {
//                     
//         var prevRow = list[row - 1];
//         var sum = prevRow[j] + prevRow[j + 1];
//         newList.Add(sum);
//                     
//     }
//     newList.Add(1);
//     list.Add(newList);
//     if (row == rowIndex)
//     {
//         return newList;
//
//     }
// }
//             
// return new List<int>(){1};