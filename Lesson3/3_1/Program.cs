// Задача: Напишите программу, которая нопределяет присутствует ли заданное число в массиве

Console.WriteLine("Введите число");
int a = int.Parse (Console.ReadLine()!);

int[] arr = new int[] {3, 4, 8, 9, 10};
bool b = false;

for (int i = 0; i < arr.Length;)
{
    if ( a == arr[i])
    {
        b = true;
        break;}
        i = i + 1;}
    if (b)
       { Console.WriteLine("Yes");}

    else {Console.WriteLine("No");}
