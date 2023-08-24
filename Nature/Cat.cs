using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature
{
    internal class Cat : Animal
    {
        public Cat(int energy, int weight, int currentAge, int maximumAge, string name)
        : base(energy, weight, currentAge, maximumAge, name) { }

        public Cat()
            : base() { }

        public override bool Move()
        {
            if (base.Move())
            {
                Console.WriteLine($"{Name} is tigidig.");
                return true;
            }
            return false;
        }

        public override Animal Birth(Animal mother)
        {
            var animal = new Cat(
                Random.Shared.Next(10, 15),
                Random.Shared.Next(1, 2),
                1,
                mother.MaximumAge,
                mother.Name
            );
            Console.WriteLine("A new cat was born!");
            animal.Info();
            return animal;
        }
    }
}
