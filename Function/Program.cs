static (string firstHalf, string secondHalf) Split(string s)
{
    return (s.Substring(0, s.Length / 2), s.Substring(s.Length / 2));
}

static string Shift(string s, Func<char, char> expression)
{
    string newString = "";
    foreach (char c in s) newString += expression(c);
    return newString;
}
static string DecryptFirstHalf(string firstHalf)
{
    firstHalf = Shift(firstHalf, (x) => (char)(x + 1));
    firstHalf = firstHalf.Replace('5', 's').Replace('4', 'u');
    firstHalf = Shift(firstHalf, (x) => (char)(x - 3));
    firstHalf = firstHalf.Replace('0', 'o');
    return firstHalf;
}

static string DecryptSecondHalf(string secondHalf)
{
    secondHalf = new string(secondHalf.Reverse().ToArray());
    secondHalf = Shift(secondHalf, (x) => (char)(x - 4));
    secondHalf = secondHalf.Replace('_', ' ');
    return secondHalf;
}


string text = "F2p)v\"y233{0->c}ttelciFc";
var splitText = Split(text);
splitText.firstHalf = DecryptFirstHalf(splitText.firstHalf);
splitText.secondHalf = DecryptSecondHalf(splitText.secondHalf);
Console.WriteLine(splitText.firstHalf + splitText.secondHalf);
Console.ReadLine();


