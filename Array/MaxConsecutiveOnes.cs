using System;

namespace LeetCode.Array
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var cnt = 0;
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    cnt += 1;
                    max = Math.Max(max, cnt);
                }
                else
                {
                    cnt = 0;
                }
            }

            return max;
        }
    }
}