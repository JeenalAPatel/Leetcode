namespace LeetCodeArray
{
    public class RemoveElement
    {
        public int RemoveElementt(int[] nums, int val)
        {
            var p1 = 0;
            var p2 = 0;
            
            while (p2 <= nums.Length - 1)
            {
                if (nums[p2] != val)
                {
                   
                    nums[p1] = nums[p2];
                    p1+=1;
                    
                }

                p2 += 1;
            }

            return p1;
        }
    }
}