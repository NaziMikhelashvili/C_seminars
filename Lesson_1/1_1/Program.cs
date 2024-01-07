// задача: является ли первое число квадратом второго?

Console.Write ("Enter Number1 ");
int b1 = int.Parse (Console.ReadLine ()!);
Console.Write ("Enter Number2 ");
int b2 = int.Parse (Console.ReadLine ()!);

if (b2 * b2 == b1)
Console.WriteLine("Yes");
else
Console.WriteLine("No");


