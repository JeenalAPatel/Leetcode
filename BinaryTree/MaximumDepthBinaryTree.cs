using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class MaximumDepthBinaryTree
    {
        public NNode Root;

        public MaximumDepthBinaryTree(List<int?> list)
        {
            Root = BinaryTreeUtils.CreateTreeFromArray(list);
        }
        public int MaxDepth(NNode? root)
        {
            if (root == null)
                return 0;
            var stack = new Stack<(NNode, int)>();
            var curlevel = 1;
            stack.Push((root,curlevel));
            while (stack.Count > 0)
            {
                var (node, lev) = stack.Pop();
                if (lev > curlevel)
                {
                    curlevel =lev;
                }
                if (node.left != null)
                {
                    stack.Push((node.left,lev+1));
                }

                if (node.right != null)
                {
                    stack.Push((node.right,lev+1));
                }
            }

            return curlevel;
        }
    }
}
// public int MaxDepth(NNode? root)
// {
//     if (root == null) return 0;
//     else
//     {
//         int left_depth=MaxDepth(root.left);
//         int right_depth=MaxDepth(root.right);
//         return Math.Max(left_depth,right_depth) + 1;
//     }
// }