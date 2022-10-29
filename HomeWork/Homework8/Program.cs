// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
Console.Clear();

int[,] Create2Array()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите возможный минимальный элемент массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите возможный максимальный элемент массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Print2Array(int[,] array)
{
    Console.WriteLine("Созданный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeOrderElementsRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

// int[,] newArray = Create2Array();
// Print2Array(newArray);
// Console.WriteLine();
// int[,] changeArray = ChangeOrderElementsRows(newArray);
// Print2Array(changeArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

int[] SumElementsRows(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumArray[i] = sum;
        }
    }
    return sumArray;
}

void PrintSumArray(int[] array)
{
    Console.Write("Сумма элементов в строке: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

int IndexMinElements(int[] array)
{
    int iMin = 0;
    int min = array[iMin];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}
/*
// int[,] newArray = Create2Array();
// Print2Array(newArray);
// Console.WriteLine();
// int[] sumArray = SumElementsRows(newArray);
// PrintSumArray(sumArray);
// int numberRows = (IndexMinElements(sumArray) + 1);
// Console.WriteLine($"Номер строки с наименьшей суммой элементов - {numberRows}.");
*/
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    var newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Произведение матриц невозможно.");
        Console.WriteLine("Количество строк первой матрицы должно быть равно количеству столбцов второй.");
        return null;
    }
    else
    {
        for (var i = 0; i < array1.GetLength(0); i++)
        {
            for (var j = 0; j < array2.GetLength(1); j++)
            {
                newArray[i, j] = 0;
                for (var k = 0; k < array2.GetLength(0); k++)
                {
                    newArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return newArray;
    }
}
/*
int[,] array1 = Create2Array();
Print2Array(array1);
int[,] array2 = Create2Array();
Print2Array(array2);
int[,] resultArray = MatrixMultiplication(array1,array2);
Console.ForegroundColor = ConsoleColor.Green;
if(resultArray != null) Print2Array(resultArray);
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = new int[3, 3, 2] {{{56,78}, {64,23}, {32,14}},
                                {{13,28}, {45,90}, {25,87}},
                                {{63,51}, {11,98}, {83,72}}};

int[,,] checkArray = new int[2,2,2] {{{66,25}, {34,41}}, 
                                        {{27,90}, {26,55}}};

int[] TwoDigitPositiveNumsArray()
{

    int[] array = new int[90];
    for (int i = 1; i < array.Length; i++)
    {
        array[0] = 10;
        array[i] = array[i-1] + 1;
    }
        return array;
}
void PrintArray(int[] array)
{
    Console.Write("Созданный массив: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

int[] ChangeOrderElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0,90);
        if(j!=i)
        {
            var temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
    return array;
}

int[,,] Create3DArray(int[] array)
{
    Console.Write("Введите высоту (количество строк): ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ширину(количество столбцов): ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int m = 0;
    int[,,] array3D = new int[height, width, depth];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i,j,k] = array[m];
                m++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine("Индексы элементов в трехмерном массиве (i,j,k): ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
/*
int[] arrayElements = TwoDigitPositiveNumsArray();
PrintArray(arrayElements);
Console.WriteLine();
int[] changeArray = ChangeOrderElements(arrayElements);
PrintArray(changeArray);
Console.WriteLine();
int[,,] array3D = Create3DArray(changeArray);
Print3DArray(array3D);
*/

//  Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FiilArraySpiral()
{
    Console.Write("Введите количество строк (количество строк = количество столбцов): ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] arraySpiral = new int[size, size];
    int valueElements = 0;
    for (int passage = 0; passage < size / 2; passage++)
    {
        for (int i = 0 + passage, j = 0 + passage; j < size - passage; j++) // первая строка
        {
            arraySpiral[i, j] = valueElements + 1;
            valueElements++;
        }
        for (int i = 1 + passage, j = size - passage - 1; i < size - passage; i++) // первый столбец
        {
            arraySpiral[i, j] = valueElements + 1;
            valueElements++;
        }
        for (int i = size - passage - 1, j = size - passage - 2; j >= 0 + passage; j--) // третья строка
        {
            arraySpiral[i, j] = valueElements + 1;
            valueElements++;
        }
        for (int i = size - passage - 2, j = 0 + passage; i > 0 + passage; i--) // четвертый столбец
        {
            arraySpiral[i, j] = valueElements + 1;
            valueElements++;
        }
    }
    if (size % 2 != 0) arraySpiral[size / 2, size / 2] = size * size;
    return arraySpiral;
}

void PrintArraySpiral(int[,] array, int fillZeros = 2)
{
    Console.WriteLine("Квадратный массив, заполненный спирально: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{fillZeros}") + " ");
        Console.WriteLine();
    }
}

int[,] result = FiilArraySpiral();
PrintArraySpiral(result);

Console.ReadLine();