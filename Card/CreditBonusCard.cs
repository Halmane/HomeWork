namespace Card;

internal class CreditBonusCard : CreditCard
{
    private double _bonus;

    public override bool Pay(double money)
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

    public bool BonusPay(double money)
    {
        if (_bonus >= money)
        {
            _bonus -= money;
            return true;
        }
        else if (_bonus < money && Pay(money - _bonus))
        {
            _bonus = 0;
            return true;
        }
        return false;
    }
    private void _getBonus(double money)
    {
        _bonus += money * 0.0001;
        Console.WriteLine($"You will receive bonus: {money * 0.005}");
    }

    public override void AllInfo()
    {
        BalanceInfo();
        Console.WriteLine($"Credit balance: {_creditBalance}");
        Console.WriteLine($"Bonus: {_bonus}");
    }
}
