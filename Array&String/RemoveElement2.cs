namespace LeetCodeArray
{
    public class RemoveElement2
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length-1;
            while (i <= n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n];
                    n -= 1;
                }
                else
                {
                    i += 1;
                }
            }

            return i;
        }
    }
}