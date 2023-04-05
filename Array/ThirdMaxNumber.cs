using System.Collections.Generic;

namespace LeetCode.Array
{
    public class ThirdMaxNumber
    {
        public int ThirdMax(int[] nums)
        {
            var max =int.MinValue;
            var secondMax = int.MinValue;
            var thirdMax = int.MinValue;
            var set = new HashSet<int>(nums);
            foreach (var val in set)
            {
                if (max < val)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = val;
                }
                else if (secondMax < val)
                {
                    thirdMax = secondMax;
                    secondMax = val;
                }
                else if(thirdMax<val)
                {
                    thirdMax = val;
                }
            }

            return set.Count <3 ? max :thirdMax;


        }
    }
}