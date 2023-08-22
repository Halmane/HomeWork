static (string firstHalf, string secondHalf) Split(string s)
{
    return (s.Substring(0, s.Length / 2), s.Substring(s.Length / 2));
}

static string Shift(string s, Expression expression)
{
    string newString = "";
    foreach (char c in s) newString += expression(c);
    return newString;
}
static string decryptFirstHalf(string firstHalf)
{
    firstHalf = Shift(firstHalf, (char x) => (char)(x + 1));
    firstHalf = firstHalf.Replace('5', 's').Replace('4', 'u');
    firstHalf = Shift(firstHalf, (char x) => (char)(x - 3));
    firstHalf = firstHalf.Replace('0', 'o');
    return firstHalf;
}

static string decryptSecondHalf(string secondHalf)
{
    string reverse = "";
    for (int i = secondHalf.Length - 1; i > -1; i--)
    {
        reverse += secondHalf[i];
    }
    secondHalf = reverse;
    secondHalf = Shift(secondHalf, (char x) => (char)(x - 4));
    secondHalf = secondHalf.Replace('_', ' ');
    return secondHalf;
}


string text = "F2p)v\"y233{0->c}ttelciFc";
var splitText = Split(text);
splitText.firstHalf = decryptFirstHalf(splitText.firstHalf);
splitText.secondHalf = decryptSecondHalf(splitText.secondHalf);
Console.WriteLine(splitText.firstHalf + splitText.secondHalf);
Console.ReadLine();

delegate char Expression(char x);
