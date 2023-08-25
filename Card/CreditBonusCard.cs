namespace Card;

public class CreditBonusCard : CreditCard
{
    private double _bonusBalance;

    public override bool Pay(double money)
    {
        if (_bonusBalance >= money)
        {
            _bonusBalance -= money;
            return true;
        }
        else if (_bonusBalance < money && StandartPay(money - _bonusBalance))
        {
            _bonusBalance = 0;
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
        _bonusBalance += money * 0.0001;
        Console.WriteLine($"You will receive bonus: {money * 0.0001}");
    }

    public override void AllInfo()
    {
        BalanceInfo();
        Console.WriteLine($"Credit balance: {_creditBalance}");
        Console.WriteLine($"Bonus: {_bonusBalance}");
    }
}
