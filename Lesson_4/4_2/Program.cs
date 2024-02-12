// задайте массив из N случайных чисел.
// найдите количество чисел, которые заканчиваются на 1 и делятся на 7


int [] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    Random n_new = new Random();


    for (int i = 1; i < size; i++)
        arr[i] = (n_new.Next(from, to));
    return arr;
}
int InRange (int[] arr)
{
    int n = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
            n += 1;
    }
    return n;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);

int Result = InRange(mass);
Console.WriteLine(Result);

