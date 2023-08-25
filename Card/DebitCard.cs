namespace Card;

internal class DebitCard : BankCard
{
    protected double balance;
    public override double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public override void AddMoney(double money)
    {
        Balance += money;
    }

    public override bool Pay(double money)
    {
        if (Balance - money >= 0)
        {
            Balance -= money;
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
    }
}
