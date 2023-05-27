//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
void FillArray(int[,] array)
{
    int z = 1;
    int i = 0;
    int j = 0;
    int l0 = array.GetLength(0);
    int l1 = array.GetLength(1);
    for (j = 0; j < l1; j++)
    {
        array[i, j] = z;
        z++;
    }
    j = l1 - 1;
    for (i = 1; i < l0; i++)
    {
        array[i, j] = z;
        z++;
    }
    i = l0 - 1;
    for (j = l1 - 2; j >= 0; j--)
    {
        array[i, j] = z;
        z++;
    }
    j = 0;
    for (i = l0 - 2; i >= 1; i--)
    {
        array[i, j] = z;
        z++;
    }
    i = 1;
    for (j = 1; j < l1 - 1; j++)
    {
        array[i, j] = z;
        z++;
    }
    j = 2;
    for (i = 2; i < l0 - 1; i++)
    {
        array[i, j] = z;
        z++;
    }
    i = 2;
    for (j = 1; i < l1 - 1; i++)
    {
        array[i, j] = z;
        z++;
    }
}
void PrintArray(int[,] arr)
{
    Console.WriteLine("Спирально заполненный двумерный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Task62()
{
    int[,] array = new int[4, 4];
    FillArray(array);
    PrintArray(array);
}
Task62();