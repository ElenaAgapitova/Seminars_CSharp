// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
Console.Clear();

int AmountEvenNumbers()
{
    int size = new Random().Next(2,11);
    int[] array = new int[size];
    Console.Write("Созданный массив: ");
    int amount = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
        if(array[i] % 2 == 0) 
            amount++;
    }
    return amount;
       
}

int result = AmountEvenNumbers();
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {result}");
Console.ReadLine();
*/
// Задача №2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0
/*
Console.Clear();

int SumUnevenIndexNum(int size)
{
    int[] array = new int[size];
    Console.Write("Созданный массив: ");
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
        Console.Write(array[i] + " ");
        if(i % 2 != 0) 
            sum = sum + array[i];
    }
    return sum;
       
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int result = SumUnevenIndexNum(size);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");
Console.ReadLine();
*/
// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива. [3 7 22 2 78] -> 76

Console.Clear();

double DifMaxMin(int size)
{
    double[] array = new double[size];
    Console.Write("Созданный массив: { ");
    double dif = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,101);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("}.");
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < size; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
        dif = max - min;
    }
    Console.WriteLine($"Максимальный элемент массива = {max}. Минимальный элемент массива = {min}");   
    return dif;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double result = DifMaxMin(size);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Ответ: разница между максимальным и минимальным элементами массива равна {result}.");
Console.ReadLine();