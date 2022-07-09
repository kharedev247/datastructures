namespace Trees;

public class InoderTraversal
{
    public static void Inorder(Node root)
    {
        if (root == null)
        {
            return;
        }
        Inorder(root.Left);
        System.Console.Write(root.Data);
        Inorder(root.Right);
    }
}