// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
Console.Clear();
int GetSum(int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
        sum += current;
    return sum;
}
Console.Write("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine(result);
*/
// Задача №2:Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
Console.Clear();
int NumberDigits(int num)
{
    int size = num.ToString().Length;
    return size;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumberDigits(a);
Console.WriteLine(result);
Console.ReadLine();
*/
Console.Clear();
int NumberDigits(int num)
{
    int count = 0;
    while(num>0)
    {
        num/=10;
        count++;
    }
    return count;
}
Console.Write("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumberDigits(a);
Console.WriteLine(result);
Console.ReadLine();

// Задача №3:Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
Console.Clear();
int Factorial(int a)
{
    int result = 1;
    for (int current = 1; current <= a; current++)
        result*= current;
    return result;
}
Console.Write("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Factorial(a);
Console.WriteLine(result);
Console.ReadLine();
*/