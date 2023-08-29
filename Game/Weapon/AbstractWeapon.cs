using Game.FireTypes;

namespace Game.Weapon;

public abstract class AbstractWeapon
{
    private static Ammo _ammo;
    private int _maxAmmo;
    public bool AmmoMagazineEmpty = true;
    public FireType FireType { get; private set; }
    public Stack<Ammo> AmmoStack { get; private set; }


    public AbstractWeapon(int maxAmmo, FireType fireType, Ammo ammo)
    {
        _maxAmmo = maxAmmo;
        FireType = fireType;
        _ammo = ammo;
    }


    private void _addAmmo()
    {
        AmmoStack.Push(_ammo);
    }

    public void FillFullMagazin()
    {
        AmmoStack = new Stack<Ammo>();
        for (int i = 0; i < _maxAmmo; i++)
        {
            _addAmmo();
        }
        AmmoMagazineEmpty = false;
    }

    public Stack<Ammo> ShootAmmo()
    {
        var shootAmmo = new Stack<Ammo>();
        if (AmmoStack.Count < FireType.AmmoCount)
        {
            AmmoMagazineEmpty = true;
        }
        for (int i = 0; i < FireType.AmmoCount; i++)
        {
            var temp = AmmoStack.Pop();
            shootAmmo.Push(temp);
        }
        return shootAmmo;
    }
}
