// задайте двумерный массив, найдите сумму элементов на главной диагонали 

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

int Sum (int[,] matrix)
{
    int sum = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
    {  for (int j = 0; j < matrix.GetLength(1); j++)
        if (i == j)
            {sum = sum + matrix[i, j];}
    } 
    Console.Write($"Sum: {sum} ");
    return sum;
    
}

int [,] matrix = CreateMatrix(7,6);
ShowMatrix(matrix);
Sum(matrix);
