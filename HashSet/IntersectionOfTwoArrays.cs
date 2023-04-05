using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>(nums1);
            var list = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (set.Contains(nums2[i]))
                {
                    list.Add(nums2[i]);
                    set.Remove(nums2[i]);
                }
                
            }

            return list.ToArray();
        }
    }
}
// var set1 = new HashSet<int>(nums1);
// var set2 = new HashSet<int>(nums2);
// var list = new List<int>();
// var ans=set1.Intersect(set2);
// foreach (var val in ans)
// {
//     list.Add(val);
// }
//
// return list.ToArray();