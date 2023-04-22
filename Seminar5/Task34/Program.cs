//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void FillArray(int[] arr)
{
    Random ran = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(100, 1000);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("Вывод мыссива:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void Task34()
{
    int s = 10;
    int[] array = new int[s];
    FillArray(array);
    PrintArray(array);
    int n = EvenNumbers(array);
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве {n}");
}
Task34();
