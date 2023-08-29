using Game.Randomize;
using Game.Warrior;

namespace Game;

public class Team
{
    public List<AbstractWarrior> Warriors = new List<AbstractWarrior>();

    public Team()
    {
        for (int i = 0; i <= 4; i++)
        {
            if (20.Chance()) Warriors.Add(new General());
            else if (40.Chance()) Warriors.Add(new Captain());
            else Warriors.Add(new Soldier());
        }
    }

    public void WarriorIsDead(int i)
    {
        if (Warriors[i].IsKilled)
            Warriors.Remove(Warriors[i]);
    }
}
