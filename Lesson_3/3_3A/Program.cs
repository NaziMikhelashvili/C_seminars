// Задача: найдите произведения пар чисел в одномерном массиве, где парой считаются первый и последний элемент, второй и предпоследний и тд


int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
    new_arr[i] = arr[i] * arr[size - i - 1];

    if (size % 2 == 1)
    new_arr[flex_size -1] = arr[size / 2];
    return new_arr;
}

