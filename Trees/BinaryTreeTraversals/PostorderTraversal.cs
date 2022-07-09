namespace Trees;

public class PostorderTraversal
{
    public static void Postorder(Node root)
    {
        if (root == null)
        {
            return;
        }
        Postorder(root.Left);
        Postorder(root.Right);
        System.Console.Write(root.Data);
    }
}