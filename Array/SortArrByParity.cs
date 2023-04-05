namespace LeetCode.Array
{
    public class SortArrByParity
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length == 0) return new int[]{};
            var p1 = 0;
            var p2 = A.Length - 1;
            while (p1<p2)
            {
                if (A[p1] % 2 == 0)
                {
                    p1 += 1;
                }
                else
                {
                    var temp = A[p1];
                    A[p1] = A[p2];
                    A[p2] = temp;
                    p2 -= 1;
                }
            }

            return A;
        }
    }
}