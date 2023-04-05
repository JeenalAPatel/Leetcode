using System.Collections.Generic;

namespace LeetCode
{
    public class OpenLock
    {
        public int OpenLockMethod(string[] deadends, string target)
        {
            var seen = new HashSet<string>();
            var queue = new Queue<(string, int)>();
            var deadEndSet = new HashSet<string>(deadends);
            const string start = "0000";
            if (deadEndSet.Contains(start))
            {
                return -1;
            }

            if (start == target)
            {
                return 0;
            }
            var operations = new int[]{1,-1};
            queue.Enqueue((start,0));
            seen.Add(start);
            while (queue.Count > 0)
            {
                var (combination, depth) = queue.Dequeue();
                for (int i = 0; i < combination.Length; i++)
                {
                    var element = combination[i];
                    foreach (var op in operations)
                    {
                        var newCombination = (int.Parse(element.ToString()) + op + 10) % 10;
                        var newSequence = combination.Substring(0, i) + newCombination
                                                                      + combination.Substring(i + 1);
                        if(seen.Contains(newSequence) || deadEndSet.Contains(newSequence))
                            continue;
                        if (newSequence.Equals(target))
                        {
                            return depth + 1;
                        }

                        queue.Enqueue((newSequence,depth+1));
                        seen.Add(newSequence);
                    }
                }

            }

            return -1;
        }
    }
}