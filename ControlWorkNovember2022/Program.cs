string[] CreateArrayString()
{
    Console.WriteLine("Введите длину массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку для {i + 1}-го элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
    Console.WriteLine("]");
}

int NumberOfReqElementsOfArrayString(string[] arr)
{
    int len = default;
    string[] array = new string[len];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            len = len + 1;
        }
    }
    return len;
}

