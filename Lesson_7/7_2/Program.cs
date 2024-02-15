// Задайте значение N - введите все натуральные числа в промежутке от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());    
Interval(num);

static void Interval (int num)
{
    if (num == 0)
        return;
    Interval (num - 1);
    Console.Write(num + "\t");
}