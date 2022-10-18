// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)

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
ReverseArray(yourArray);
PrintArray(yourArray);
Console.ReadLine();