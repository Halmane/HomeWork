namespace Card;

abstract class BankCard
{
    public abstract int _balance { get; protected set; }

    public abstract void AddMoney(int money);
    public abstract bool Pay(int money);

    public abstract void BalanceInfo();

    public abstract void AllInfo();
}
