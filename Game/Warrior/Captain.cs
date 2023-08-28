using Game.Weapon;

namespace Game.Warrior;

internal class Captain : AbstractWarrior
{
    public Captain()
        : base(350, Weapons.CreateGrenadeLauncher(), 45, 65) { }
}
