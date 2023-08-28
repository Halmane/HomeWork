namespace Game;

public class AbstractWeapon
{
    private int _maxAmmo;
    public FireType FireType { get; private set; }
    public Stack<Ammo> AmmoStack { get; private set; }
    private bool _ammoMagazineEmpty = true;
    private static Ammo _ammo;

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
    }

    public Stack<Ammo> ShootAmmo()
    {
        var shootAmmo = new Stack<Ammo>();
        for(int i = 0; i < FireType._ammoCount; i++)
        {
            shootAmmo.Push(AmmoStack.Pop());
        }
        return shootAmmo;
    }
}
