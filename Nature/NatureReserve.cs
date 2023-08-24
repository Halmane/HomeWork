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
            int i = Random.Shared.Next(0,3);
            switch(i)
            {
                case 0:
                    animal.Eat();
                    break;
                case 1:
                    animal.Sleep();
                    break;
                case 2:
                    animal.Move();
                    break;
                case 3:
                    _animals.Add(animal.Birth(animal));
                    break;
            }
        }
    }
}
