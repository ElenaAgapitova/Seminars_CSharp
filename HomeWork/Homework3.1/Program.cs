// Задача №1. 

// Решение 3.

Console.Clear();
int ReverseNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result *= 10;
        result = result + num % 10;
        num /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverseNum = ReverseNumber(num);

if(num == reverseNum)
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