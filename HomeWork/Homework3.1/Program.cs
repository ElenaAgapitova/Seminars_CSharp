// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является 
// ли оно палиндромом.

// Решение 3.
/*
Console.Clear();

void Palindrome(int num)
{
    int number = num;
    int result = 0;
    if (number > 0)
        while (number > 0)
        {
            result *= 10;
            result = result + number % 10;
            number /= 10;
        }
    if (num == result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Число {num} - палиндром.");
    }
    else if(number < 0 || number != result)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);

Console.ReadLine();

// Решение 4:

Console.Clear();

void Palindrome(int number)
{
    string num = Convert.ToString(number);
    int size = num.Length;
    bool palindrome = true;

    for (int i = 0; i < size / 2; i++)
    {
        if (num[i] == num[size - i - 1])
            palindrome = true;
        else
            palindrome = false;
    }
    if (palindrome == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Число {num} - палиндром.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
    }
}

    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Palindrome(num);

    Console.ReadLine();
*/

// Решение 5:

Console.Clear();

void Palindrome(int num)
{
    int count = 1;
    int size = num.ToString().Length;
    int del = (int)(Math.Pow(10, size - 1));
    while (count <= size / 2)
    {
        if (num % 10 == num / del)
        {
            num = num % 10 / del;
            count++;
        }
            if (num <= 9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Число {num} - палиндром.");
            }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Число {num} НЕ является палиндром.");
        }
        break;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);
Console.ReadLine();