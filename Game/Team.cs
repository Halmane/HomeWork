using Game.Randomize;
using Game.Warrior;

namespace Game;

public class Team
{
    public List<AbstractWarrior> Warriors { get; private set; }

    public Team(int size = 5)
    {
        Warriors = new List<AbstractWarrior>();
        for (int i = 0; i < size; i++)
        {
            if (20.Chance())
                Warriors.Add(new General());
            else if (40.Chance())
                Warriors.Add(new Captain());
            else
                Warriors.Add(new Soldier());
        }
    }

    public void ShuffleTeam()
    {
        Warriors = Warriors.OrderBy(x => Random.Shared.Next()).ToList();
    }


    public void RemoveWarrior(AbstractWarrior warrior)
    {
        Warriors.Remove(warrior);
    }
}
