namespace Game;

public interface IWarrior
{
    public bool IsKilled { get; set; }
    public int DodgeChance { get; set; }

    public void Atack(IWarrior warrior);
    public void TakeDamage(int damage);
}
