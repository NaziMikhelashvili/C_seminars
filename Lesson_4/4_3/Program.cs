// заполните массив из N случайных чисел от 0 до 9 (не более 8 чисел)
// сформируйте целое число из цифр массива 


    Console.WriteLine("enter array size (max 8)");
    int size = Convert.ToInt32(Console.ReadLine());
    Print(" ");

    if (size < 8)
    {
        int[] arr = GenerateRandomArray(size, 1, 10);
        Array.Sort(arr);
        Array.Reverse(arr);
        
        foreach (int num in arr)
            {
                Print("element: " + num);
            }
            Print(" ");
        int res = MakeInteger(arr, size);
        Print("result: " + res);
        }
       
    else {Print("Error! size > 8");}

 static void Print(string res){
        Console.WriteLine(res);    }
        
static int[] GenerateRandomArray(int size, int min_val, int max_val)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        {
            arr[i] = random.Next(min_val, max_val);
        }
        return arr;
    }
static int MakeInteger(int[] arr, int size)
    {
        int result = 0;
        for(int i = 0; i < size; i++)
        {
            result = result * 10 + arr[i];
        }
        return result;}



//int[] arr = new int[size];

// for (int i = 0; i < size; i++)
//     arr[i] = new Random().Next(from, to + 1);
// return arr;

// long CountNum(int[] arr)
// {
//     string word = "";

//     foreach (int number in arr)
//     {
//         word += number;
//     }

//     return long.Parse(word);
// }

// int num = int.Parse(Console.ReadLine()!);
// int start = int.Parse(Console.ReadLine()!);
// int stop = int.Parse(Console.ReadLine()!);