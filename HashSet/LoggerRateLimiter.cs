using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class LoggerRateLimiter
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (dict.ContainsKey(message))
            {
                var oldTimeStamp = timestamp - dict[message];
                if (oldTimeStamp>=10)
                {
                    dict[message] = timestamp;
                    return true;
                }
            }
            else
            {
                dict.Add(message,timestamp);
                return true;
            }

            return false;
        }
    }
}