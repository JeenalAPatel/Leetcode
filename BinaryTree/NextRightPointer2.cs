namespace LeetCode.BinaryTree
{
    public class NextRightPointer2
    {
        public NNode? LeftMost;
        public NNode? Prev;
        public NNode? Connect(NNode? root)
        {
            if (root == null) return root;

            LeftMost = root;
            NNode? curr;
            while (LeftMost != null)
            {
                Prev = null;
                curr = LeftMost;
                LeftMost = null;
                while (curr != null)
                {
                    ProcessChild(curr.left);
                    ProcessChild(curr.right);

                    curr = curr.next;
                }
            }

            return root;
        }
        public void ProcessChild(NNode? node)
        {
            if (node == null) return;

            if (Prev != null)
            {
                Prev.next = node;
            }
            else
            {
                LeftMost = node;
            }
            
            Prev = node;
        }

        
    }
}