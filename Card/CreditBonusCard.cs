namespace Card;

internal class CreditBonusCard : CreditCard
{
    private double _bonus;

    public override bool Pay(double money)
    {
        if (_bonus >= money)
        {
            _bonus -= money;
            return true;
        }
        else if (_bonus < money && StandartPay(money - _bonus))
        {
            _bonus = 0;
            return true;
        }
        return false;
    }
    private bool StandartPay(double money) 
    {
        if (Balance - money >= 0)
        {
            Balance -= money;
            GetBonus(money);
            return true;
        }
        else if (Balance - money < 0 && _creditBalance + (Balance - money) >= 0)
        {
            _creditBalance += Balance - money;
            Balance = 0;
            GetBonus(money);
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }
    private void GetBonus(double money)
    {
        _bonus += money * 0.0001;
        Console.WriteLine($"You will receive bonus: {money * 0.0001}");
    }

    public override void AllInfo()
    {
        BalanceInfo();
        Console.WriteLine($"Credit balance: {_creditBalance}");
        Console.WriteLine($"Bonus: {_bonus}");
    }
}
