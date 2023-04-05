namespace LeetCodeArray
{
    public class ReverseString
    {
        public void ReverseStringg(char[] s)
        {
            var p1 = 0;
            var p2 = s.Length - 1;
            while (p1 < p2)
            {
                var temp = s[p1];
                s[p1] = s[p2];
                s[p2] = temp;
                p1++;
                p2--;
            }
        }
    }
}