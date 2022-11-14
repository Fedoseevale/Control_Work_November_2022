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
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            len = len + 1;
        }
    }
    return len;
}

string[] SortElementsFromArrayString(string[] arr, int len)
{
    string[] array = new string[len];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[index] = arr[i];
            index++;
        }
    }
    return array;
}

string[] ourArr = CreateArrayString();
Console.WriteLine("Имеем массив из строк: ");
PrintArray(ourArr);
int sizeMy = NumberOfReqElementsOfArrayString(ourArr);
string[] ourArray = SortElementsFromArrayString(ourArr, sizeMy);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(ourArray);