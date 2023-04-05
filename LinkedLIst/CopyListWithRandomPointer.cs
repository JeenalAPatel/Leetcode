using System.Collections.Generic;

namespace LeetCode
{
    public class CopyListWithRandomPointer
    {
        public Dictionary<Node, Node> cache = new Dictionary<Node, Node>();

        public Node? GetCloneOfNode(Node? node)
        {
            if (node == null) return null;
            
            if (cache.TryGetValue(node, out var cloneNode))
            {
                return cloneNode;
            }

            var clone =new Node(node.val);
            cache[node] = clone;
            return clone;
        }
        
        public Node? CopyRandomList(Node? head)
        {
            if (head == null) return null;

            var cloneHead = GetCloneOfNode(head);
            var currClone = cloneHead;
            var currNode = head;

            while (currNode != null)
            {
                currClone.next = GetCloneOfNode(currNode.next);
                currClone.random = GetCloneOfNode(currNode.random);

                currClone = currClone.next;
                currNode = currNode.next;
            }

            return cloneHead;

        }
    }
}