Random random = new Random();
int daysUnitExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUnitExpiration);
if (daysUnitExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUnitExpiration <= 5)
{
    discountPercentage += 10;
    Console.WriteLine($"You subscription expores in {daysUnitExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUnitExpiration == 1)
{
    discountPercentage += 10;
    Console.WriteLine("You subscription expores within an day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUnitExpiration == 0)
{
    Console.WriteLine("Your subscription has expired");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}