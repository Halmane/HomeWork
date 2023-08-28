using static System.Net.Mime.MediaTypeNames;

namespace Game;
public class Weapons
{
    public AbstractWeapon CreatePistol()
    {
        return new AbstractWeapon(20, new SingleShot(), new Ammo(10,40,2));
    }
    public AbstractWeapon CreateSubmachineGun()
    {
        return new AbstractWeapon(40, new BurstShoot(5), new Ammo(5, 60, 2));
    }
    public AbstractWeapon CreateShotgun()
    {
        return new AbstractWeapon(8, new SingleShot(), new Ammo(40, 50, 2));
    }
    public AbstractWeapon CreateGrenadeLauncher()
    {
        return new AbstractWeapon(2, new SingleShot(), new Ammo(80, 80, 3));
    }
}
