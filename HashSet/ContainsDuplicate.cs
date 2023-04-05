using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicates(int[] nums)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(nums[i]);
                }
            }

            return false;
        }
    }
}
// System.Array.Sort(nums);
// for (int i = 0; i < nums.Length-1; i++)
// {
//     if (nums[i] == nums[i + 1]) return true;
// }
//
// return false;