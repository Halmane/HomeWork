using Game.FireTypes;

namespace Game.Weapon;

public abstract class AbstractWeapon
{
    private Ammo _ammo;
    private int _maxAmmo;

    public bool AmmoMagazineEmpty { get; private set; }
    public FireType FireType { get; private set; }
    public Stack<Ammo> AmmoStack { get; private set; }


    public AbstractWeapon(int maxAmmo, FireType fireType, Ammo ammo)
    {
        _maxAmmo = maxAmmo;
        FireType = fireType;
        _ammo = ammo;
        AmmoMagazineEmpty = true;
    }


    private void AddAmmo()
    {
        AmmoStack.Push(_ammo);
    }

    public void FillFullMagazin()
    {
        AmmoStack = new Stack<Ammo>();
        for (int i = 0; i < _maxAmmo; i++)
        {
            AddAmmo();
        }
        AmmoMagazineEmpty = false;
    }

    public Ammo[] ShootAmmo()
    {
        Ammo[] shootAmmo = new Ammo[FireType.AmmoCount];
        if (AmmoStack.Count < FireType.AmmoCount)
        {
            AmmoMagazineEmpty = true;
            return shootAmmo;
        }
        for (int i = 0; i < FireType.AmmoCount; i++)
        {
            var temp = AmmoStack.Pop();
            shootAmmo[i] = temp;
        }
        return shootAmmo;
    }
}
