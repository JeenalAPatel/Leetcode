using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class DesignHasemap
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        public void Put(int key, int value) 
        {
            
            dict[key] = value;
            
        }
    
        public int Get(int key)
        {
            if(dict.ContainsKey(key))
                return dict[key];
            else
            {
                return -1;
            }
        }
    
        public void Remove(int key)
        {
            if(dict.ContainsKey(key))
                dict.Remove(key);
           
        }
    }
}