using System;
using System.Collections.Generic;
using System.Linq;
public class RandomizedSet{
    public List<int> list=new List<int>();
    public Dictionary<int,int> dict=new Dictionary<int, int>();
    
    public RandomizedSet()
    {

    }
    public bool Insert(int val)
    {
        if(dict.ContainsKey(val))
        {
            return false;   
        }
        dict.Add(val,list.Count);
        list.Add(val);
        return true;
    }
    public bool Remove(int val) {
        if(!dict.ContainsKey(val))
        {
            return false;   
        }
        var lastElement =list[list.Count-1];
        var index=dict[val];
        list[index]=lastElement;
        dict[lastElement]=index;
        list.Remove(list.Count-1);
        dict.Remove(val);

        return true;
    }
    public int GetRandom() {
        var random=new Random();
        return list.ElementAt(random.Next(list.Count));
    }
}