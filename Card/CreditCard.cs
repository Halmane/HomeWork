namespace Card;

internal class CreditCard : BankCard
{
    protected int balance;
    protected int _creditLimit = 10000;
    protected int _creditBalance = 10000;
    public override int _balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public override void AddMoney(int money)
    {
        if (_creditBalance < _creditLimit)
        {
            if (_creditBalance + money > _creditLimit)
            {
                _balance += (_creditBalance + money - _creditLimit);
                _creditBalance = _creditLimit;
            }
            else if (_creditBalance + money < _creditLimit)
                _creditBalance += money;
        }
        else
            _balance += money;
    }

    public override bool Pay(int money)
    {
        if (_balance - money >= 0)
        {
            _balance -= money;
            return true;
        }
        else if (_balance - money < 0 && _creditBalance + (_balance - money) >= 0)
        {
            _creditBalance += _balance - money;
            _balance = 0;
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
        Console.WriteLine($"Credit balance: {_creditBalance}");
    }
}
