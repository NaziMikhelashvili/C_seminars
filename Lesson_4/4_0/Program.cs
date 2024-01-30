// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,90].

int InRange (int[] arr)
{
    int n = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] >= 20 && arr[i] <= 90)
            n += 1;
    }
    return n;
}

int[] arr = new int[] {1, 65, 10, 20, 30, 40, 99, 4, 90, 3};
int n = InRange (arr);
Console.WriteLine(n);

// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


int EvenNum (int [] arr2)
{
    int count = 0;

    for (int i = 0; i < arr2. Length; i++)
    {
        if (arr2[i] % 2 == 0)
        count +=1;
    }
    return count;
}

int[] arr2 = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int count = EvenNum(arr2);
Console.WriteLine(count);

// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double DiffMaxMin (double[] arr3)
{
    double n_max = arr3[0];
    double n_min = arr3[0];
    double Diff = arr3[0];

    for (int i = 1; i < arr3.Length; i++)
    {
        if (n_max < arr3[i]) 
            n_max = arr3[i];

        else if (n_min > arr3[i])
            n_min = arr3[i];
    }
    Diff = n_max - n_min;
    return Diff;
    Console.Write($"Max: {n_max}, Min: {n_min}. ");
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Diff}");
}

double[] arr3 = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double Diff = DiffMaxMin(arr3);
Console.WriteLine(Diff);