using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class DesignHashset
    {
        HashSet<int> set = new HashSet<int>();
     
    
        public void Add(int key)
        {
            set.Add(key);
        }
    
        public void Remove(int key)
        {
            set.Remove(key);
        }
    
        public bool Contains(int key) 
        {
            if (set.Contains(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}