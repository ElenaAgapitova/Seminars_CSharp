// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
Console.Clear();

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

 void PrintArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }

int AmountEvenNumbers(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
            amount++;
    }
    return amount;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = AmountEvenNumbers(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Amount of even numbers in your array = {result}.");
Console.ReadLine();
*/
// Задача №2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
/*
Console.Clear();

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

 void PrintArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }

int SumUnevenIndexNums(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = SumUnevenIndexNums(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Sum of elements in odd positions = {result}.");
Console.ReadLine();
*/
// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива. [3 7 22 2 78] -> 76
/*
Console.Clear();

double[] CreateArray(int size)
{
    double[] array = new double[size];
        for(int i = 0; i < size; i++)
    {
        Console.Write("Input array element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

 void PrintArray(double[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }

double DifMaxMin(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
        dif = max - min;
    }
    Console.WriteLine($"The maximum element in your array = {max}.");
    Console.WriteLine($"The minimum element in your array = {min}.");
    return dif;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] yourArray = CreateArray(size);
PrintArray(yourArray);
double result = DifMaxMin(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Difference between maximum and minimum array elements = {result}.");
Console.ReadLine();
*/
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