// считать строку с латинскими буквами и вывести на экран согласные буквы

void str(string result, int index = 0)
{
    if (result.Length == index) return;

    string letters = "bcdfghjklmnpqrstvwxz";
    if (letters.Contains(char.ToLower(result[index])))
    {
        Console.Write(result[index]);
    }

    str(result, index + 1);
}

str("Hello, world");