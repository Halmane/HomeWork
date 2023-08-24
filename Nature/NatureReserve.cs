namespace Nature
{
    internal class NatureReserve
    {
        private List<Animal> _animals;
        public NatureReserve(List<Animal> animals)
        {
            _animals = animals;
        }

        public void Life(int N)
        {
            for(int i = 0;i < N; i++) 
            {
                for(int j = 0;j < _animals.Count; j++)
                {
                    DoRandomAction(_animals[j]);
                    if(_animals[j].IsTooOld)
                    {
                        _animals.Remove(_animals[j]);
                        j--;
                    }
                }
            }
        }
        public void DoRandomAction(Animal animal)
        {
            int i = Random.Shared.Next(1, 100);
            if (i < 5) _animals.Add(animal.Birth(animal));
            else if (i < 35) animal.Sleep();
            else if (i < 85) animal.Eat();
            else animal.Move();
        }
    }
}
