using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    /// <summary>
    /// 递归左右子树，只要左右子树存在从根到叶子节点的和等于sum减去该节点的val就存在，返回true
    /// </summary>
    class LeetCode112
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if(root==null)
            {
                return false;
            }
            if(root.left==null&&root.right==null)
            {
                return sum == root.val;
            }
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
