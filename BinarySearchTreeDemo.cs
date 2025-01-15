using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class TreeNode
    {
        public int value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            this.value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinarySearchTree
    {
        public TreeNode Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public void insertNode(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                insert(Root, value);
            }
        }
        public void insert(TreeNode Root, int value)
        {
            if (value < Root.value)
            {
                if (Root.Left == null)
                {
                    Root.Left = new TreeNode(value);
                }
                else
                {
                    insert(Root.Left, value);
                }
            }
            else
            {
                if (Root.Right == null)
                {
                    Root.Right = new TreeNode(value);
                }
                else
                {
                    insert(Root.Right, value);
                }
            }
        }
        public void display(TreeNode node)
        {
            Console.WriteLine("*****INORDER TRAVERSAL*****");
            inorderTraversal(node);
            Console.WriteLine("\n*****PREORDER TRAVERSAL*****");
            preOrderTraversal(node);
            Console.WriteLine("\n*****POSTORDER TRAVERSAL*****");
            postOrderTraversal(node);

        }
        public void inorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                inorderTraversal(node.Left);
                Console.Write(node.value + " ");
                inorderTraversal(node.Right);
            }
        }
        public void preOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.value + " ");
                preOrderTraversal(node.Left);
                preOrderTraversal(node.Right);
            }
        }
        public void postOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                postOrderTraversal(node.Left);
                postOrderTraversal(node.Right);
                Console.Write(node.value + " ");
            }
        }
    }
    internal class BinarySearchTreeDemo
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.insertNode(10);
            bt.insertNode(2);
            bt.insertNode(32);
            bt.insertNode(34);
            bt.insertNode(5);
            bt.display(bt.Root);
            Console.ReadKey();
        }
    }
}
