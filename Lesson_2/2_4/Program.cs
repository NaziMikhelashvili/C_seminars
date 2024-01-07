//  вывести третью с конца цифру либо сообщить, что ее нет


Console.WriteLine("Enter Number");
int a = int.Parse (Console.ReadLine()!);

if (a >= 100)
{
int result = a / 100 % 10;
Console.WriteLine(result);
}
else 
{Console.WriteLine("3rd digit is missing");}