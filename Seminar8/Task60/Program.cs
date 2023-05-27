//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0, 0, 0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)
int[,,] Input()
{
    Console.WriteLine("Инициализация трехмерного массива");
    Console.Write("Введите первое измерение массива:\t");
    string s1 = Console.ReadLine();
    int a = Convert.ToInt32(s1);
    Console.Write("Введите второе измерение массива:\t");
    string s2 = Console.ReadLine();
    int b = Convert.ToInt32(s2);
    Console.Write("Введите третье измерение массива:\t");
    string s3 = Console.ReadLine();
    int c = Convert.ToInt32(s3);
    int[,,] array = new int[a, b, c];
    return array;
}
int[] GetElements(int[,,] arr)
{
    int[] array = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    Random r = new Random();
    for (int c = 0; c < array.Length; c++)
    {
        array[c] = r.Next(10, 100);
    }
    F:
    int z = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                array[j] = r.Next(10, 100);
                z++;
            }
        }
    }
    if (z != 0)
    {
        goto F;
    }
    return array;
}
void FillArray(int[,,] arr, int[] elements)
{
    int z = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = elements[z];
                z++;
            }
        }
    }
}
void PrintArray(int[,,] arr)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
void Task60()
{
    int[,,] array = Input();
    int[] elements = GetElements(array);
    FillArray(array, elements);
    PrintArray(array);
}
Task60();
