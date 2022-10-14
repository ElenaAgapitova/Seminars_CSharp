// Задача №4. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.Clear();

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

int[] ProductElementsArray(int[] array)
{
    int i = 0;
    int size = array.Length;
    int end = array.Length / 2;

    if (size % 2 != 0)
    {
        int length = size / 2 + 1;
        int[] newarray = new int[length];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        if(i == end) newarray[i] = array[end];
        return newarray;
    }
    else
    {
        int count = size / 2;
        int[] newarray = new int[count];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        return newarray;
    }
    return array;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue, maxValue);
PrintArray(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
int[] result = ProductElementsArray(yourArray);
PrintArray(result);
Console.ReadLine();
