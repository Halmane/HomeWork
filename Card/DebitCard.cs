namespace Card;

internal class DebitCard : BankCard
{
    protected double balance;
    public override double _balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public override void AddMoney(double money)
    {
        _balance += money;
    }

    public override bool Pay(double money)
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
        BalanceInfo();
    }
}
