namespace Game.Warrior;

public interface IWarrior
{
    bool IsKilled { get; set; }
    int DodgeChance { get; set; }

    void Atack(IWarrior warrior);
    void TakeDamage(int damage);
}
