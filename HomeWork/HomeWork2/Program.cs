// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
/*
Console.Clear();

int FindSecondDigit(int num)
{
    int result;
    result = num / 10 % 10;
    return result;
}

Console.WriteLine("Введите число от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());
int answer = FindSecondDigit(num);
Console.WriteLine($"Вторая цифра числа {num} -> {answer}.");
Console.ReadLine();
*/

// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

//Решение 1:
/*
Console.Clear();

int ThirdDigit(int num)
{
    int res = 0;

    if (num >= 100 & num <= 999)
        res = num % 10;
    else
        if (num >= 1000 & num <= 9999)
        res = num / 10 % 10;
    else
        if (num >= 10000 & num <= 99999)
        res = num / 100 % 10;
    return res;
}

int num = new Random().Next(1, 100000);

if (num >= 1 & num <= 99)
    Console.WriteLine("Третьей цифры нет");
else
{
    int answer = ThirdDigit(num);
    Console.WriteLine($"Полученное число = {num}, третья цифра в данном числе = {answer}");
}
Console.ReadLine();
*/

// Решение 2:
/*
Console.Clear();

int ThirdDigit(int num)
{
    int res = 0;

    if (num >= 100 & num <= 999)
        res = num % 10;
    else 
        if (num >= 1000 & num <= 9999)
            res = num / 10 % 10;
    else 
        if (num >= 10000 & num <= 99999)
            res = num / 100 % 10;
    return res;
}

Console.Write("Введите число от 1 до 99 999: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>=1 & num<=99)
    Console.WriteLine("Третьей цифры нет");
else
{
    int answer = ThirdDigit(num);
    Console.WriteLine($"Полученное число = {num}, третья цифра в данном числе = {answer}");
}
Console.ReadLine();
*/

// Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

Console.Clear();

string FindWeekend(int day)
{
    string result;
    if (day<=5)
        result = "Это рабочий день";
    else
        result = "Это выходной день.";
    return result;
}

Console.WriteLine("Введите цифру, обозначающая день недели, где понедельник - это 1, воскресенье -7: ");
int day = Convert.ToInt32(Console.ReadLine());
string answer = FindWeekend(day);
Console.WriteLine(answer);   
Console.ReadLine();
