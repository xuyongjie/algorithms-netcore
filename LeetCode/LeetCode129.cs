using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    //AC
    public class LeetCode129
    {
        private Dictionary<TreeNode,TreeNode> parents;
        private Dictionary<TreeNode,int> valueRecord;
        private int result;
        public int SumNumbers(TreeNode root)
        {
            parents=new Dictionary<TreeNode,TreeNode>();
            valueRecord=new Dictionary<TreeNode,int>();
            result=0;
            Traverse(null,root);
            return result;
        }

        private void Traverse(TreeNode parent,TreeNode root)
        {
            if(root!=null)
            {
                parents.Add(root,parent);
                valueRecord.Add(root,parent==null?root.val:(valueRecord[parent]*10+root.val));
                if(root.left==null&&root.right==null)
                {
                    result+=valueRecord[root];
                }
                Traverse(root,root.left);
                Traverse(root,root.right);
            }
        }

    }
}