Console.WriteLine("Show Character");
ShowCharacter();

Console.WriteLine("\n\nRetail Price");
RetailPrice();

Console.WriteLine("\n\nTemperature Table");
Console.WriteLine("Press enter to show a table of temperature conversions from fahrenheit to celcius");
Console.ReadLine();
TemperatureTable();

Console.WriteLine("\n\nPrime Numbers");
PrimeNumbers();


static void ShowCharacter()
{
    Console.WriteLine("What word or phrase would you like to use?");
    string phrase= Console.ReadLine();
    Console.WriteLine("Which position would you like to know about?");
    int number = Int32.Parse(Console.ReadLine());

    char Character = phrase[number-1];
    Console.WriteLine(Character);
}

static void RetailPrice()
{
    Console.WriteLine("What is the price of the item?:");
    double price=Double.Parse(Console.ReadLine());
    Console.WriteLine("What is the markup percentage of the item");
    double markup=Double.Parse(Console.ReadLine());

    double retailPrice = (price + ((markup * .01) * price));
    Console.WriteLine($"The retail price of the item is ${Math.Round(retailPrice,2).ToString("0.00")}");

}

static void TemperatureTable()
{
    double F;
    double C;

    for (F = 80; F < 101; F++)
    {
        C = Math.Round((F - 32) * (5.0/9.0),1);
        Console.WriteLine($"Fahrenheit = {F}  : Celcius = {C}");
    
    }
}

static void PrimeNumbers()  //https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not
{
    Console.WriteLine("What number would you like to test?");
    int n = Int32.Parse(Console.ReadLine());
    int a = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            a++;
        }
    }
    if (a == 2)
    {
        Console.WriteLine("{0} is a Prime Number", n);
    }
    else
    {
        Console.WriteLine("Not a Prime Number"); 
    }
}