using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var set = new HashSet<char>(jewels);
            var cnt = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (set.Contains(stones[i]))
                {
                    cnt += 1;
                }
            }

            return cnt;
        }
    }
}