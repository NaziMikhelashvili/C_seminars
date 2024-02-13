// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.


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

int[] sum (int[,] matrix)
{
  int [] sum = new int[matrix.GetLength(0)];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum[i] += matrix[i, j];
    }
   }
   return sum;
   
}

void FindMin(int[] matrix)
{
    int min_ind = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (sum[i] < sum[min_ind])
        min_ind = i;
    }
    Console.WriteLine($"Sum of elements: {matrix[min_ind]}");
    Console.WriteLine($"line: {min_ind + 1}");
}


int [,] matrix = CreateMatrix(4,3);
ShowMatrix(matrix);
sum(matrix);
FindMin(matrix);