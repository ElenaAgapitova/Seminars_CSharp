// Задача №1. 
/*
// Решение 1:
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
Console.WriteLine(result);
Console.ReadLine();
*/
/*
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
*/
/*
// Задача №2. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

Console.Clear();

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}

Console.Write("Введите кординату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кординату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(x1,y1,z1,x2,y2,z2);
double Distance = Math.Round(distance,2);
Console.WriteLine($"Растояние между точкой А({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) = {Distance}");

Console.ReadLine();
*/
// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

/*
Console.Clear();

void FindCubesofNumbers(int N)
{
    int count = 1;
    if(N<1)
        Console.WriteLine("Введите число больше 1");
    else
    {
        while(count<=N)
        {
            Console.Write($"{Math.Pow(count,3)} ");
            count++;
        }
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Кубы чисел от 1 до {N}: ");
FindCubesofNumbers(N);
Console.ReadLine(); 
*/