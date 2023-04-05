using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class TwoSum2
    {
        public Dictionary<int,int> dict1=new Dictionary<int, int>();   
        public void Add(int number)
        {
            if(dict1.ContainsKey(number))
            {
                dict1[number]+=1;
            }
            else
            {
                dict1.Add(number,1);
            }
        }
        public bool Find(int value) 
        {
            foreach (var item in dict1)
            {
                var num=value-item.Key;
                if(num!=item.Key)
                {
                    if(dict1.ContainsKey(num))
                    {
                        return true;
                    }
                }
                else
                {
                    if(item.Value>1)
                        return true;
                }
            }
            return false;
        }
    }
}