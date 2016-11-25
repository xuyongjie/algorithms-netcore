using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    /// <summary>
    /// leetcode112的进阶
    /// 递归遍历，同时用一个dictionary记录每个节点的父节点，待计算出的可行叶节点回溯使用
    /// </summary>
    class LeetCode113
    {

        private Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>();
        private IList<TreeNode> okLeafs = new List<TreeNode>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> results = new List<IList<int>>();
            if (root == null)
            {
                return results;
            }
            DoPathSum(null,root, sum);
            foreach(var item in okLeafs)
            {
                results.Add(Back(item));
            }
            return results;
        }

        private void DoPathSum(TreeNode parent,TreeNode root, int sum)
        {
            if (root == null)
            {
                return;
            }
            parents.Add(root, parent);
            if (root.left == null && root.right == null)
            {
                if(sum==root.val)
                {
                    okLeafs.Add(root);
                }
                return;
            }
            DoPathSum(root,root.left, sum - root.val);
            DoPathSum(root,root.right, sum - root.val);
        }

        private IList<int> Back(TreeNode leaf)
        {
            List<int> result = new List<int>();
            while(leaf!=null)
            {
                result.Insert(0, leaf.val);
                leaf = parents[leaf];
            }
            return result;
        }
    }
}
