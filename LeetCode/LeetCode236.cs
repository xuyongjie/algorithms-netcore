using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    /*
    Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

    According to the definition of LCA on Wikipedia: 
    “The lowest common ancestor is defined between two nodes v and w as the lowest node in T 
    that has both v and w as descendants (where we allow a node to be a descendant of itself).”

         _______3______
        /              \
      ___5__          ___1__
     /      \        /      \
     6      _2       0       8
           /  \
           7   4
    For example, the lowest common ancestor (LCA) of nodes 5 and 1 is 3. 
    Another example is LCA of nodes 5 and 4 is 5, 
    since a node can be a descendant of itself according to the LCA definition.
    */
    class LeetCode236
    {

        Dictionary<TreeNode,TreeNode> parent;
        Dictionary<TreeNode,int> level;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            parent=new Dictionary<TreeNode,TreeNode>();
            level=new Dictionary<TreeNode,int>();
            Traverse(null,0,root);
            return FindCommonAncestor(root,p,q);
        }

        private TreeNode FindCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if(p==q)
            {
                return p;
            }
            if(level[p]>level[q])
            {
                return FindCommonAncestor(root,parent[p],q);
            }else{
                return FindCommonAncestor(root,p,parent[q]);                
            }
        }

        private void Traverse(TreeNode p,int l,TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            parent.Add(root,p);
            level.Add(root,l);
            Traverse(root,l+1,root.left);
            Traverse(root,l+1,root.right);
        }
    }
}