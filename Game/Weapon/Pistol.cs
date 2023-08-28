namespace Game.Weapon;
public class Pistol : AbstractWeapon
{
    public Pistol()
        : base(20, new SingleShot(), new Ammo(10, 40, 2)) { }
}
