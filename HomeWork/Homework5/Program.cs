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

int DifMaxMin(int[] array)
{
    int dif = 0;
    int min = array[0];
    int max = array[0];
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
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = DifMaxMin(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Difference between maximum and minimum array elements = {result}.");
Console.ReadLine();

