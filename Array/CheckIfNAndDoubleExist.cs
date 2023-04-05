using System.Collections.Generic;

namespace LeetCode.Array
{
    public class CheckIfNAndDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i] * 2)||(arr[i]%2==0 && set.Contains(arr[i]/2)))
                {
                    return true;
                }
                
                set.Add(arr[i]);
                
            }

            return false;
        }
    }
}