// Задайте массив из случайных трехзначных чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int [] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 999);
    return arr;
}
int InRange (int[] arr)
{
    int n = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            n += 1;}
    return n;
}

int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num);
Print(mass);

int Result = InRange(mass);
Console.WriteLine(Result);

