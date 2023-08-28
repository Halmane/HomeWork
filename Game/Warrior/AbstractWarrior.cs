using Game.Randomize;
using Game.Weapon;

namespace Game.Warrior;

public abstract class AbstractWarrior : IWarrior
{
    private int _accuracy;
    private static int _maxHP;
    private int _hP = _maxHP;
    private AbstractWeapon _weapon;
    public bool IsKilled { get; set; }
    public int DodgeChance { get; set; }

    public void Atack(IWarrior warrior)
    {
        if (_weapon.AmmoMagazineEmpty)
        {
            _weapon.FillFullMagazin();
            return;
        }
        _weapon.FillFullMagazin();
        for (int i = 0; i < _weapon.FireType._ammoCount; i++)
        {
            warrior.TakeDamage(_accuracy.Chance() && !warrior.DodgeChance.Chance() ? _weapon.ShootAmmo().Pop().Damage() : 0);
        }
    }

    public void TakeDamage(int damage)
    {
        _hP -= damage;
        if (_hP <= 0) IsKilled = false;
    }
}
