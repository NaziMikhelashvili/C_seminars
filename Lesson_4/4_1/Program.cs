// задайте одномерный массив из случайных чисел
// определите количество простых чисел в массиве

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double [] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();


    for (int i = 1; i < size; i++)
        arr[i] = (n_new.Next(from, to));
    return arr;
}

int CountSimpleNum (double[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(FindSimpleNum(arr[i]))
        {
            Count++;
        }
    }
    return Count;
}

bool FindSimpleNum (double NN) 
{
    if(NN < 2)
        return false;
    for (int i = 2; i < NN; i++)
    {
        if (NN % i == 0)
            return false;
    }
    return true;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);

double Result = CountSimpleNum(mass);
Console.WriteLine(Result);





