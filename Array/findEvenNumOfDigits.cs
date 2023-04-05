using System;

namespace LeetCode.Array
{
    public class findEvenNumOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            var cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int val = 1;
                while (nums[i]/(int)Math.Pow(10,val)!=0)
                {
                    val += 1;
                }
                if (val % 2 == 0)
                {
                    cnt += 1;
                }
            }

            return cnt;
        }
    }
}

// public int FindNumbers(int[] nums)
// {
//     var cnt = 0;
//     foreach (var item in nums)
//     {
//         var div = item / 10;
//         var no_of_digit = 1;
//         var i = 1;
//         while (div > 0)
//         {
//             i = i + 1;
//             div = (int) (item / Math.Pow(10,i));
//             no_of_digit += 1;
//         }
//
//         if (no_of_digit % 2 == 0)
//         {
//             cnt += 1;
//         }
//     }
//
//     return cnt;
// }