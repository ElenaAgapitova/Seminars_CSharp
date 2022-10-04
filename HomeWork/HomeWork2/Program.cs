// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

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



