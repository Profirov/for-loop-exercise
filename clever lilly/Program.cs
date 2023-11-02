int age = int.Parse(Console.ReadLine());
double washingMashinePrice = double.Parse(Console.ReadLine());    
int toyPrice = int.Parse(Console.ReadLine());

int savedMoney = 0;
int toyCount = 0;
int moneyGift = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        savedMoney += moneyGift - 1;
        moneyGift += 10;
    }
    else 
    { 
       toyCount++;
    }
}
int totalMoneyFromToys = toyCount * toyPrice;
int totalMOney = savedMoney + totalMoneyFromToys;

if (totalMOney >= washingMashinePrice)
{
    double remainMoney = totalMOney - washingMashinePrice;
    Console.WriteLine($"Yes! {remainMoney:F2}");
}
else
{
    double neededMoney = washingMashinePrice - totalMOney;
    Console.WriteLine($"No! {neededMoney:F2}");
}

