using Nature;
using System.Xml.Linq;

var animals = new List<Animal>();
animals.Add(new Animal(10, 10, 64, 83, "Bob"));
animals[0].Birth(animals);
