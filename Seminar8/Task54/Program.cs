//Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
int[,] Input()
{
    Console.WriteLine("Инициализация двумерного массива");
    Console.WriteLine("Массив заполняется рандомно целыми числами");
    Console.Write("Введите количество строк массива (число):\t");
    string s1 = Console.ReadLine();
    int a = Convert.ToInt32(s1);
    Console.Write("Введите количество столбцов массива (число):\t");
    string s2 = Console.ReadLine();
    int b = Convert.ToInt32(s2);
    int[,] array = new int[a, b];
    return array;
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
void SortArray(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = j + 1; l < arr.GetLength(1); l++)
            {
                if (arr[i, j] < arr[i, l])
                {
                    temp = arr[i, l];
                    arr[i, l] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
}
void Task54()
{
    int[,] array = Input();
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    SortArray(array);
    Console.WriteLine("Упорядоченный массив на убывание элементов каждой строки");
    PrintArray(array);
}
Task54();