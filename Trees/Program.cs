using System;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nodes = new int[] { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            BinaryTree bTree = new ();
            Node root = bTree.BuildTree(nodes);

            // PreorderTraversal.Preorder(root);

            // InoderTraversal.Inorder(root);

            // PostorderTraversal.Postorder(root);

            // LevelorderTraversal.Levelorder(root);
        }
    }
}
