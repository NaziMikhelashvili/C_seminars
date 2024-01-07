//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число от 10 до 99");
int a = int.Parse (Console.ReadLine()!);

if (a <= 99 && a >= 10)
{
int b = a % 10;
int c = a / 10;
int result = b; 
if (c > result)
{result = c;}
Console.WriteLine(result);
}
else 
{Console.WriteLine("число вне диапазона 10-99");}