using System.Linq.Expressions;

namespace LeetCodeArray
{
    public class ImplementStrstr
    {
        public int StrStr(string haystack, string needle)
        {
            int L = needle.Length;
            int n = haystack.Length;
            if (L == 0) return 0;
            int pn = 0;
            while (pn < n - L + 1) {
                while (pn < n - L + 1 && haystack[pn] != needle[0]) ++pn;
                int currLen = 0, pL = 0;
                while (pL < L && pn < n && haystack[pn] == needle[pL]) {
                    ++pn;
                    ++pL;
                    ++currLen;
                }
                if (currLen == L) return pn - L;
                pn = pn - currLen + 1;
            }
            return -1;
        }
        public int StrStr2(string haystack, string needle)
        {
            var hayLen = haystack.Length;
            var needleLen = needle.Length;
            if (needleLen == 0) return 0;
            for (int hayPtr = 0; hayPtr <= hayLen-needleLen; hayPtr++)
            {
                if (needle[0] == haystack[hayPtr])
                {
                    for (int needlePtr = 0; needlePtr < needleLen &&(hayPtr+needlePtr)<hayLen; needlePtr++)
                    {
                        if (needle[needlePtr] == haystack[hayPtr + needlePtr])
                        {
                            if (needlePtr == needleLen - 1)
                            {
                                return hayPtr;
                            }
                        }
                        else
                        {
                            break;

                        }
                    }
                }
            }

            return -1;
        }
    }
}
// if (needle.Length == 0) return 0;
// for (var i = 0; i <= haystack.Length - needle.Length; i++)
// {
//     var needleIndex = 0;
//     while (needleIndex < needle.Length && haystack[i + needleIndex] == needle[needleIndex])
//     {
//         needleIndex += 1;
//     }
//     if (needleIndex == needle.Length)
//     {
//         return i;
//     }
// }
// return -1;