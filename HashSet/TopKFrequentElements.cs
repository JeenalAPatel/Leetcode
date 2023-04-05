using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k) {
            var list= new List<int>();
            var dict =new Dictionary<int,int>();
            var sortedDict = new SortedDictionary<int,List<int>>();
            for(int i=0;i<nums.Length;i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]-=1;
                }
                else{
                    dict.Add(nums[i],-1);
                }
            }
            foreach (var item in dict)
            {
                if(sortedDict.ContainsKey(item.Value))
                {
                    sortedDict[item.Value].Add(item.Key);
                }
                else
                {
                    sortedDict.Add(item.Value,new List<int>(){item.Key});
                }
            }
            var enumerator=sortedDict.GetEnumerator();
            while(k>0)
            {
                enumerator.MoveNext();
                var num=enumerator.Current.Value;
                for (int i = 0; i <num.Count; i++)
                {
                    list.Add(num[i]);
                    k--;
                    if(k==0)
                    {
                        return list.ToArray();
                    }
                }
                
            }
            return null;
            
                
        }
    }
}