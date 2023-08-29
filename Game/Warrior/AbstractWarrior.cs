using Game.Randomize;
using Game.FireTypes;
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
        Weapon.FillFullMagazin();
    }

    public void Atack(IWarrior warrior)
    {
        if (IsKilled) return;
        var shootAmmo = Weapon.ShootAmmo();
        if (Weapon.AmmoMagazineEmpty)
        {
            Weapon.FillFullMagazin();
            return;
        }
        for (int i = 0; i < Weapon.FireType.AmmoCount; i++)
        {
            int damage = shootAmmo.Pop().Damage();
            if (damage == 0)
            {
                Weapon.FillFullMagazin();
                return;
            }
            warrior.TakeDamage(
                Accuracy.Chance() && !warrior.DodgeChance.Chance()
                    ? damage
                    : 0
            );
        }
    }

    public void TakeDamage(int damage)
    {
        if (!IsKilled)
            _hP -= damage;
        if (_hP <= 0)
        {
            IsKilled = true;
            _hP = 0;
        }
            
    }
}
