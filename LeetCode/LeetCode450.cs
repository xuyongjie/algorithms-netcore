
namespace Algorithmsnetcore.LeetCode{
    public class NeedDelete{
      public TreeNode itself;
      public TreeNode parent;
      public int leftOrRight;//0 left,1 right
  }
 
 //将被删除节点的右子树连到被删除节点左子树的最右端
 //然后将该子树接到被删除节点父节点的左端或右端（视被删除节点属于父节点的左右节点而定）
public class LeetCode450 {
    public TreeNode DeleteNode(TreeNode root, int key) {
        NeedDelete delete=findNode(root,key,null,0);
        TreeNode deleteNode=delete.itself;
        TreeNode deleteNodeParent=delete.parent;
        int leftOrRight=delete.leftOrRight;
        if(deleteNode==null)
        {
            return root;
        }
        TreeNode subRoot=deleteNode.left;
        if(subRoot==null)
        {
            subRoot=deleteNode.right;
            if(deleteNodeParent==null)
            {
                return subRoot;
            }else{
                if(leftOrRight==0)
                {
                    deleteNodeParent.left=subRoot;
                }else{
                    deleteNodeParent.right=subRoot;
                }
                return root;
            }
        }else{
            while(subRoot.right!=null)
            {
                subRoot=subRoot.right;
            }
            subRoot.right=deleteNode.right;

            if(deleteNodeParent==null)
            {
                return deleteNode.left;
            }else{
                if(leftOrRight==0)
                {
                    deleteNodeParent.left=deleteNode.left;
                }else{
                    deleteNodeParent.right=deleteNode.left;
                }
                return root;
            }
        }
    }

    private NeedDelete findNode(TreeNode root,int key,TreeNode parent,int LOrR)
    {
        if(root==null)
        {
            return new NeedDelete{
                itself=null,
                parent=null,
                leftOrRight=0
            };
        }else{
            if(root.val==key)
            {
                return new NeedDelete{
                    itself=root,
                    parent=parent,
                    leftOrRight=LOrR
                };
            }else if(key<root.val)
            {
                return findNode(root.left,key,root,0);
            }else{
                return findNode(root.right,key,root,1);
            }
        }
    }
}
}


  