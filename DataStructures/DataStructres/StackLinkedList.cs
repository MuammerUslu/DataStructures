namespace DataStructure;

public class StackLinkedList<T>
{
    public class Node
    {
        public T Value;
        public Node Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node _top;
    private int _count;

    public bool IsEmpty => _top == null;
    public int Count => _count;

    public StackLinkedList()
    {
        _top = null;
        _count = 0;
    }

    public void Push(T value)
    {
        Node newNode = new Node(value);
        newNode.Next = _top;
        _top = newNode;
        _count++;
    }

    public T Pop()
    {
        if (_top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T value = _top.Value;
        _top = _top.Next;
        _count--;
        return value;
    }

    public T Peek()
    {
        if (_top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return _top.Value;
    }
}