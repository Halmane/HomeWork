namespace Card;

internal class TBlack : DebitCard
{
    public override void AddMoney(double money)
    {
        _balance += money + money * 0.00005;
    }

    public override bool Pay(double money)
    {
        if (_balance - money >= 0)
        {
            _balance -= money;
            _getCashback(money);
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }

    private void _getCashback(double money)
    {
        if (money >= 5000)
        {
            _balance += money * 0.005;
            Console.WriteLine($"You will receive cashback: {money * 0.005}");
        }
            
    }
}
