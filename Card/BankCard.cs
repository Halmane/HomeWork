namespace Card;

public abstract class BankCard
{
    public abstract double Balance { get; protected set; }

    public abstract void AddMoney(double money);
    public abstract bool Pay(double money);
    public abstract void BalanceInfo();
    public abstract void AllInfo();
}
