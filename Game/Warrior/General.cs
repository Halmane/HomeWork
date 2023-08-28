using Game.Weapon;

namespace Game.Warrior;

public class General : AbstractWarrior
{
    public General()
        : base(400, Weapons.CreateShotgun(), 60, 80) { }
}
