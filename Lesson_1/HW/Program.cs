Console.Write ("Enter firstNumber ");
int firstNumber = int.Parse (Console.ReadLine ()!);
Console.Write ("Enter secondNumber ");
int secondNumber = int.Parse (Console.ReadLine ()!);
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("числа равны");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("первое число больше");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine("второе число больше");
        }


Console.Write ("Enter a ");
int a = int.Parse (Console.ReadLine ()!);
Console.Write ("Enter b ");
int b = int.Parse (Console.ReadLine ()!);
Console.Write ("Enter c ");
int c = int.Parse (Console.ReadLine ()!);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("Максимальное значение: " + max);


