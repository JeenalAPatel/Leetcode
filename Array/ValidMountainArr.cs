namespace LeetCode.Array
{
    public class ValidMountainArr
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;
            int i = 0;
            int len = arr.Length;
            while (i+1 <len &&arr[i]<arr[i+1])
            {
                i += 1;
            }

            if (i == 0 || i == len-1) return false;
            while (i+1<len && arr[i+1]<arr[i])
            {
                i += 1;
            }

            return i == len-1;
        }
    }
}