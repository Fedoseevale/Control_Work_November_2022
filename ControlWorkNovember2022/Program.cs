string[] CreateArrayRndInt2(int size)
{
    Console.WriteLine("Введите длину массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
   
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку {i+1}: ");
        array[i] = Console.ReadLine(); 
    }
    return array;
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}'', ");
        else Console.Write($"'{array[i]}'");
    }
    Console.WriteLine("]");
}




string[] arr = CreateArrayRndInt2(10);
PrintArray(arr);


