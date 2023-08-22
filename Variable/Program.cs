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
            float weight = 79;
            bool isChild = (height < 150 || weight < 40);
            string info = $"Name: {firstName} + \n Last name:  {lastName} \nHeight: {height} \nWeight: {weight} \nIs child: {isChild}";
            Console.WriteLine(info);

            height = 100;
            isChild = (height < 150 || weight < 40);
            info = $"Name: {firstName} + \n Last name:  {lastName} \nHeight: {height} \nWeight: {weight} \nIs child: {isChild}";
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}