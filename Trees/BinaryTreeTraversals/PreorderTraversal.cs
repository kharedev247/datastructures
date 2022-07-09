namespace Trees;
public class PreorderTraversal
{
    public static void Preorder(Node root)
    {
        if (root == null)
        {
            return;
        }
        System.Console.Write(root.Data);
        Preorder(root.Left);
        Preorder(root.Right);
    }
}
