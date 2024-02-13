// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет:
//  "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

int [,] CreateMatrix (int RowCount, int ColumnCount)
{
    int [,] matrix = new int [RowCount, ColumnCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rnd.Next(1,11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    Console.WriteLine("Matrix: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    } 
}

int [,] matrix = CreateMatrix(4,4);
ShowMatrix(matrix);

int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);
if (i > matrix.GetLength(0) || i < 0)
{
Console.Write("Позиция по рядам выходит за пределы массива");
}
if (j > matrix.GetLength(1) || j < 0)
{
Console.Write("Позиция по колонкам выходит за пределы массива");
}
else 
Console.Write(matrix[i, j]);