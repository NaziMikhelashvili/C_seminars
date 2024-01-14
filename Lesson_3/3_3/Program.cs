// Задача: найдите произведения пар чисел в одномерном массиве, где парой считаются первый и последний элемент, второй и предпоследний и тд

Console.WriteLine("Введите количество элементов в массиве:");
int Count = int.Parse(Console.ReadLine()!);
int[] arr = new int[Count];

Console.Write("Массив: [");
Random El_mas = new();
for (int i = 0; i < Count; i++)
{
    arr[i] = El_mas.Next(-10, 10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine("]");

int b = 0;
Count = Count - 1;
while ((b != Count) && (b < Count))
{
arr[b] = arr[b] * arr[Count];
Console.Write(arr[b] + " ");
b++;
Count--;
}
if ((b != 0) && (b == Count))
{
    Console.WriteLine($"В массиве есть элемент {arr[b]} с индексом {b} без пары");
}

