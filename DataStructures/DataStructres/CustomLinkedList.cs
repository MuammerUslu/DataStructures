namespace DataStructure;

public class CustomLinkedList<T>
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

    private Node _head;
    private Node _tail;
    private int _count;

    public CustomLinkedList()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    public void AddFirst(T value)
    {
        Node newNode = new Node(value);

        if (_head == null)
        {
            _head = _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head = newNode;
        }

        _count++;
    }

    public void AddLast(T value)
    {
        Node newNode = new Node(value);

        if (_tail == null)
        {
            _head = _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }

        _count++;
    }

    public T RemoveFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        T value = _head.Value;
        _head = _head.Next;

        if (_head == null)
        {
            _tail = null;
        }

        _count--;
        return value;
    }

    public T RemoveLast()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        if (_head == _tail)
        {
            T value = _head.Value;
            _head = _tail = null;
            _count--;
            return value;
        }

        Node current = _head;
        while (current.Next != _tail)
        {
            current = current.Next;
        }

        T lastValue = _tail.Value;
        _tail = current;
        _tail.Next = null;

        _count--;
        return lastValue;
    }

    public Node Find(T value)
    {
        Node current = _head;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    public void PrintList()
    {
        Node current = _head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }

    public int Count => _count;
}