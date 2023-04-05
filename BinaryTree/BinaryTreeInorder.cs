using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class BinaryTreeInorder
    {   public NNode root;
        public BinaryTreeInorder()
        {
            var t1 = new NNode(1);
            var t2 = new NNode(2);
            var t3 = new NNode(3);
            var t4 = new NNode(4);
            var t5 = new NNode(5);
            var t6 = new NNode(6);
            var t7 = new NNode(7);
            t1.left = t2;
            t1.right = t5;
            t2.left = t3;
            t2.right = t4;
            t5.left=t6;
            t5.right = t7;
            root = t1;
        }
        public IList<int> InorderTraversal(NNode root)
        {
            var stack = new Stack<NNode>();
            var list = new List<int>();
            if (root == null)
                return list;
            var cur = root;
            while (cur != null || stack.Count != 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }

                cur = stack.Pop();
                list.Add(cur.val);
                cur = cur.right;
            }

            return list;
        }
    }
}