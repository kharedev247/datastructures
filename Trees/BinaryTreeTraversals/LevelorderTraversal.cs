using System.Collections;

namespace Trees;

public class LevelorderTraversal
{
    public static void Levelorder(Node root)
    {
        if (root is null) {
            return;
        }

        Queue queue = new();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while (queue.Count != 0)
        {
            if (queue.Dequeue() is not Node currNode)
            {
                System.Console.WriteLine("");
                if (queue.Count == 0)
                {
                    break;
                }
                else
                {
                    queue.Enqueue(null);
                }
            }
            else
            {
                System.Console.Write(currNode.Data);
                if (currNode.Left is not null)
                {
                    queue.Enqueue(currNode.Left);
                }
                if (currNode.Right is not null)
                {
                    queue.Enqueue(currNode.Right);
                }
            }
        }
    }
}