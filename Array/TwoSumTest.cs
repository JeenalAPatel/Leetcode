using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSumTest
    {
        HashSet<int> set = new HashSet<int>();
        public bool sum(int[] arr,int target)
        {
            
            foreach (var item in arr)
            {
                var temp = target - item;
                if (set.Contains(temp))
                {
                    return true;
                }
                else
                {
                    set.Add(item);
                }
            }

            return false;
        }
    }
}