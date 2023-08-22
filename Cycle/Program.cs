long Fib(long n)
{
    return n > 1 ? Fib(n - 1) + Fib(n - 2) : n;
}

static long FibFor(long number)
{
    if(number == 1 || number == 2) return 1;
    long first = 1;
    long second = 1;
    for(long i = 2; i < number; i++)
    {
        long f = first;
        first = second;
        second += f;
    }
    return second;
}


long number = 0;
do
{
    Console.WriteLine("Введите число больше 0:");
    number = long.Parse(Console.ReadLine());
} while (number <= 0);

Console.WriteLine(FibFor(number));

