// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int sumDigits(int number) 
{
    int result = 0;
    while(number > 0) 
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Enter an intrger number:");
try
{
    int x = Convert.ToInt32(Console.ReadLine());
    int sumDig = sumDigits(x);
    Console.WriteLine($"The sum of the digits of the number {x} is {sumDig}");
} catch
{
    Console.WriteLine("It`s not a int number!");
}

