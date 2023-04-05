using System;

namespace LeetCode.Array
{
    public class MaxConsecutiveOnes2
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var left = 0;
            var right = 0;
            var numZeroes = 0;
            var longestSequence = 0;
            while (right < nums.Length)
            {
                if (nums[right] == 0) numZeroes += 1;
                while (numZeroes == 2)
                {
                    if (nums[left] == 0) numZeroes -= 1;
                    left += 1;
                }

                longestSequence = Math.Max(longestSequence, right - left + 1);
                right += 1;
            }

            return longestSequence;
        }
    }
}



// var left = 0;
// var right = 0;
// var zero = 0;
// var max = int.MinValue;
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] == 1)
//     {
//         if (zero == 1)
//         {
//             right += 1;
//         }
//         else
//         {
//             left += 1;
//         }
//     }
//     else
//     {
//         if (zero >0)
//         {
//             zero = 1;
//             max = Math.Max(max, left+right+1);
//             left = right;
//             right = 0;
//         }
//         else
//         {
//             zero += 1;
//         }
//     }
// }
// max = Math.Max(max, left+right+1);
// return max>nums.Length?left:max;