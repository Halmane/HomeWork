using Card;

var creditCard = new CreditBonusCard();
creditCard.AddMoney(100000000);
creditCard.Pay(100000000);
creditCard.AddMoney(100000000);
creditCard.Pay(100000000);
creditCard.AddMoney(100000000);
creditCard.Pay(100000000);
creditCard.AllInfo();
creditCard.BonusPay(30007);
creditCard.AllInfo();
