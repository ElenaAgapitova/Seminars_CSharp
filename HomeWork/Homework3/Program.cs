// Задача №1. 
/*
Console.Clear();

string Palindrome(int num)
{
    string res;
    string numString = Convert.ToString(num);
    
    if (numString.Length == 5)
    {
        char one = numString[0];
        char two = numString[1];
        char four = numString[3];
        char five = numString[4];
        if (one == five && two == four)
            res = $"Число {num} - палиндром.";
        else
            res = $"Число {num} не является палиндромом.";
    }
    else
        res = "Введите пятизначное число.";

    return res;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(num);
Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine(result);
Console.ReadLine();
*/
// Решение 2:

Console.Clear();

void Palindrome(int num)
{
    int symbol_1 = num / 10000;
    int symbol_5 = num % 10;
    int symbol_2 = num / 1000 % 10;
    int symbol_4 = num / 10 % 10;
    if(symbol_1==symbol_5 && symbol_2==symbol_4)
        Console.WriteLine($"Число {num} - палиндром.");
    else
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);
Console.ReadLine();

