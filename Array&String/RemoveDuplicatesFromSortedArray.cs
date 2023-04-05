using System.Collections.Generic;

namespace LeetCodeArray
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var p1 = 0;
            var p2 = 1;
            while(p2<nums.Length)
            {
                if (nums[p1] != nums[p2])
                {
                    p1 += 1;
                    nums[p1] = nums[p2];
                }
                p2 += 1;
            }

            return p1+1;
        }
    }
}