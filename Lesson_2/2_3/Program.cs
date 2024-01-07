//  из 2 чисел проверять кратность друг другу - если нет кратности, выводить остаток от деления

Console.WriteLine("Enter Number1");
int a = int.Parse (Console.ReadLine()!);

Console.WriteLine("Enter Number2");
int b = int.Parse (Console.ReadLine()!);

if (a % b == 0)
{
    Console.WriteLine("кратно");
    }
else 
{
    Console.WriteLine("не кратно "+ a % b);
}