// F11 - шаг с заходом 
// f10 - шаг с обходом
// f5 = продолжить (до след точки)
// int Fact (int n)
// {
//     if (n == 1 || n == 0)
//     {
//        Console.WriteLine($"Stop n=({n})");
//        return 1;
//     }
//     Console.WriteLine(n);
//     return n* Fact(n-1);
// }

// Console.Write(Fact(5));

// напишите программу, кооорая будет принимать число и возвращать сумму его элементов

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма цифр числа: " + Sum(num));


static int Sum (int num)
{
    if (num < 10)
        return num;
    return num % 10 + Sum(num/10);
}