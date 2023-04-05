namespace LeetCodeArray
{
    public class LargestNumberAtLeastTwice2
    {
        public int DominantIndex(int[] nums)
        {
            int max = nums[0];
            int secondMax = 0;
            int index = 0;
            for (int i=1; i<nums.Length; i++) 
            {
                int n = nums[i];
                if (n > max) 
                {
                    index = i;
                    secondMax = max;
                    max = n;
                }
                else if (n > secondMax) 
                {
                    secondMax = n;
                }
            }
            return max >= 2 * secondMax ? index : -1;
        }
    }
}