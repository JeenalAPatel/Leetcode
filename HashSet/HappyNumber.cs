using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            while (n != 1 && !set.Contains(n))
            {

                set.Add(n);
                n = getNum(n);
            }

            return n==1;
        }

        public int getNum(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                var mod = num % 10;
                num = num / 10;
                sum += mod * mod;

            }
            return sum;
        }
    }
}