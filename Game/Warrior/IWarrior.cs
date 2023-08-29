namespace Game.Warrior;

public interface IWarrior
{
    bool IsKilled { get; }
    int DodgeChance { get; }

    void Attack(IWarrior warrior);
    void TakeDamage(int damage);
}
