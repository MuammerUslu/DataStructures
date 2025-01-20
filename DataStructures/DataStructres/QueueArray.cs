namespace DataStructure;

public class QueueArray<T>
{
    private T[] _array;
    private int _head;
    private int _tail;
    private int _count;
    
    public int Count => _count;

    public QueueArray(int initialCapacity)
    {
        _array = new T[initialCapacity];
        _head = 0;
        _tail = 0;
        _count = 0;
    }

    public void Enqueue(T t)
    {
        if (_count == _array.Length)
            ResizeCircular();

        _tail = (_tail + 1) % _array.Length;
        _array[_tail] = t;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
            throw new InvalidOperationException("Queue is empty!");
        
        T t = _array[_head];
        _array[_head] = default;
        _head = (_head + 1) % _array.Length;
        _count--;

        return t;
    }
    
    private void ResizeCircular()
    {
        int newCapacity = _array.Length * 2;
        T[] newQueue = new T[newCapacity];

        for (int i = 0; i < _count; i++)
        {
            newQueue[i] = _array[(_head + i) % _array.Length];
        }

        _array = newQueue;
        _head = 0;
        _tail = _count - 1;
    }
}