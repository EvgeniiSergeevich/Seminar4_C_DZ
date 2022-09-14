// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

int[] fillArray(int n) 
{
    int[] array = new int[n];
    Console.WriteLine("Enter array elements!");
    for(int i = 0; i < n; i++) 
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


Console.WriteLine("Enter the size of array: ");
try 
{
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = fillArray(size);
    Console.WriteLine($"Array: [{String.Join(",", array)}]");

} catch 
{
    Console.WriteLine("It`s not a int number");
}
