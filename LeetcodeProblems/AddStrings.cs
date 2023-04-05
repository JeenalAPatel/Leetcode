using System.Linq;
using System.Text;

namespace LeetCode.LeetcodeProblems
{
    public class AddStrings
    {
        public string AddStringss(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int p1 = num1.Length - 1;
            int p2 = num2.Length - 1;
            while (p1 >= 0 || p2 >= 0)
            {
                int x1 = p1 >= 0 ? num1[p1] -'0': 0;
                int x2 = p2 >= 0 ? num2[p2] -'0': 0;
                int value = (x1 + x2 + carry) % 10;
                carry = (x1 + x2 + carry) / 10;
                sb.Append(value);
                p1--;
                p2--; 
            }

            if (carry != 0)
            {
                sb.Append(carry);
            }

            return new string(sb.ToString().Reverse().ToArray());

        }
    }
}