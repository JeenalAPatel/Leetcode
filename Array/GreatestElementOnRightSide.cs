using System;

namespace LeetCode.Array
{
    public class GreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            var max = arr[arr.Length - 1];
            for (int i = arr.Length-2; i >=0; i--)
            {
                var curNum = arr[i];
                arr[i] = max;
                max = Math.Max(max, curNum);
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}