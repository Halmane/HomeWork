using Game.Weapon;

namespace Game.Warrior;

internal class Soldier : AbstractWarrior
{
    public Soldier()
        : base(200, Weapons.CreateSubmachineGun(), 50, 50) { }
}
