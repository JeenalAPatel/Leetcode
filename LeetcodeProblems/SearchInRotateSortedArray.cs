namespace LeetCode.LeetcodeProblems
{
    public class SearchInRotateSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int mid;
            var left = 0;
            var right = nums.Length - 1;
            while (left<=right)
            {
                mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] >= nums[left]) 
                {
                    if (target >=nums[left] && target<nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else 
                {
                    if (target <= nums[right] && target > nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}