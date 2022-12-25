string[] firstArray = new string[0];

Console.WriteLine("Введите кол-во строк: ");
string? count = Console.ReadLine();

if (int.TryParse(count, out int tryCount) & tryCount > 0)
{
    firstArray = new string[tryCount];
    for (int i = 0; i < tryCount; i++)
    {
        Console.WriteLine($"Введите строку {i + 1}:");
        string? symbols = Console.ReadLine();
        firstArray[i] = symbols;
    }
}
else
{
    Console.WriteLine("Введено недопустимое значение");
}


string[] secondArray = new string[firstArray.Length];
void FinalArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FinalArray(firstArray, secondArray);
Console.Write($"Строки, кол-во символов которых больше или равно 3: ");
PrintArray(secondArray);
