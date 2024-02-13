// массив символов тип char - создать строку из символов массива

char [] mass = {'a', 'b', 'c', 'd'};
string result = "";
foreach(char i in mass)

{
    result = result + i;
}

Console.WriteLine(result);