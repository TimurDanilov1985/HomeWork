//Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
(int[,], int[,]) Input()
{
    Console.WriteLine("В данной задаче инициализируем две матрицы с заданной размерностью");
    Console.WriteLine("матрицы заполняются случайными целыми числами");
    Console.WriteLine("Программа выполнит произведение двух матриц");
    Console.WriteLine();
    Console.WriteLine("Введите размерность первой матрицы:");
    Console.Write("Введите количество строк первой матрицы:\t");
    string s1 = Console.ReadLine();
    int a = Convert.ToInt32(s1);
    Console.Write("Введите количество столбцов первой матрицы:\t");
    string s2 = Console.ReadLine();
    int b = Convert.ToInt32(s2);
    int[,] matrix1 = new int[a, b];
    Console.WriteLine();
    Console.WriteLine("Введите размерность второй матрицы:");
    Console.Write("Введите количество строк второй матрицы:\t");
    string s3 = Console.ReadLine();
    int c = Convert.ToInt32(s3);
    Console.Write("Введите количество столбцов второй матрицы:\t");
    string s4 = Console.ReadLine();
    int d = Convert.ToInt32(s4);
    int[,] matrix2 = new int[c, d];
    return (matrix1, matrix2);
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
void PrintArray(int[,] arr, string s)
{
    Console.WriteLine(s);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы не согласованы, выполнить произведение невозможно!");
        Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй матрицы");
    }
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return result;
}
void Task58()
{
    (int[,] matrix1, int[,] matrix2) = Input();
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine();
    string s1 = "Первая матрица:";
    PrintArray(matrix1, s1);
    Console.WriteLine();
    string s2 = "Вторая матрица:";
    PrintArray(matrix2, s2);
    Console.WriteLine();
    int[,] result = MultiMatrix(matrix1, matrix2);
    string s3 = "Результат произведения двух матриц:";
    PrintArray(result, s3);
}
Task58();
