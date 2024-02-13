// задайте двумерный массив символов (тип char) - создать строку из символов


char [,] array = new char[,] {{'a', 'b'}, {'e', 'f'}};
string result = StringFromArray(array);
Console.WriteLine(result);

string StringFromArray(char [,] array)
{
string result = "";
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }}
return result;
}
