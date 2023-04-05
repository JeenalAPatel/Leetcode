using System;
using System.Collections.Generic;

namespace LeetCodeArray
{                                               
    public class MinimumSizeSubArraySum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var sum = 0;
            var lp = 0;
            var rp = 0;
            var minLength = int.MaxValue;

            while (rp < nums.Length || sum >= target)
            {
                if (sum >= target)
                {
                    minLength = Math.Min(minLength, rp - lp);
                    sum -= nums[lp];
                    lp += 1;
                }
                else
                {
                    sum += nums[rp];
                    rp += 1;
                }
            }

            return lp == 0 ? 0 : minLength;
        }
    }
}