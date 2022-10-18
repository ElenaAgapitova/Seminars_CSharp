// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
/*
Console.Clear();
int[] CreateArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the minimum element: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the maximum element: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}
/*
void ChangeFirstElement(int[] array)
{
    array[0] +=5;
   
}
*/
/*
void ReverseArray(int[] array)
{
    for(int i = 0, last = array.Length -1; i < array.Length/2; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[] yourArray = CreateArray();
PrintArray(yourArray);

PrintArray(yourArray);
Console.ReadLine();
*/
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
/*
Console.Clear();
bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < a + b) 
        return true;
    else return false;
}
*/
Console.Clear();
bool Triangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}
    
Console.Write("Введите число А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C = ");
int c = Convert.ToInt32(Console.ReadLine());
bool result = Triangle(a,b,c);
if(result) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");
Console.ReadLine();

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного 
// копирования.
/*
int[] CreateArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the minimum element: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the maximum element: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

int[] ReturnArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    return newArray;
}

int[] yourArray = CreateArray();
PrintArray(yourArray);
int[] myArray = ReturnArray(yourArray);
PrintArray(myArray);
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++)
    {
       array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В = ");
int b = Convert.ToInt32(Console.ReadLine());
int[] result = Fibonacci(a,b,n);
PrintArray(result);
*/