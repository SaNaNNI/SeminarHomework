
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
int max, min;
if (a > b)
{
    max = a;
    min = b;     
}  
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");