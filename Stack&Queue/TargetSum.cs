namespace LeetCode
{
    public class TargetSum
    {
        
            int _count = 0;
            int FindTargetSumWayss(int[] nums, int S) 
            {
                Calculate(nums, 0, 0, S);
                return _count;
            }

            void Calculate(int[] nums, int i, int sum, int S) 
            {
                if (i == nums.Length) {
                    if (sum == S)
                        _count++;
                } else {
                    Calculate(nums, i + 1, sum + nums[i], S);
                    Calculate(nums, i + 1, sum - nums[i], S);
                }
            }
            
        
    }
}