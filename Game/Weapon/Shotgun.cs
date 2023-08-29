using Game.FireTypes;

namespace Game.Weapon;

public class Shotgun : AbstractWeapon
{
    public Shotgun()
        : base(8, new SingleShot(), new Ammo(80, 50, 2)) { }
}
