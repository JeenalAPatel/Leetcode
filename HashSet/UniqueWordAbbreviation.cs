using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class UniqueWordAbbreviation
    {
        Dictionary<string,List<string>> dict = new Dictionary<string, List<string>>();

        public UniqueWordAbbreviation(string[] dictionary)
        {
            foreach (var item in dictionary)
            {
                var temp = getAbb(item);
                if (dict.ContainsKey(temp))
                {
                    dict[temp].Add(item);
                    
                }
                else
                {
                    dict.Add(temp,new List<string>(){item});
                }
            }
        }
        public bool IsUnique(string word)
        {
            var tempsStr = getAbb(word);
            if (!dict.ContainsKey(tempsStr))
            {
                return true;
            }
            else
            {
                foreach (var item in dict[tempsStr])
                {
                    if (word == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string getAbb(string str)
        {
            var len = str.Length;

            var temp = string.Concat(str[0], str.Length - 2, str[^1]);
            return temp;
        }
    }
}