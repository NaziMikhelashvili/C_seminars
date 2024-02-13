// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

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

int [,] Replace(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    (matrix[0, j], matrix[matrix.GetLength(0) - 1, j]) =( matrix[matrix.GetLength(0) - 1, j], matrix[0, j]);
    return matrix;
}

int [,] matrix = CreateMatrix(4,4);
ShowMatrix(matrix);
Replace(matrix);
ShowMatrix(matrix);

