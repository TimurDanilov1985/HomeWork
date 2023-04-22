//Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов с нечётными индексами.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0
void FillArray(int[] arr)
{
    Random r = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(-99, 100);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("Вывод массива:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
void Task36()
{
    int s = 10;
    int[] array = new int[s];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    int result = OddIndexSum(array);
    Console.WriteLine($"Сумма элементов массива с нечетными индексами равна: {result}");
}
Task36();