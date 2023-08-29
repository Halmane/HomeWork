using Game.FireTypes;

namespace Game.Weapon;

public class SubmachineGun : AbstractWeapon
{
    public SubmachineGun()
        : base(40, new BurstShoot(5), new Ammo(15, 20, 2)) { }
}
