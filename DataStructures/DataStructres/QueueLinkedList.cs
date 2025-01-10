namespace DataStructure;

public class QueueLinkedList<T>
{
    private class Node
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
    
    public int Count=> _count;

    public void Enqueue(T newItem)
    {
        Node newNode = new Node(newItem);

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
    
    public T Dequeue()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T value = _head.Value;
        _head = _head.Next;

        // Kuyrukta tek eleman kaldıysa, sonu null yapıyoruz
        if (_head == null)
        {
            _tail = null;
        }

        _count--;
        return value;
    }
    
    
}