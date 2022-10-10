// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
/*
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

Console.Clear();
int SumDigits(int num)
{
    int sum = 0;
    int number = num.ToString();
    int[] array = new int[number.Length];
    int size = number.Length;
    for(int i = 0; i < size; i++)
    {
        array[i] = int.Parse(number[i]);
        for(int j = 0; j < size; j++)
        {
            sum = sum + array[j];
        }
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumDigits}");
Console.ReadLine();


