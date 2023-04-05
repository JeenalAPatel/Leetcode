using System.Collections.Generic;

namespace LeetCode
{
    public class PerfectSquares
    {
        public static int NumSquares(int n)
        {
            var squareNums = new List<int>();
            for (int i = 0; i *i<=n; i++)
            {
                squareNums.Add(i*i);
            }
            int level = 0;
            var queue = new HashSet<int>();
            
            queue.Add(n);
            while (queue.Count > 0)
            {
                level += 1;
                var nextQueue = new HashSet<int>();
                foreach (var remainder in queue)
                {
                    
                    foreach (var squareNum  in squareNums)
                    {
                        if (remainder == squareNum)
                        {
                            return level;
                        }

                        else if (remainder < squareNum)
                        {
                            break;
                        }
                        else
                        {
                            nextQueue.Add(remainder - squareNum);
                        }
                    }
                    
                }
                queue = nextQueue;
            }
            return level;
        }
    }
}