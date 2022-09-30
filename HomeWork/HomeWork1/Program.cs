/*
// Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// Решение:

Console.Clear();

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.Write("Ваши числа равны. Введите другие числа.");
}
else 
{
    if (a > b)
    {
        Console.Write("Максимальное число = " + a);
    }
    else
    {
        Console.Write("Максимальное число = " + b);
    }
}
*/

/*
// Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

// Решение:

Console.Clear();

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число = " + max);
*/