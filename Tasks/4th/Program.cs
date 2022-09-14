// Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.
// 456 -> 3
// 0.78 -> 2
// 89.126 -> 5

int digitCount(double x) 
{
    int count = 0;
    while(x * Math.Pow(10, 1 + count) % 10 != 0)  //Считает количество цифр после точки (запятой)
    {
        count++;
    }
    while(x > 1) {                                  //Считает количество цифр перед точкой(запятой)
        x /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Enter the double number! ");
try
{
    double x = Convert.ToDouble(Console.ReadLine());
    int count = digitCount(x);
    Console.WriteLine(count);
} catch
{
    Console.WriteLine("You entered not a number!");
}
