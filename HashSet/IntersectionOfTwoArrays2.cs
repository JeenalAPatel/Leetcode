using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class IntersectionOfTwoArrays2
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var dict2 = new Dictionary<int, int>();
            var list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    dict[nums1[i]] += 1;
                }
                else
                {
                    dict.Add(nums1[i],1);
                }
                
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dict.ContainsKey(nums2[i]))
                {
                    if (dict2.ContainsKey(nums2[i]))
                    {
                        dict2[nums2[i]] += 1;
                    }
                    else
                    {
                        dict2.Add(nums2[i],1);
                    }
                }
               
            }

            foreach (var item in dict2)
            {
                var temp = item.Value < dict[item.Key] ? item.Value : dict[item.Key];
                for (int i = 0; i < temp; i++)
                {
                    list.Add(item.Key);
                }
            }
            return list.ToArray();
        }
    }
}
// System.Array.Sort(nums1);
// System.Array.Sort(nums2);
// var i = 0;
// var j = 0;
// var list = new List<int>();
// while (i<nums1.Length && j<nums2.Length)
// {
//     if (nums1[i] < nums2[j])
//     {
//         i += 1;
//     }
//     else if (nums1[i] > nums2[j])
//     {
//         j += 1;
//     }
//     else
//     {
//         list.Add(nums1[i]);
//         i += 1;
//         j += 1;
//     }
// }
//
// return list.ToArray();