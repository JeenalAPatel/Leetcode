namespace LeetCodeArray
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums) 
        {
            int sum = 0, leftsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            for (int i = 0; i < nums.Length; i++) 
            {
                if (leftsum == sum - leftsum - nums[i]) 
                    return i;
                leftsum += nums[i];
            }
            return -1;
        }
        
    }
}