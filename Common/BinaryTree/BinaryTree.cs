using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.BinaryTree
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BinaryTree
    {
        private List<int> results;
        public IList<int> PostorderTraversal(TreeNode root)
        {
            results = new List<int>();
            LaterRecursive(root);
            return results;
        }

        /// <summary>
        /// 先根递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void PreRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            results.Add(root.val);
            PreRecursive(root.left);
            PreRecursive(root.right);
        }

        /// <summary>
        /// 中根递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void MiddleRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            MiddleRecursive(root.left);
            results.Add(root.val);
            MiddleRecursive(root.right);
        }

        /// <summary>
        /// 后根递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void LaterRecursive(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            LaterRecursive(root.left);
            LaterRecursive(root.right);
            results.Add(root.val);
        }

        /// <summary>
        /// 后根非递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void LaterNotRecursive(TreeNode root)
        {
            TreeNode temp = root, pre = null;
            Stack<TreeNode> tempStack = new Stack<TreeNode>();
            tempStack.Push(temp);
            while (tempStack.Count > 0)
            {
                TreeNode cur = tempStack.Peek();
                //左右节点都为空，则访问该节点
                //左节点不为空右节点为空且上次访问的节点等于左节点
                //左节点为空右节点不为空且上次访问的节点等于右节点
                //左右节点都不为空且上次访问的节点为右节点
                //以上情况则访问该节点，否则右节点入栈，左节点入栈
                if ((cur.left == null && cur.right == null) ||
                    cur.left != null && cur.right == null && pre == cur.left ||
                    cur.left == null && cur.right != null && pre == cur.right ||
                    cur.left != null && cur.right != null && pre == cur.right)
                {
                    results.Add(cur.val);
                    tempStack.Pop();
                    pre = cur;
                }
                else
                {
                    if (cur.right != null)
                    {
                        tempStack.Push(cur.right);
                    }
                    if (cur.left != null)
                    {
                        tempStack.Push(cur.left);
                    }
                }
            }
        }

        /// <summary>
        /// 先根非递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void PreNotRecursive(TreeNode root)
        {
            TreeNode head = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (head != null || stack.Count > 0)
            {
                while (head != null)
                {
                    results.Add(head.val);
                    stack.Push(head);
                    head = head.left;
                }
                if (stack.Count > 0)
                {
                    TreeNode cur = stack.Pop();
                    head = cur.right;
                }
            }
        }

        /// <summary>
        /// 中根非递归遍历
        /// </summary>
        /// <param name="root"></param>
        private void MiddleNotRecursive(TreeNode root)
        {
            TreeNode head = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (head != null || stack.Count > 0)
            {
                while (head != null)
                {
                    stack.Push(head);
                    head = head.left;
                }
                if (stack.Count > 0)
                {
                    TreeNode cur = stack.Pop();
                    results.Add(cur.val);
                    head = cur.right;
                }
            }
        }
    }
}
