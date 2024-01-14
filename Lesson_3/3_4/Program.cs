// задача: создайте массив из чисел заданного 3-хзначного числа

Console.WriteLine("Введите 3-хзначное число");
int a = int.Parse (Console.ReadLine()!);

int[] Result = new int[3];
int i = 0;
if (a < 1000 && a > 99)
{ 
Console.Write("[");
    while( a > 0)
    {
        Result[i] = a % 10;
        a = a / 10;
        Console.Write(Result[i]+" ");
        i = i + 1;
    }

Console.Write("]");
}
else 
{Console.WriteLine("заданное число не является 3-хзначным");}