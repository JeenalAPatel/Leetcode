using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LeetCode
{
    public class OpenLockSolution
    {
        public List<string>? OpenLock(string[] deadEnds, string target)
        {
            var seen = new HashSet<string>();
            var queue = new Queue<(string, List<string>)>();
            var deadEndSet = new HashSet<string>(deadEnds);

            const string start = "0000";
            if (deadEndSet.Contains(start))
            {
                return null;
            }

            if (start == target)
            {
                return new List<string>() {start};
            }

            queue.Enqueue((start, new List<string>() {start}));
            var operations = new[] {1, -1};

            while (queue.Count > 0)
            {
                var (combination, sequence) = queue.Dequeue();

                // Get neighbors of combination
                for (var i = 0; i < combination.Length; i++)
                {
                    var element = combination[i];
                    foreach (var op in operations)
                    {
                        var newElement = (int.Parse(element.ToString()) + op + 10) % 10;
                        var newCombination = combination.Substring(0, i) + newElement +
                                             combination.Substring(i + 1);
                        if (seen.Contains(newCombination) || deadEndSet.Contains(newCombination)) continue;

                        if (newCombination.Equals(target))
                        {
                            sequence.Add(newCombination);
                            return sequence;
                        }

                        var newSequence = new List<string>(sequence) {newCombination};
                        queue.Enqueue((newCombination, newSequence));
                        seen.Add(newCombination);
                    }
                }
            }

            return null;
        }
    }
}