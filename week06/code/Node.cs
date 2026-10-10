public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    /// <summary>
    /// Problem 1: Insert Unique Values Only
    /// Updates the tree to insert unique values only.
    /// Time Complexity: Average O(log n), Worst O(n)
    /// </summary>
    public void Insert(int value)
    {
        if (value == Data)
        {
            // Do nothing if the value is a duplicate
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    /// <summary>
    /// Problem 2: Contains
    /// Recursively checks if a value exists in the subtree rooted at this node.
    /// Time Complexity: Average O(log n), Worst O(n)
    /// </summary>
    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        else
        {
            return Right != null && Right.Contains(value);
        }
    }

    /// <summary>
    /// Problem 4: Tree Height
    /// Calculates height recursively: 1 + max(left height, right height).
    /// Time Complexity: O(n) where n is the number of nodes in the subtree.
    /// </summary>
    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}