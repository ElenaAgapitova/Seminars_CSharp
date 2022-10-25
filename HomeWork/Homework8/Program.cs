// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
Console.Clear();

int[,] Create2Array()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите возможный минимальный элемент массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите возможный максимальный элемент массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Print2Array(int[,] array)
{
    Console.WriteLine("Созданный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeOrderElementsString(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

int[,] newArray = Create2Array();
Print2Array(newArray);
Console.WriteLine();
// int[,] changeArray = ChangeOrderElementsString(newArray);
// Print2Array(changeArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

int[] SumElementsString(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            result[i] = sum;
        }
    }
    return result;
}

void PrintSumArray(int[] array)
{
    Console.Write("Сумма элементов в строке: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

int MinSumElementsString(int[] array)
{
    int StringMin = 0;
    int min = array[StringMin];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            StringMin = i;
        }
    }
    return StringMin;
}

int[] result = SumElementsString(newArray);
PrintSumArray(result);
int res = MinSumElementsString(result);
Console.WriteLine($"Номер строки с наименьшей суммой элементов - {res + 1}.");


Console.ReadLine();