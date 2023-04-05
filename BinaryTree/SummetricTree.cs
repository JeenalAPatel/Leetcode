using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class SummetricTree
    {
        
        public NNode Root;

        public SummetricTree(List<int?> list)
        {
            Root = BinaryTreeUtils.CreateTreeFromArray(list);
        }
        public bool IsSymmetric(NNode root)
        {
            var queue = new Queue<(NNode?,NNode?)>();
            queue.Enqueue((root,root));
            while(queue.Count!=0)
            {
                var (t1,t2)=queue.Dequeue();
               
                if(t1==null && t2==null)continue;
                if(t1==null || t2==null)return false;
                if(t1.val != t2.val)return false;
                queue.Enqueue((t1.left,t2.right));
                queue.Enqueue((t1.right,t2.left));
                
            }
           
            return true;
        }
        
    }
}