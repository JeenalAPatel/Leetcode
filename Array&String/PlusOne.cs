using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeArray
{
    public class PlusOne
    {
        public int[] PlusOneIndex(int[] digits)
        {
            var carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += carry;
                if (digits[i] <= 9)
                {
                    carry = 0;
                }
                else
                {
                    carry = digits[i] / 10;
                    digits[i] %= 10;    
                }
                
            }

            if (carry > 0)
            {
                var newArray = new int[digits.Length + 1];
                newArray[0] = carry;
                System.Array.Copy(digits, 0, newArray, 1, digits.Length);
                return newArray;
            }

            return digits;
        }
    }
}