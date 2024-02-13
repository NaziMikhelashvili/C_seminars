// на основе символов строки (тип string) сформировать массив символов (тип char)

string str =  "Hello";
char[] CharToArr(string word)
{
char [] arr = new char [word.Length];

for(int i = 0; i < word.Length; i++)
{
    arr[i] = word[i];
}

return arr;
}
Console.WriteLine(CharToArr(str));
