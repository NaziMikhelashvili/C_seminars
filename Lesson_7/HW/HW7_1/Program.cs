// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
PrintNaturalNumbers(m, n);

static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        PrintNaturalNumbers(m + 1, n);
    }
}