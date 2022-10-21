// Двумерные массивы
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
          array[i,j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Print2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
int[,] myArray = CreateRandom2Array();
Print2Array(myArray);