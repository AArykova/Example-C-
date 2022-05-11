Console.Write("Введите количество элементов массива:\t");
int lenght = Convert.ToInt32(Console.ReadLine());
string[] array = new string[lenght];
string[] newarray = new string[array.Length];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i} - элемент массива:\t");
    array[i] = Console.ReadLine();
}
Console.WriteLine("\nВведенный массив:");
PrintArray(array);
FillNewArray(array, newarray);

void FillNewArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        }
    }
    Console.WriteLine("Отсортированный массив");
    PrintArray(newarray);
}

void PrintArray(string[] printarray)
{
    for (int i = 0; i < printarray.Length; i++)
    {
        Console.Write($"{printarray[i]} ");
    }
    Console.WriteLine();
}
