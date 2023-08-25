namespace Card;

internal class CreditBonusCard : CreditCard
{
    private double _bonus;

    public override bool Pay(int money)
    {
        if (_balance - money >= 0)
        {
            _balance -= money;
            _getBonus(money);
            return true;
        }
        else if (_balance - money < 0 && _creditBalance + (_balance - money) >= 0)
        {
            _creditBalance += _balance - money;
            _balance = 0;
            _getBonus(money);
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }

    public bool BonusPay(int money)
    {
        if (_bonus >= money)
        {
            _bonus -= money;
            return true;
        }
        else if (_bonus < money && Pay((int)(money - _bonus)))
        {
            _bonus = 0;
            return true;
        }
        return false;
    }
    private void _getBonus(int money)
    {
        _bonus += (double)money * 0.0001;
    }

    public override void AllInfo()
    {
        BalanceInfo();
        Console.WriteLine($"Credit balance: {_creditBalance}");
        Console.WriteLine($"Bonus: {_bonus}");
    }
}
