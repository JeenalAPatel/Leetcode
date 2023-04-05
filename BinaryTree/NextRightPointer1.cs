using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class NextRightPointer1
    {
        public NNode? Connect(NNode? root)
        {
            if (root == null) return null;
            var queue = new Queue<(NNode node,int level)>();
            queue.Enqueue((root,0));
            while (queue.Count>0)
            {
                var (node, lev) = queue.Dequeue();
                if (queue.TryPeek(out var peekNode) && lev == peekNode.level)
                {
                    node.next = peekNode.Item1;
                }
                
                if (node.left != null)
                {
                    queue.Enqueue((node.left,lev+1));
                }
                if (node.right != null)
                {
                    queue.Enqueue((node.right,lev+1));
                }
                
            }

            return root;
        }
    }
}