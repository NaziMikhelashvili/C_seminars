﻿// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


int[] arr = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int i = 0;
int a = 0;

while ( a < arr.Length)
{
    if (arr[a] % 2 ==0)
    {
    i = i + 1;
   }
     a = a + 1;
}
Console.WriteLine(i);
