using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class IsomorphicString
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if(dict[s[i]]==t[i])
                        continue;
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (!dict.ContainsValue(t[i]))
                    {
                        dict.Add(s[i],t[i]);

                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}