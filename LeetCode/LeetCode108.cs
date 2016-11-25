//Definition for a binary tree node.
namespace Algorithmsnetcore.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    //选择中间的点作为根节点，递归构造两边的元素作为左右孩子节点
    public class LeetCode108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return DoSort(nums, 0, nums.Length - 1);
        }

        private TreeNode DoSort(int[] nums, int from, int to)
        {
            if (to < from)
            {
                return null;
            }
            int middle = (from + to) / 2;
            TreeNode node = new TreeNode(nums[middle]);
            if (from == to)
            {
                return node;
            }
            node.left = DoSort(nums, from, middle - 1);
            node.right = DoSort(nums, middle + 1, to);
            return node;
        }
    }
}
