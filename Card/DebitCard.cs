namespace Card;

internal class DebitCard : BankCard
{
    private int balance;
    public override int _balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public override void AddMoney(int money)
    {
        _balance += money;
    }

    public override bool Pay(int money)
    {
        if (_balance - money >= 0)
        {
            _balance -= money;
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }

    public override void BalanceInfo()
    {
        Console.WriteLine($"Balance: {_balance}");
    }

    public override void AllInfo()
    {
        throw new NotImplementedException();
    }
}
