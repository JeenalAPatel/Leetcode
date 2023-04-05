using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class SingleNumber
    {
        public int SingleNumbere(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict.Add(nums[i],1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict[nums[i]] == 1) return nums[i];
            }

            return 0;
        }
    }
}