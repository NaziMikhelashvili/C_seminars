// программа, которая бесконечно запрашивает цифры с консоли и завершается при вводе q или 
// числа с четной суммой цифр 


while(true)
{
    Console.Write("Введите число:");
    string input = Console.ReadLine();

    if (input == "q")
        break;  

    int number = int.Parse(input);
    int sum = 0;
        while (number > 0)
        {sum += number % 10;
        number /= 10;}

        if (sum % 2 == 0)
            {Console.WriteLine ("STOP");
            break;}
    else {Console.Write("Check");}
}