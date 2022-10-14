// Задача №1
/*
Console.Clear();
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i+1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum = sum + array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);
ShowArray(myArray);
Console.WriteLine($"Sum of negatives elements is {result}");
Console.ReadLine();
*/
// Задача№2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
/*
Console.Clear();
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.Write("Created array: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
    Console.WriteLine("");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int[] ChangeElements(int[] array)
{ 
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (-1) * array[i];
    }
    return array;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
int[] result = ChangeElements(myArray);
ShowArray(result);
Console.ReadLine();
*/
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
Console.Clear();
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Console.Write("Созданный массив: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    Console.WriteLine("");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

bool FindElement(int[] array, int find)
{

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == find)
        {
            return true;
        }
    }
    return false;     
       
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 10;
Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
bool res = FindElement(myArray,find);
Console.WriteLine(res);
*/
// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения 
//которых лежат в отрезке [10,99].

Console.Clear();
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Console.Write("Созданный массив: ");
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    Console.WriteLine("");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}

int AmountElements(int[] array)
{
    int amount =0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>=10 && array[i]<=99)
            amount++;
    }
    return amount;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -10;
int max = 100;
int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
int res = AmountElements(myArray);
Console.WriteLine(res);
