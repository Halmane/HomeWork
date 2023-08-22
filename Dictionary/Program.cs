using System.Collections.Generic;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<string, string> FillDictionary(int count)
{
    Dictionary<string,string> contacts = new Dictionary<string,string>();
    for(int i = 0; i < count; i++)
    {
        contacts.Add(FillNumber(), FillName());
    }
    return contacts;
}

string FillNumber()
{
    string number = string.Empty;
    do{ 
        Console.WriteLine("Enter the number:");
        number = Console.ReadLine();
    } while (number.Length != 12 && number.StartsWith("+7"));
    return number;
}
string FillName()
{
    string name = string.Empty;
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
    Console.WriteLine("Enter the name:");
    name = textInfo.ToTitleCase(Console.ReadLine());
    return name;
}

int count = 0;
do
{
    count = int.Parse(Console.ReadLine());
} while (count <= 0);

Dictionary<string,string> contacts = FillDictionary(count);


Console.WriteLine(contacts);