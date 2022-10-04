/*
int FindBiggestDigit(int num)
{
    int max;
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
        max = ed;
    else
        max = dec;

    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);
Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Задача 1: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру 
//этого числа.
/*
int DeleteSecondDigit(int num)
{
    int ed = num % 10;
    int hun = num / 100;
    int result = hun*10 + ed;
    return (result);
}

int number = new Random().Next(100, 1000);
int res = DeleteSecondDigit(number);
Console.WriteLine(number);
Console.WriteLine(res);
*/
// Задача 2: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
// одновременно a и b. a и b - инфо от пользователя(тоже int)

bool CratnoAB(int num, int a, int b)
{
    bool result;
    if (num % a == 0 & num % b == 0)
        result = true;
    else
        result = false;
    return result;
}

Console.WriteLine("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = CratnoAB(num, a, b);
Console.WriteLine(res);
