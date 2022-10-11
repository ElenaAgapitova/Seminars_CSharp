// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Clear();
int GetSum(int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
        sum += current;
    return sum;
}
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine(result);

