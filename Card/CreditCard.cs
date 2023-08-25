namespace Card;

internal class CreditCard : BankCard
{
    protected double _balance;
    protected const double CreditLimit = 10000;
    protected double _creditBalance = 10000;
    public override double Balance
    {
        get { return _balance; }
        protected set { _balance = value; }
    }

    public override void AddMoney(double money)
    {
        if (_creditBalance >= CreditLimit)
        {
            Balance += money;
            return;
        }
        if (_creditBalance + money >= CreditLimit)
        {
            Balance += (_creditBalance + money - CreditLimit);
            _creditBalance = CreditLimit;
            return;
        }
        _creditBalance += money;
    }

    public override bool Pay(double money)
    {
        if (Balance - money >= 0)
        {
            Balance -= money;
            return true;
        }
        else if (_creditBalance + (Balance - money) >= 0)
        {
            _creditBalance += Balance - money;
            Balance = 0;
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
        Console.WriteLine($"Balance: {Balance}");
    }

    public override void AllInfo()
    {
        BalanceInfo();
        Console.WriteLine($"Credit balance: {_creditBalance}");
    }
}
