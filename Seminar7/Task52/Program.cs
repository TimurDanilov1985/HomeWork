//Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
(int, int) Input()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Инициализация двумерного массива");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Введите количество строк двумерного массива:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Введите количество столбцов двумерного массива:\t");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Создан  массив {a} строк и {b} столбцов => {a} х {b}");
    return (a, b);
}
int[,] FillArray(int a, int b)
{
    int[,] arr = new int[a, b];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Вывод массива:\t");
    int a;
    int b = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        a = b;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (j == a)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                a++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write(arr[i, j] + " ");
        }
        b++;
        Console.WriteLine();
    }
}
double[] ArithmeticMean(int[,] arr, int n)
{
    double[] mean = new double[n];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        mean[i] = sum / arr.GetLength(0);
        sum = 0;
    }
    return mean;
}
void PrintResult(double[] arr)
{
    Console.Write("Среднее арифметическое элементов столбцов двумерного массива:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        Console.Write(arr[i] + " ");
    }
}
void Task52()
{
    (int m, int n) = Input();
    int[,] array = FillArray(m, n);
    PrintArray(array);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    double[] result = ArithmeticMean(array, n);
    PrintResult(result);
    Console.ForegroundColor = ConsoleColor.White;
}
Task52();