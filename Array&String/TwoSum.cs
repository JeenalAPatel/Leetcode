using System.Collections.Generic;
using System.Linq;

namespace LeetCodeArray
{
    public class TwoSum
    {
        public int[] TwoSumm(int[] numbers, int target)
        {
            var arr = new List<int>();
            var low = 0;
            var high = numbers.Length - 1;
            while (low<high)
            {
                var sum = numbers[low] + numbers[high];
                if(sum==target)
                {
                    return new int[] {low + 1, high + 1};
                }
               
                else if (sum>= target)
                    high -= 1;
                else
                {
                    low += 1;
                }
                
            }

            return new int[] {-1, -1};
        }
    }
}