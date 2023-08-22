using System.Globalization;


List<string>  FillListOfNumber(int count)
{
    var contacts = new List<string>();
    for(int i = 0; i < count; i++)
    {
        contacts.Add(FillNumber());
    }
    return contacts;
}

List<string> SortListOfNumber(List<string> contacts)
{
    return contacts.Where(contact => contact.Length == 12 && contact.StartsWith("+7")).ToList();
}

Dictionary<string,string> FillDictionary(HashSet<string> contact)
{
    var contacts = new Dictionary<string, string>();
    foreach (string i in contact)
    {
        contacts.Add(i,FillName(i));
    }
    return contacts;
}
string FillNumber()
{
    var number = string.Empty;
    Console.WriteLine("Enter the number:");
    number = Console.ReadLine();
    
    return number;
}
string FillName(string number)
{
    var name = string.Empty;
    var textInfo = new CultureInfo("en-US", false).TextInfo;
    Console.WriteLine($"Enter the name for {number}:");
    name = textInfo.ToTitleCase(Console.ReadLine());
    return name;
}

int count = 0;
do
{
    count = int.Parse(Console.ReadLine());
} while (count <= 0);

var contact = SortListOfNumber(FillListOfNumber(count)).ToHashSet();
foreach (string i in contact)
{
    Console.WriteLine(i);
}

Console.WriteLine(contact.Sum(c => c.Length));
var contacts = FillDictionary(contact);
var sortContacts = contacts.OrderBy(x => x.Value);
foreach (var с in sortContacts)
{
    Console.WriteLine($"Contact: {с.Value}  Number: {с.Key}");
}
sortContacts = contacts.OrderBy(x => x.Key);
foreach (var с in sortContacts)
{
    Console.WriteLine($"Contact: {с.Value}  Number: {с.Key}");
}