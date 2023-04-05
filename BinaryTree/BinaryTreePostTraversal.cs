using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace LeetCode.BinaryTree
{
    public class BinaryTreePostTraversal
    {
        public NNode? Root;

        public BinaryTreePostTraversal(List<int?> arr)
        {
            Root = BinaryTreeUtils.CreateTreeFromArray(arr);
        }

        public IList<int> PostorderTraversal(NNode? root)
        {
            var stack = new Stack<NNode>();
            var result = new Stack<int>();
            if (root == null)
            {
                return new List<int>();
            }

            stack.Push(root);

            while (stack.Count > 0)
            {
                var elem = stack.Pop();
                result.Push(elem.val);

                if (elem.left != null)
                {
                    stack.Push(elem.left);
                }

                if (elem.right != null)
                {
                    stack.Push(elem.right);
                }
            }

            return result.ToList();
        }
    }
}