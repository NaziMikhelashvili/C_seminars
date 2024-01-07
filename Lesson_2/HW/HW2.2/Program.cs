//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите значение оси X");
double x = double.Parse (Console.ReadLine()!);

Console.WriteLine("Введите значение оси Y");
double y = double.Parse (Console.ReadLine()!);

if (x > 0 && y > 0)
{Console.WriteLine("1-я четверть");}
else if (x < 0 && y > 0)
{Console.WriteLine("2-я четверть");}
else if (x < 0 && y < 0)
{Console.WriteLine("3-я четверть");}
else if (x > 0 && y < 0)
{Console.WriteLine("4-я четверть");}
else if (x == 0 || y == 0)
{Console.WriteLine("на оси");}