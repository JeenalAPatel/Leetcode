using System.Collections.Generic;
using LeetCode.BinaryTree;

namespace LeetCode
{
    public class BinaryTreeInorderTraversal
    {
        public BinaryTree.NNode rootNode;
        
        public BinaryTreeInorderTraversal()
        {
            var t1 = new BinaryTree.NNode(1);
            var t2 = new BinaryTree.NNode(2);
            var t3 = new BinaryTree.NNode(3);
            t1.right = t2;
            t2.left = t3;
            rootNode = t1;
        }

        public IList<int> InorderTraversal(BinaryTree.NNode root)
        {
            List<int> res = new List<int>();
            Stack<BinaryTree.NNode> stack = new Stack<BinaryTree.NNode>();
            BinaryTree.NNode curr = root;
            while (curr != null || stack.Count != 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }

            return res;
        }
    }
}