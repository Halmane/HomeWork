using Game.Randomize;
using Game.TypeOfFire;
using Game.Weapon;

namespace Game.Warrior;

public abstract class AbstractWarrior : IWarrior
{
    public int Accuracy { get; protected set; }
    public static int MaxHP { get; protected set; }
    public int _hP = MaxHP;
    public AbstractWeapon Weapon { get; protected set; }
    public bool IsKilled { get; set; }
    public int DodgeChance { get; set; }

    public AbstractWarrior(int maxHP, AbstractWeapon weapon, int dodgeChance, int accuracy)
    {
        MaxHP = maxHP;
        Weapon = weapon;
        DodgeChance = dodgeChance;
        Accuracy = accuracy;
        IsKilled = false;
    }

    public void Atack(IWarrior warrior)
    {
        if (Weapon.AmmoMagazineEmpty)
        {
            Weapon.FillFullMagazin();
            return;
        }
        Weapon.FillFullMagazin();
        for (int i = 0; i < Weapon.FireType._ammoCount; i++)
        {
            warrior.TakeDamage(Accuracy.Chance() && !warrior.DodgeChance.Chance() ? Weapon.ShootAmmo().Pop().Damage() : 0);
        }
    }

    public void TakeDamage(int damage)
    {
        _hP -= damage;
        if (_hP <= 0) IsKilled = true;
    }
}
