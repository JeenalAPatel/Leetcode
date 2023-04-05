using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class PathSum
    {
        public bool HasPathSum(NNode? root, int targetSum)
        {
            if (root == null) return false;
            var nodeStack = new Stack<NNode>();
            var sumStack = new Stack<int>();
            nodeStack.Push(root);
            sumStack.Push(targetSum - root.val);
            NNode node;
            int curr_sum;
            while (nodeStack.Count > 0)
            {
                node = nodeStack.Pop();
                curr_sum = sumStack.Pop();

                if ((node.right == null) && (node.left == null) && (curr_sum == 0)) return true;
                if (node.right != null)
                {
                    nodeStack.Push(node.right);
                    sumStack.Push(curr_sum - node.right.val);
                }

                if (node.left != null)
                {
                    nodeStack.Push(node.left);
                    sumStack.Push(curr_sum - node.left.val);
                }
            }

            return false;
        }
    }
}
// if (root == null) return false;
// var stack = new Stack<(NNode,int)>();
// stack.Push((root,0));
// while (stack.Count>0)
// {
//     var (node, sum) = stack.Pop();
//                 
//     sum += node.val;
//                 
//     if (node.left == null && node.right == null && sum == targetSum) return true;
//
//     if (node.left != null)
//     {
//         stack.Push((node.left,sum));
//     }
//     if (node.right != null)
//     {
//         stack.Push((node.right,sum));
//     }
// }
//
// return false;