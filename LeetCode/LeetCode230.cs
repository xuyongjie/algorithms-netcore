using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    //中根遍历BFS二叉查找树就是有序列表
    class LeetCode230
    {
        List<TreeNode> sortedNodes;
        public int KthSmallest(TreeNode root, int k)
        {
            sortedNodes=new List<TreeNode>();
            Recursive(root);
            return sortedNodes[k-1].val;
        }


        //中根遍历
        private void Recursive(TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            Recursive(root.left);
            sortedNodes.Add(root);
            Recursive(root.right);
        }
    }
}