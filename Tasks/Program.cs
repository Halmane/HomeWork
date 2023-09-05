await foreach(int i in AsyncInt())
{
    Console.WriteLine(i);
}

async IAsyncEnumerable<int> AsyncInt()
{
    for(int i = 0; i < 10; i++)
    {
        await Task.Delay(1000);
        yield return i;
    }
}
