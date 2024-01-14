// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};

int i = 0;
double a = 0;

double max = 0;
double min = 0;
double result = 0;
a = arr[i];
max = a;
min = a; 

while (i < arr.Length)
{
a = arr[i];
if (a > max)
{max = a;}
if (a < min)
{min = a;}
i = i + 1;
}

result = max - min;
Console.WriteLine(result);