// Задайте массив из случайных трехзначных чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int [] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    Random n_new = new Random();


    for (int i = 0; i < size; i++)
        arr[i] = (n_new.Next(from, to));
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

int[] mass = MassNums(num, 100, 999);
Print(mass);

int Result = InRange(mass);
Console.WriteLine(Result);

