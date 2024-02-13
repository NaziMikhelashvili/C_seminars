// Операторы передачи управления: 
// break - прервать цикл (для while, for, foreach)
// continue - начинает новую итерацию блиайшего цикла (иногда чтобы пропустить часть кода)

// int [,] table = new int [3,5]
// создать двумерный массив с размерами 3 на 5 из целых чисел и вывести на экран

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    } 
}

int [,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);


// создание строк 
// string s1 = "hello";

// char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
// string s2 = new string(ch_array);
// string s3 = new string('a', 6);

// методы строк:
// contains - содержит в строке
// Endswith - совпадает ли конец
// IndexOd 
// Insert
// Replace


// считать с консоли строку из латинских цифр и букв и сформировать строку из букв

string GetLetters(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine()!;
string result = GetLetters(str);
Console.WriteLine(result);
