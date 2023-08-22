using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Vladimir";
            string lastName = "Durmanov";
            double height = 170;
            height = 100;
            float weight = 79;
            bool isChild = (height < 150 || weight < 40);
            string info = "Name: " + firstName + "\nLast name: " + lastName + "\nHeight: " + height + "\nWeight: " + weight + "\nIs child: " + isChild;
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
