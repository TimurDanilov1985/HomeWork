//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9
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
double[,] FillArray(int a, int b)
{
    double[,] arr = new double[a, b];
    Random rand = new Random();
    Random r = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rand.NextDouble() * r.Next(-1, 2) * 10), 1);
        }
    }
    return arr;
}
void PrintArray(double[,] arr)
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
void Task47()
{
    (int m, int n) = Input();
    double[,] array = FillArray(m, n);
    PrintArray(array);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}
Task47();