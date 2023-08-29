using Game.Weapon;

namespace Game.Warrior;

public class Soldier : AbstractWarrior
{
    public Soldier()
        : base(200, Weapons.CreateSubmachineGun(), 50, 50) { }
}
