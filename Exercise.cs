using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using LeetCode;
using LeetCode.BinaryTree;
using Microsoft.VisualBasic;


namespace LeetCode
{
    public class Exercise
    {
        public bool IsHappy(int n)
        {
            while (n>0)
            {
                var mod = n % 10;
                var div = n / 10;
                n = (mod * mod) + (div * div);
                if (n == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
    
}