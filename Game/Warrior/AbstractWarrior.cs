using Game.Randomize;
using Game.Weapon;

namespace Game.Warrior;

public abstract class AbstractWarrior : IWarrior
{
    public int Accuracy { get; protected set; }
    public static int MaxHP { get; protected set; }
    public int HP { get; protected set; }
    public AbstractWeapon Weapon { get; protected set; }
    public bool IsKilled { get; protected set; }
    public int DodgeChance { get; protected set; }

    public AbstractWarrior(int maxHP, AbstractWeapon weapon, int dodgeChance, int accuracy)
    {
        MaxHP = maxHP;
        HP = MaxHP;
        Weapon = weapon;
        DodgeChance = dodgeChance;
        Accuracy = accuracy;
        IsKilled = false;
        Weapon.FillFullMagazine();
    }

    public void Attack(IWarrior warrior)
    {
        var shootAmmo = Weapon.ShootAmmo();
        if (Weapon.AmmoMagazineEmpty)
        {
            Weapon.FillFullMagazine();
            return;
        }
        for (int i = 0; i < shootAmmo.Length; i++)
        {
            int damage = shootAmmo[i].Damage();
            if (Accuracy.Chance() && !warrior.DodgeChance.Chance())
                warrior.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        if (!IsKilled)
            HP -= damage;
        if (HP <= 0)
        {
            IsKilled = true;
            HP = 0;
        }
    }
}
