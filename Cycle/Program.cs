static int fib(int n)
{
    return n > 1 ? fib(n - 1) + fib(n - 2) : n;
}
