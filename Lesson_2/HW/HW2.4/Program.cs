// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число");
int a = int.Parse (Console.ReadLine()!);
string result = " ";
while(a > 0)
{int b = a % 10;
result = b + "," + result;   
a = a / 10;
} 
result = result[..^2];
Console.Write(result);