// перевернуть массив (1 элемент - последним, 2 - предпоследним и тд)

Console.WriteLine("Введите количество элементов в массиве:");
int Count = int.Parse(Console.ReadLine()!);
int[] arr = new int[Count];

Console.Write("Массив: [");
Random El_mas = new();
for (int i = 0; i < Count; i++)
{
    arr[i] = El_mas.Next(0, 1000);
    Console.Write(arr[i] + " ");
}
Console.WriteLine("]");

int b = 0;
Count = Count - 1;
while ((b <= Count))
{
Console.Write(arr[Count] + " ");
Count--;
}
