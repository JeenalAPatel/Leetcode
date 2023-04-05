namespace LeetCode.Array
{
    public class RemoveElement
    {
        public int RemoveElementt(int[] nums, int val)
        {
            var p1 = 0;
            var p2 = nums.Length - 1;
            while (p1<=p2)
            {
                if (nums[p1] == val)
                {
                    var temp = nums[p1];
                    nums[p1] = nums[p2];
                    nums[p2] = temp;
                    p2 -= 1;
                }
                else
                {
                    p1 += 1;
                }
                
            }

            return p1;
        }
    }
}