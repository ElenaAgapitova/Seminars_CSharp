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


