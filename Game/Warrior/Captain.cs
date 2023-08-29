using Game.Weapon;

namespace Game.Warrior;

public class Captain : AbstractWarrior
{
    public Captain()
        : base(350, Weapons.CreateGrenadeLauncher(), 45, 65) { }
}
