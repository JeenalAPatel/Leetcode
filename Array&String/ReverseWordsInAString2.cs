using System.Linq;
using System.Text;

namespace LeetCodeArray
{
    public class ReverseWordsInAString2
    {
        public string ReverseWords(string s) 
        {
            var str = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    str += string.Join("", sb.ToString().Reverse())+" ";
                    sb.Clear();
                  
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            str += string.Join("", sb.ToString().Reverse());
            return str;
        }
    }
}