using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class NNode
    {
        public NNode? left;
        public NNode? right;
        public NNode? next;
        public int val;
        public NNode(int val=0,NNode left=null,NNode right =null,NNode next=null)
        {
            this.left = left;
            this.val = val;
            this.right = right;
            this.next = next;
        }
    }
    public class BinaryTreePreorderTraversal
    {
        public NNode rootNode;
        public BinaryTreePreorderTraversal()
        {
            var t1 = new NNode(1);
            var t2 = new NNode(2);
            var t3 = new NNode(3);
            var t4 = new NNode(4);
            var t5 = new NNode(5);
            var t6 = new NNode(6);
            var t7 = new NNode(7);
            t1.left = t2;
            t1.right = t5;
            t2.left = t3;
            t2.right = t4;  
            t5.left=t6;
            t5.right = t7;
            rootNode = t1;
        }
        public IList<int> PreorderTraversal(NNode root)
        {
            var list = new List<int>();
            var stack=new Stack<NNode>();
            if(root==null)
                return list;
            stack.Push(root);
            while(stack.Count!=0)
            {
                var node=stack.Pop();
                list.Add(node.val);
                if(node.right!=null)
                {
                    stack.Push(node.right);
                }
                if(node.left!=null)
                {
                    stack.Push(node.left);
                }
           
            }
            return list;
        }
    }
}