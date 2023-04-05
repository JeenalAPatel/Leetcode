using System;

namespace LeetCodeArray
{
    public class MaxConsicutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var count = 0;
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count += 1;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }

            return max;
        }
    }
}