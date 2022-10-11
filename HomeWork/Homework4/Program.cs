// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// Решение 1:
/*
Console.Clear();

int DegreeAB(int a, int b)
{
    int result = a;
    int size = b-1;
    for(int count = 1; count <= size; count++)
        result *= a;
    return result;
}
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int degreeAB = DegreeAB(a,b);
Console.WriteLine($"Число {a} в степени {b} = {degreeAB}");
Console.ReadLine();
*/
/*
// Решение 2:
Console.Clear();
int DegreeAB(int a, int b)
{
    int result;
    result = (int) (Math.Pow(a,b));
    return result;
}
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int degreeAB = DegreeAB(a,b);
Console.WriteLine($"Число {a} в степени {b} = {degreeAB}");
Console.ReadLine();
*/
// Задача №2.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
// Решение 1:
Console.Clear();
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumDigits}");
Console.ReadLine();
*/
// Решение 2:
Console.Clear();
int SumDigits(int number)
{
    int sum = 0;
    string num = number.ToString();
    int size = num.Length;
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = (int)char.GetNumericValue(num[i]); 
        for(int j =i; j < size; j++)
            sum = sum + array[j];  
    }
    return sum; 
      
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(number);
Console.WriteLine(result);
Console.ReadLine();

// Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Clear();

void FillArray(int[] array)
{
    int size = array.Length;
    for(int index = 0; index < size; index++)
        array[index] = new Random().Next(1, 100);
           
}

void PrintArray(int[] array)
{
    int size = array.Length;
    for(int index = 0; index < size; index++)
    {
        Console.Write(" " + array[index]);
    }
}

int[] array = new int[8];
FillArray(array);
Console.Write("Массив из 8 элементов:");
PrintArray(array);
Console.ReadLine();
*/