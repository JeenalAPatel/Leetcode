using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    public class LevelOrderTraversal
    {
        public NNode? Root;
        public LevelOrderTraversal(List<int?> list)
        {
            Root = BinaryTreeUtils.CreateTreeFromArray(list);
        }

        public IList<IList<int>> LevelOrder(NNode? root)
        {
            var list = new List<IList<int>>();
            if (root == null) return list;
            list.Add(new List<int>());
            var queue = new Queue<(NNode, int)>();
            var currentLevel = 0;
            queue.Enqueue((root,currentLevel));
            while (queue.Count>0)
            {
                var (node,level) = queue.Dequeue();
                
                if (level > currentLevel)
                {
                    list.Add(new List<int>(){node.val});
                    currentLevel += 1;
                }
                else
                {
                    list.Last().Add(node.val);
                }

                if (node.left != null)
                {
                    queue.Enqueue((node.left,level+1));
                }
                if (node.right != null)
                {
                    queue.Enqueue((node.right,level+1));
                }
            }

            return list;
        }
    
    }
}