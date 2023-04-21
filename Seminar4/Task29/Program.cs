//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]
int[] Array()
{
    int[] array = new int[8];
    int a = array.Length;
    Random run = new Random();
    for (int i = 0; i != a; i++)
    {
        array[i] = run.Next(-100, 100);
    }
    return array;
}
int[] arr = Array();
Console.Write("Вывод массива:\t");
for (int i = 0; i != arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
