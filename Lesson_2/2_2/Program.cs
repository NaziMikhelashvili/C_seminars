//  из 3хзначного числа вторую цифру врзвести в степень равную третьей цифре


Console.WriteLine("Enter 3-Digit Number");
int a = int.Parse (Console.ReadLine()!);

if (a >= 100 && a < 1000)
{
int b = a % 100 / 10;
int c = a % 10;
double result = Math.Pow(b,c);
Console.WriteLine(result);
}
else 
{Console.WriteLine("please check number of digits");}