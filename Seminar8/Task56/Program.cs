//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
(int[,], int) Input()
{
    Console.WriteLine("Инициализация двумерного массива");
    Console.WriteLine("Массив заполняется случайными целыми числами");
    Console.Write("Введите количество строк массива (число):\t");
    string s1 = Console.ReadLine();
    int a = Convert.ToInt32(s1);
    Console.Write("Введите количество столбцов массива (число):\t");
    string s2 = Console.ReadLine();
    int b = Convert.ToInt32(s2);
    int[,] array = new int[a, b];
    return (array, a);
}
void FillArray(int[,] arr)
{
    Random r = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[] NewArray(int[,] arr, int size)
{
    int sum;
    int[] array = new int[size];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        array[i] = sum;
    }
    return array;
}
void PrintNewArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Сумма {i + 1} строки равна: {arr[i]}");
    }
}
(int, int) Row(int[] arr)
{
    int min = arr[0];
    int a = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            a = i + 1;
        }
    }
    return (min, a);
}
void Output(int min, int row)
{
    Console.WriteLine($"Строка с наименьшей суммой элементов, равной: {min} => {row} строка");
}
void Task56()
{
    (int[,] array, int a) = Input();
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    int[] array1 = NewArray(array, a);
    PrintNewArray(array1);
    Console.WriteLine();
    (int min, int row) = Row(array1);
    Output(min, row);
}
Task56();
