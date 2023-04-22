//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 - 2,71 78,24] -> 80,95
void FillArray(double[] arr)
{
    Random r = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((r.NextDouble() * 100), 2);
    }
}
void PrintArray(double[] arr)
{
    Console.Write("Вывод массива:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
double MinArray(double[] arr)
{
    double temp;
    double a;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    a = arr[0];
    return a;
}
void PrintSortArray(double[] arr)
{
    Console.Write("Вывод отсортированного массива от min до max:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
double MaxArray(double[] arr)
{
    double a = arr[arr.Length - 1];
    return a;
}
double DiffElements(double a, double b)
{
    double c = a - b;
    return c;
}
void Task38()
{
    int s = 10;
    double[] array = new double[s];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    double min = MinArray(array);
    PrintSortArray(array);
    Console.WriteLine();
    Console.WriteLine($"Элемент массива с минимальным значением равен: {min}");
    double max = MaxArray(array);
    Console.WriteLine($"Элемент массива с максимальным значением равен: {max}");
    double dif = DiffElements(max, min);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {dif}");
}
Task38();
