namespace Game.Weapon;

public class SubmachineGun : AbstractWeapon
{
    public SubmachineGun()
        : base(40, new BurstShoot(5), new Ammo(5, 20, 2)) { }
}
