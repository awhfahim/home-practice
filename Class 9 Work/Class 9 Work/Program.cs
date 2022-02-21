using Class_9_Work;

PercentageDiscount percentageDiscount = new PercentageDiscount(18);
//percentageDiscount.Amount = 10;
double priceAfterDiscount = percentageDiscount.PriceAfterDiscount(2000);
Console.WriteLine(priceAfterDiscount);
