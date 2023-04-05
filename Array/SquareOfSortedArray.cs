namespace LeetCode.Array
{
    public class SquareOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            var arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i] * nums[i];
            }
            System.Array.Sort(arr);
            return arr;
        }
    }
}
// var left = 0;
// var square = 0;
// var right = nums.Length - 1;
// var arr = new int[nums.Length];
// for (int i = nums.Length-1; i >=0; i--)
// {
//     if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
//     {
//         square = nums[right];
//         right-=1;
//     }
//     else
//     {
//         square = nums[left];
//         left+=1;
//     }
//
//     arr[i] = square * square;
// }
// return arr;