using System;
using System.Collections.Generic;

namespace LeetCode.Array
{
    public class FindDesappearNum
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int newInd = Math.Abs(nums[i]) - 1;
                if (nums[newInd] > 0)
                    nums[newInd] *= -1;
            }

            var list = new List<int>();
            for (int i = 1; i <= nums.Length; i++)
            {
                if (nums[i - 1] > 0)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}



// var list = new List<int>();
// var set = new HashSet<int>();
// for (int i = 0; i < nums.Length; i++)
// {
//     set.Add(nums[i]);
// }
//
// for (int i = 0; i < nums.Length; i++)
// {
//     if (!set.Contains(i+1))
//     {
//         list.Add(i+1);
//     }
// }
//
// return list;