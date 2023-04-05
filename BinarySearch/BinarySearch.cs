namespace LeetCode.BinarySearch
{
    public class BinarySearch
    {
        public int Search(int[]? nums, int target)
        {
            if (nums == null) return 0;
            var left = 0;
            var right = nums.Length - 1;
            int pivot;
            while (left<=right)
            {
                pivot = left + (right - left) / 2;
                if (target == nums[pivot]) return pivot;
                if (target < nums[pivot]) right = pivot - 1;
                if (target > nums[pivot]) left = pivot + 1;
            }

            return -1;
        }
    }
}