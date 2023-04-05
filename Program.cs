using System;
using System.Collections.Generic;
using LeetCode.BinaryTree;

namespace LeetCode
{
    class Program
    {
        public static void Main()
        {
            var ex = new Exercise();
            var ans=ex.IsHappy(19);
            // foreach (var val in ans)
            // {
            //     Console.WriteLine(val);
            // }
            Console.WriteLine(ans);
        }
    }
}