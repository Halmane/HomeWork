namespace Game;
internal class Stack<T> where T : class
{
    private List<T> items = new List<T>();
    public void Push(T item)
    {
        items.Add(item);
    }

    public T? Pop() 
    {
        if (IsEmpty()) return null;
        return items[items.Count - 1];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}
