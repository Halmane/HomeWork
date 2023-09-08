var cancellationTokenSoource = new CancellationTokenSource(); ;
var token = cancellationTokenSoource.Token;
var first = SlowPrint(token);
var second = SlowPrint(token);
var result = await (await Task.WhenAny(first, second));
Console.WriteLine(result);
cancellationTokenSoource.Cancel();
await Task.Delay(Timeout.Infinite);







async Task<String> SlowPrint(CancellationToken cancellationToken)
{
    await Task.Delay(Random.Shared.Next(1000,3000));
    if (cancellationToken.IsCancellationRequested)
    {
        Console.WriteLine("Lupa");
        return string.Empty;
    }  
    else
        return "Pupa";
}