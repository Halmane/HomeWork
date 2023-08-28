namespace Game.Weapon;
public static class Weapons
{
    public static AbstractWeapon CreatePistol()
    {
        return new Pistol();
    }
    public static AbstractWeapon CreateSubmachineGun()
    {
        return new SubmachineGun();
    }
    public static AbstractWeapon CreateShotgun()
    {
        return new Shotgun();
    }
    public static AbstractWeapon CreateGrenadeLauncher()
    {
        return new GrenadeLauncher();
    }
}
