using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashSet
{
    public class MinimumIndexSum
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dict = new Dictionary<string, int>();
            var dict2 = new SortedDictionary<int,List<string>>();
            var list = new List<string>();
            for (int i = 0; i < list1.Length; i++)
            {
                dict.Add(list1[i],i);
            }

            for (int i = 0; i < list2.Length; i++)
            {
                if (dict.ContainsKey(list2[i]))
                {
                    dict[list2[i]] += i;
                    var val = dict[list2[i]];
                    if (dict2.ContainsKey(dict[list2[i]]))
                    {
                        dict2[val].Add(list2[i]);
                    }
                    else
                    {
                        dict2.Add(dict[list2[i]],new List<string>(){list2[i]});
                    }
                }
            }

         
            foreach (var val in dict2.Values.FirstOrDefault()!)
            {
                list.Add(val);
            }
            return list.ToArray();
        }
    }
}
// var dict = new Dictionary<string, int>();
// for(int i=0;i<list1.Length;i++)
// {
//     dict.Add(list1[i],i);
// }
// var sum=0;
// var list=new List<String>();
// int min_sum=int.MaxValue;
// for(int j=0;j<list2.Length && j<=min_sum;j++)
// {
//     if(dict.ContainsKey(list2[j]))
//     {
//         sum=j+dict[list2[j]];
//         if (sum < min_sum)
//         {
//             list.Clear();
//             list.Add(list2[j]);
//             min_sum=sum;
//         } 
//         else if(sum==min_sum)
//         {
//             list.Add(list2[j]);
//         }
//                    
//     }
//                
// }
//             
// return list.ToArray();