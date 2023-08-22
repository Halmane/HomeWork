static long Fib(long n)
{
    return n > 1 ? Fib(n - 1) + Fib(n - 2) : n;
}

static long FibFor(long n)
{
    if(n == 1 || n == 2) return 1;
    long first = 1; long second = 1;
    for(long i = 2; i < n; i++)
    {
        long f = first;
        first = second;
        second += f;
    }
    return second;
}


long n = 0;
do
{
    Console.WriteLine("Введите число больше 0:");
    n = long.Parse(Console.ReadLine());
} while (n <= 0);

Console.WriteLine(FibFor(n));
