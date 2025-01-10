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
            Resize();
            
        _array[_tail] = t;
        _tail++;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
            throw new InvalidOperationException("Queue is empty!");
        
        T t = _array[_head];
        _head = (_head + 1) % _array.Length;
        _count--;
        
        return t;
    }

    private void Resize()
    {
        T[] arrayCopy = new T[_array.Length * 2];
        Array.Copy(_array,arrayCopy,_count);
        _array = arrayCopy;
    }
}