// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
/*
Console.Clear();

int FindSecondDigit(int num)
{
    int action1;
    int action2;
    action1 = num / 10;
    action2 = action1 % 10;
    return action2;
}

Console.WriteLine("Введите числоло от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = FindSecondDigit(num);
Console.WriteLine($"Вторая цифра числа {num} -> {res}.");
Console.ReadLine();
*/

// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
/*
Console.Clear();

int ThirdDigit(int num)
{
    int res = 0;

    if (num >= 100 & num <= 999)
        res = num % 10;
    else 
        if (num >= 1000 & num <= 9999)
            res = (num / 10) % 10;
    else 
        if (num >= 10000 & num <= 99999)
            res = (num / 100) % 10;
    return res;
}

int num = new Random().Next(1,100000);

if (num>=1 & num<=99)
    Console.WriteLine("Третьей цифры нет");
else
{
    int answer = ThirdDigit(num);
    Console.WriteLine(num);
    Console.WriteLine(answer);
}
Console.ReadLine();
*/