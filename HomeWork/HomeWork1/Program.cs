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

if (a == b && a == c)
{
    Console.Write("Ваши числа равны. Введите другие числа.");
}
else
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("Максимальное число = " + max);
}
*/

/*
// Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write($"Число {a} - это четное число.");
}
else 
{
    Console.Write($"Число {a} - это нечетное число.");
}
*/


// Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

// Решение (1 способ):
/*
Console.Clear();

Console.Write("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 1)
{
    if (n % 2 == 0)
    {
        Console.Write(" " + n);
    }
    n--;
}
Console.Write(" - четные числа в заданном промежутке.");
Console.ReadLine();
*/


// Решение (2 способ)
/*
Console.Clear();

Console.Write("Введите число больше 1: ");

try
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n<=1) 
    {
        Console.WriteLine ("Введите число, которое больше 1");
        Console.ReadLine();
    }
    else
    {
        int current = 2;

        while (current <= n)
        {
            Console.Write(" " + current);
            current = current + 2;
        }
        Console.Write(" - четные числа в заданном промежутке. ");
        Console.ReadLine();
    }
} 
catch (Exception)
{
    Console.WriteLine("Некорректный ввод. Введите целое число");
    Console.ReadLine();
}
*/