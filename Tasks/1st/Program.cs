// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int degree(int a, int b) {
    int res = a;
    for(int i = 1; i < b; i++) {
        res = res * a;
    }
    return res;
}

Console.WriteLine("Enter two numbers: ");
try {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int degreeAB = degree(a, b);
    Console.WriteLine($"Number {a} to the power of {b} = {degreeAB}");
} catch {
    Console.WriteLine("You didn't enter a number!");
}
