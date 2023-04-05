namespace LeetCode.Array
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return;
            var p1 = 0;
            var p2 = 0;
            while (p2<nums.Length)
            {
                if (nums[p2] != 0)
                {
                    nums[p1] = nums[p2];
                    p1 += 1;
                }

                p2 += 1;
            }

            while (p1<nums.Length)
            {
                nums[p1] = 0;
                p1 += 1;
            }
        }
    }
}

// public void MoveZeroes(int[] nums)
// {
//     if (nums.Length == 0) return;
//     var p1 = 0;
//     var p2 = 1;
//     while (p2<nums.Length)
//     {
//         if (nums[p1] == 0 && nums[p2]!=0)
//         {
//             nums[p1] = nums[p2];
//             nums[p2] = 0;
//             p1 += 1;
//         }
//         else if(nums[p1]!=0)
//         {
//             p1 += 1;
//         }
//         p2 += 1;
//     }
//
// }