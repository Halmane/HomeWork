namespace Game;
public class Ammo
{
    private int _damage;
    private int _criticalDamageChance;
    private int _criticalDamage;

    public Ammo(int damage, int criticalDamageChance,int criticalDamage)
    {
        _damage = damage;
        _criticalDamageChance = criticalDamageChance;
        _criticalDamage = criticalDamage;
    }

    public int Damage()
    {
        return _criticalDamageChance.Chance()? _damage * _criticalDamage : _damage;
    }
}
