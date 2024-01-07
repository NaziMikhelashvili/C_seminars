// задача: показать все числа от -N до N

Console.Write ("Enter Number ");
int a = int.Parse (Console.ReadLine ()!);
int count = a * -1;

while (count <= a)
{
Console.Write(count+" ");
count++;
}
