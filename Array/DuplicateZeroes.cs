namespace LeetCode.Array
{
    public class DuplicateZeroes
    {
        public void DuplicateZeros(int[] arr) {
            var len = arr.Length-1;
            var duplicate_zero=0;
            for (int left = 0; left < arr.Length-duplicate_zero; left++)
            {
                if(arr[left]==0)
                {
                    if(left==len-duplicate_zero)
                    {
                        arr[len]=0;
                        len-=1;
                        break;
                    }
                    duplicate_zero++;
                }
                
            }
            var last=len-duplicate_zero;
            for (int i = last; i >=0; i--)
            {
                if(arr[i]==0)
                {
                    arr[i+duplicate_zero]=0;
                    duplicate_zero--;
                    arr[i+duplicate_zero]=0;
                }
                else
                {
                    arr[i+duplicate_zero]=arr[i];
                }
            }
        }
    }
}