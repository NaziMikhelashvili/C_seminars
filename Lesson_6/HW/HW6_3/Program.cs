// задайте произвольную строку и выясните является ли она палиндромом

Console.Write("Enter text:");
string input = Console.ReadLine()!;

bool result = Ispalindrome(input);
bool res = Ispalindrome(input);
Console.WriteLine(res);

bool Ispalindrome(string word)
{
    int size = word.Length;
    for (int i = 0; i < size / 2; i++)
    {
        if(word[i] != word[size - 1 - i])
        return false;
    }
    return true;
}