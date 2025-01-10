namespace DataStructure;

public class StackArray<T>
{
    private T[] _array;
    private int _capacity;
    private int _count = 0;

    public int Count => _count;

    public StackArray(int initialCapacity)
    {   _array = new T[5];
        _capacity = initialCapacity;
    }

    private void Resize()
    {
        if (_count + 1 >= _capacity)
        {
            _capacity *= 2; 
            T[] copy = new T[_capacity];
            Array.Copy(_array,copy,_count);
            _array = copy;
        }
    }

    public void Push(T t)
    {
        Resize();
        _array[_count] = t;
        _count++;
    }
    
    public T Pop()
    {
        if (_count == 0)
            throw new InvalidOperationException("Stack is empty!");

        _count--;
        T item = _array[_count];
        return item;
    }
}
