
namespace LeetCode.BinarySearch
{
   
    public class GuessNumHigherOrLower
    {
        public int GuessNumber(int n) {
            int pivot;
            var right = n;
            var left = 0;
            while (left<=right)
            {
                pivot = left + (right - left) / 2;
                int res=guess(pivot);
                if (res==0) return pivot;
                else if (res<0) right = pivot - 1;
                else left = pivot + 1;
            }

            return -1;
        }
        //this is unnecessary..just to avoid error.
        public int guess(int num)
        {
            return 0;
        }
    }
    
}