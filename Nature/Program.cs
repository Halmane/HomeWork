using Nature;

var reserve = new NatureReserve(
    new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Bird(),
        new Bird(),
        new Bird(),
        new Bird(),
        new Bird(),
        new Fish(),
        new Fish(),
        new Fish(),
        new Dog(),
        new Dog()
    }
);


reserve.Life(200);

Console.WriteLine(reserve.Animals.Count);