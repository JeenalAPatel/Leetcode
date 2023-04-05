using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class TwoNum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var val = target - nums[i];
                if (dict.ContainsKey(val))
                {
                    arr[0] = dict[val];
                    arr[1] = i;
                }
                else
                {
                    dict.Add(nums[i],i);
                }
            }

            return arr;
        }
    }
}