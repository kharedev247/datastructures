namespace Trees;

public class BinaryTree
{
    int index = -1;
    public Node BuildTree(int[] nodes)
    {
        index++;
        if (nodes[index] == -1)
        {
            return null;
        }

        Node newNode = new(nodes[index]);
        newNode.Left = BuildTree(nodes);
        newNode.Right = BuildTree(nodes);

        return newNode;
    }
}