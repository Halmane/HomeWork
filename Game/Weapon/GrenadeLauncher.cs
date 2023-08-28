using Game.TypeOfFire;

namespace Game.Weapon;
public class GrenadeLauncher : AbstractWeapon
{
    public GrenadeLauncher() : base(2, new SingleShot(), new Ammo(80, 80, 3))
    {
    }
}
