using Card;
using static System.Net.Mime.MediaTypeNames;

Test(new CreditBonusCard());
Test(new TBlack());
Test(new CreditCard());
Test(new DebitCard());
void Test(BankCard card)
{
    card.AddMoney(100000);
    card.AllInfo();
    card.Pay(70000);
    card.AllInfo();
}
