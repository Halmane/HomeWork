namespace Card;

internal class TBlack : DebitCard
{
    public override void AddMoney(double money)
    {
        Balance += money + money * 0.00005;
    }

    public override bool Pay(double money)
    {
        if (Balance - money >= 0)
        {
            Balance -= money;
            GetCashback(money);
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }

    private void GetCashback(double money)
    {
        if (money >= 5000)
        {
            Balance += money * 0.005;
            Console.WriteLine($"You will receive cashback: {money * 0.005}");
        }
            
    }
}
