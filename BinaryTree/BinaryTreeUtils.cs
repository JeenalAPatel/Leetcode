using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public static class BinaryTreeUtils
    {
        public static NNode? CreateTreeFromArray(List<int?> arr)
        {
            if (arr.Count == 0)
            {
                return null;
            }

            var head = new NNode((int) arr[0]!);
            var isLeft = true;
            var nodes = new Stack<NNode>();
            nodes.Push(head);
            for (var i = 1; i < arr.Count; i++)
            {
                var val = arr[i];
                if (val == null)
                {
                    if (isLeft)
                    {
                        isLeft = !isLeft;
                    }
                    else
                    {
                        nodes.Pop();
                        while (nodes.TryPeek(out var result) && result.right != null)
                        {
                            nodes.Pop();
                        }
                    }
                    
                }
                else if (isLeft)
                {
                    var newNode = new NNode((int) val);
                    nodes.Peek().left = newNode;
                    nodes.Push(newNode);
                }
                else
                {
                    var newNode = new NNode((int) val);
                    nodes.Peek().right = newNode;
                    nodes.Push(newNode);
                    isLeft = true;
                }
            }

            return head;
        }
    }
}