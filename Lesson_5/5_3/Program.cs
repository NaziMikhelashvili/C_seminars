// задайте двумерный массив, сформируйте одномерный массив из среднеарифметических по строкам 

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

double [] Avg (int[,] matrix)
{
    double [] avg = new double [matrix.GetLength(0)];

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
        }
    avg[i] = sum / matrix.GetLength(1);
    Console.WriteLine($"Result: {avg [i]}");
   }
   return avg;
}


int [,] matrix = CreateMatrix(4,3);
ShowMatrix(matrix);
Avg(matrix);
