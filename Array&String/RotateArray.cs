using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeArray
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (k == 0)
            {
                return;
            }

            var len = nums.Length;
            var temp = new int[len];
            Array.Copy(nums, temp, len);

            for (int i = 0; i < len; i++)
            {
                var outputIndex = (i + k) % len;
                nums[outputIndex] = temp[i];
            }
        }

        public void Rotatee(int[] nums, int k)
        {
            k = k % nums.Length;
            rev(nums, 0, nums.Length - 1);
            rev(nums, 0, k - 1);
            rev(nums, k, nums.Length - 1);
        }

        public void rev(int[] nums, int start, int end)
        {
            while (start < end)
            {
                var temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                end -= 1;
                start += 1;
            }
        }
    }

}