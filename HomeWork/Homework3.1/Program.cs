// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является 
// ли оно палиндромом.

// Решение 3.

Console.Clear();

int ReverseNumber(int num)
{
    int result = 0;
    if(num<0)
    {
        num = num*(-1);
        while (num > 0)
        {
            result *= 10;
            result = result + num % 10;
            num /= 10;
        }
        result = result *(-1);
    }
    if(num>0)
    {
        while (num > 0)
        {
            result *= 10;
            result = result + num % 10;
            num /= 10;
        }

    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverseNum = ReverseNumber(num);

if (num == reverseNum)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число {num} - палиндром.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {num} НЕ является палиндромом.");
}
Console.ReadLine();