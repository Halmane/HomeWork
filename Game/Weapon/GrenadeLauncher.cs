using Game.FireTypes;

namespace Game.Weapon;
public class GrenadeLauncher : AbstractWeapon
{
    public GrenadeLauncher() : base(2, new SingleShot(), new Ammo(100, 80, 3))
    {
    }
}
