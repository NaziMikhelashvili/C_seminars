// задайте двумерный массив, найдите элемента у которых оба индекса четные и замените элементы на их квадраты

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
    Console.Write("Matrix: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    } 
}

int [,] SquareEven (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 2)
        {
            matrix [i, j]= matrix [i, j] * matrix [i, j];
        }
    } 
    return matrix;

}


int [,] matrix = CreateMatrix(4,4);
ShowMatrix(matrix);
SquareEven(matrix);
ShowMatrix(matrix);

