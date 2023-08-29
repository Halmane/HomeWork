using Game.FireTypes;
namespace Game.Weapon;
public class Pistol : AbstractWeapon
{
    public Pistol()
        : base(20, new SingleShot(), new Ammo(25, 40, 2)) { }
}
