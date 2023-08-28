namespace Game.Weapon;

public class Shotgun : AbstractWeapon
{
    public Shotgun()
        : base(8, new SingleShot(), new Ammo(40, 50, 2)) { }
}
