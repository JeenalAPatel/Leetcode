namespace LeetCode.Array
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }

            if (m == 0)
            {
                System.Array.Copy(nums2,nums1,nums1.Length);
                return;
            }
            var p3 = nums1.Length - 1;
            var p2 = nums2.Length - 1;
            var p1 = m-1;
            while (p2>=0 && p1>=0)
            {
                if (nums1[p1] >= nums2[p2])
                {
                    nums1[p3] = nums1[p1];
                    p3 -= 1;
                    p1 -= 1;
                }
                else
                {
                    nums1[p3] = nums2[p2];
                    p2 -= 1;
                    p3 -= 1;
                }
            }

            if (p2>= 0)
            {
                for (int i = p3; i >=0; i--)
                {
                    nums1[p3] = nums2[p2];
                    p3 -= 1;
                    p2 -= 1;
                }
            }
            
        }
    }
}