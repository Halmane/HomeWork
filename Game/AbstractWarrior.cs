namespace Game;

internal class AbstractWarrior : IWarrior
{
    public bool IsKilled { get; set; }
    public int DodgeChance { get; set; }
    private int _accuracy;
    private static int _maxHP;
    private int _hP = _maxHP;
    private AbstractWeapon _weapon;

    public void Atack(IWarrior warrior)
    {
        if (_weapon.AmmoStack.IsEmpty())
        {
            _weapon.FillFullMagazin();
            return;
        }
        _weapon.FillFullMagazin();
        int damage = 0;
        for (int i = 0; i < _weapon.AmmoStack.Сount; i++)
        {
            warrior.TakeDamage(_accuracy.Chance() && !warrior.DodgeChance.Chance() ? _weapon.ShootAmmo().Pop().Damage(): 0);
        }


    }

    public void TakeDamage(int damage)
    {
        _hP -= damage;
        if (_hP <= 0) IsKilled = false;
    }
}
