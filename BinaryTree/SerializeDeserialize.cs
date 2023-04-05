using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    public class SerializeDeserialize
    {
         public NNode Root;
        public NNode? LeftMost;
        public NNode? Prev;
        Dictionary<NNode, NNode> cache = new Dictionary<NNode, NNode>();

        public SerializeDeserialize(List<int?> list)
        {
            // Root = BinaryTreeUtils.CreateTreeFromArray(list);
            NNode t1 = new NNode(1);
            NNode t2 = new NNode(2);
            NNode t3 = new NNode(3);
            NNode t4 = new NNode(4);
            NNode t5 = new NNode(5);
            // NNode t6 = new NNode(6);
            // NNode t7 = new NNode(7);
            // NNode t8 = new NNode(8);
            // NNode t9 = new NNode(9);
            t1.left = t2;
            t1.right = t3;
            // t2.left = null;
            // t2.right = null;
            t3.left = t4;
            t3.right = t5;

            Root = t1;
        }

        public string? serialize(NNode? root)
        {
            if (root == null) return null;
            var queue = new Queue<NNode?>();
            List<string> list = new List<string>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                NNode? node = queue.Dequeue();
                if (node == null)
                {
                    list.Add("null");
                    continue;
                }

                list.Add(node.val.ToString());
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            return string.Join(",", list);
        }

        public NNode? deserialize(string? data)
        {
            if (string.IsNullOrEmpty(data)) return null;

            var queue = new Queue<NNode>();
            var values = data.Split(",");
            var root = new NNode(int.Parse(values[0]));
            queue.Enqueue(root);
            for (int i = 1; i < values.Length; i += 2)
            {
                var node = queue.Dequeue();
                var left = values[i] == "null" ? null : values[i];
                if (left != null)
                {
                    node.left = new NNode(int.Parse(values[i]));
                    queue.Enqueue(node.left);
                }

                var right = values[i + 1] == "null" ? null : values[i + 1];
                if (right != null)
                {
                    node.right = new NNode(int.Parse(values[i + 1]));
                    queue.Enqueue(node.right);    
                }
            }

            return root;
        }
    }
}