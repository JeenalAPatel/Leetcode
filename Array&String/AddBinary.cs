using System;
using System.Linq;
using System.Text;

namespace LeetCodeArray
{
    public class AddBinary
    {
        public string AddBinari(string a, string b)
        {
            int n = a.Length;
            int m = b.Length;
            if (n < m) return AddBinari(b, a);
            int L = Math.Max(n, m);

            StringBuilder sb = new StringBuilder();
            int carry = 0, j = m - 1;
            for(int i = L - 1; i > -1; --i) {
                if (a[i] == '1') ++carry;
                if (j > -1 && b[j--] == '1') ++carry;

                if (carry % 2 == 1) sb.Append('1');
                else sb.Append('0');

                carry /= 2;
            }
            if (carry == 1) sb.Append('1');
            return string.Join("", sb.ToString().Reverse());
        }
    }
}