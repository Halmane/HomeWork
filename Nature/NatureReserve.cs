namespace Nature
{
    internal class NatureReserve
    {
        public List<Animal> Animals { get; private set; }

        public NatureReserve(List<Animal> animals)
        {
            Animals = animals;
        }

        public void Life(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Animals.Count; j++)
                {
                    DoRandomAction(Animals[j]);
                    if (Animals[j].IsTooOld)
                    {
                        Console.WriteLine($"{Animals[j].Name} is dead");
                        Animals.Remove(Animals[j]);
                        j--;
                    }
                }
                Thread.Sleep(3000);
            }
        }

        public void DoRandomAction(Animal animal)
        {
            int i = Random.Shared.Next(1, 100);
            if (i < 5)
                Animals.Add(animal.Birth(animal));
            else if (i < 35)
                animal.Sleep();
            else if (i < 85)
                animal.Eat();
            else
                animal.Move();
        }
    }
}
