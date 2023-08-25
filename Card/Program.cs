using Card;

var creditCard = new CreditCard();
creditCard.AddMoney(10000);
creditCard.Pay(20000);
creditCard.AddMoney(30000);
creditCard.Pay(20000);
creditCard.Pay(30000);
creditCard.AddMoney(20000);
creditCard.Pay(30000);
creditCard.AllInfo();
