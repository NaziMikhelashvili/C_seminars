// считать строку с консоли из латинских букв в нижнем регистре - выяснить сколько гласных

string str = "Hello";
int CharToArr(string word)
{
    string vowels = "aeoiu";
    int value = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if (vowels.Contains(word[i]))
            value++;
    }
    return value;
}
Console.WriteLine(CharToArr(str));
