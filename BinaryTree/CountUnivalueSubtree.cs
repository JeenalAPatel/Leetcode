namespace LeetCode.BinaryTree
{
    public class CountUnivalueSubtree
    {
        public NNode Root;
        public int count;
        public int CountUnivalSubtrees(NNode? root)
        {
            if (root == null) return 0;
            is_uni(root);
            return count;
        }
        public bool is_uni(NNode? node)
        {
            
            if (node.left == null && node.right == null) 
            {

                count++;
                return true;   
            }

            bool is_unival = true;
            if (node.left != null) {
                is_unival = is_uni(node.left) && is_unival && node.left.val == node.val;
            }
            if (node.right != null) {
                is_unival = is_uni(node.right) && is_unival && node.right.val == node.val;
            }
            if (!is_unival) return false;
            count++;
            return true;
           
        }
        


    }
}