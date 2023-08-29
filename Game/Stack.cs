namespace Game;

public class Stack<T>
    where T : class
{
    private class StackElement<T>
        where T : class
    {
        public StackElement<T>? Previous { get; set; }
        public T Value { get; set; }
    }

    private StackElement<T> _item;
    public int Count { get; private set; }

    public Stack()
    {
        Count = 0;
    }

    public void Push(T item)
    {
        Count++;
        _item = new StackElement<T>() { Previous = _item, Value = item };
    }

    public T? Pop()
    {
        if (IsEmpty())
            return null;
        var pop = _item.Value;
        _item = _item.Previous;
        Count--;
        return pop;
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }
}
