//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет
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
(int, int) InputPosition()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Запрос индексов элемента массива");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Введите первый индекс элемента по строке:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второй индекс элемента по столбцу:\t");
    int b = Convert.ToInt32(Console.ReadLine());
    return (a, b);
}
int InputElementValue()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Запрос значения элемента массива");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Введите число:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
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
int FindElement(int a, int b, int[,] arr)
{
    int element = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                element = arr[i, j];
            }
        }
    }
    return element;
}
(int, int, bool, int) ElementInArray(int[,] arr, int element)
{
    int a = 0;
    int b = 0;
    int count = 0;
    bool flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                a = i;
                b = j;
                count++;
                flag = true;
            }
        }
    }
    return (a, b, flag, count);
}
void Output(int result, int i, int j, int i1, int j1, int element, bool f, int count)
{
    if (result != 0)
    {
        Console.WriteLine($"Элемент под индексом ({i}, {j}) есть в этом массиве и равен: {result}");
    }
    else
    {
        Console.WriteLine($"Нет элемента под индексами ({i}, {j}) в данном массиве");
    }
    if (f == true)
    {
        Console.WriteLine($"Элемент {element} есть в данном массиве, их количество равно: {count} и последний из них находиться по индексам: {i1}, {j1}");
    }
    else
    {
        Console.WriteLine($"Элемент {element} в данном массиве отсутствует");
    }
}
void Task50()
{
    (int m, int n) = Input();
    Console.WriteLine();
    (int i, int j) = InputPosition();
    Console.WriteLine();
    int e = InputElementValue();
    int[,] array = FillArray(m, n);
    PrintArray(array);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    int r = FindElement(i, j, array);
    (int i1, int j1, bool flag, int count) = ElementInArray(array, e);
    Output(r, i, j, i1, j1, e, flag, count);
}
Task50();