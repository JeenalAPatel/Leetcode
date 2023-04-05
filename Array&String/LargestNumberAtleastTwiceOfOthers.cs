using System;

namespace LeetCodeArray
{
    public class LargestNumberAtleastTwiceOfOthers
    {
        public int DominantIndex(int[] nums)
        {
            int big = -1;
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= big)
                {
                    big = nums[i];
                    index = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != big)
                {
                    if (big < nums[i] * 2)
                        return -1;
                }
                
            }

            return index;
        }
    }
}