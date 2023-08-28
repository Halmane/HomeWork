namespace Game;
public class Stack<T> where T : class
{
    private class StackElement<T> where T : class
    {
        public StackElement<T>? Previous { get; set; }
        public T Value { get; set; }
    }
    private StackElement<T> _item ;
    public int Сount = 0;

    public void Push(T item)
    {
        Сount++;
        _item = new StackElement<T>() { Previous = _item, Value = item } ;
    }

    public T? Pop() 
    {
        if (IsEmpty()) return null;
        var pop = _item.Value;
        _item = _item.Previous;
        Сount--;
        return pop;
    }

    public bool IsEmpty()
    {
        return Сount == 0;
    }
}
