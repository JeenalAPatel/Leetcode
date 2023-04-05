using System.Collections.Generic;

namespace LeetCode
{
    public class DLinkedNode
    {
        public int val;
        public DLinkedNode? prev;
        public DLinkedNode? next;
        public DLinkedNode? child;

        public DLinkedNode(int val = 0, DLinkedNode? prev = null, DLinkedNode? next = null, DLinkedNode? child = null)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
            this.child = child;
        }
    }
    public class FlattenMultilevelDoublyLinkedList
    {
       
        public DLinkedNode? Flatten(DLinkedNode? head)
        {
            if (head == null) return null;
            var stack = new Stack<DLinkedNode>();
            stack.Push(head);
            DLinkedNode? lastNode = null;

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                node.prev = lastNode;
                
                if (lastNode != null)
                {
                    lastNode.next = node;
                }
                
                while (node != null && node.child == null)
                {
                    lastNode = node;
                    node = node.next;
                }

                if (node?.child == null) continue;
                
                lastNode = node;
                    
                if (node.next != null)
                {
                    stack.Push(node.next);
                }
                    
                node.next = node.child;
                stack.Push(node.child);
                node.child = null;
            }
        
            return head;
        }
    }
}