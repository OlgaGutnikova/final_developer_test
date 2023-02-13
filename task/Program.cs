int getUserNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string[] enterArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = (Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] SecondArray(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(data);
    Console.ResetColor();
}

int N = getUserNumber("Введите количество элементов массива: ");
string[] Array1 = enterArray(N);
printInColor("Исходный массив: ");
PrintArray(Array1);
string[] SecondAr = SecondArray(Array1);
printInColor("Итоговый массив: ");
PrintArray(SecondAr);
