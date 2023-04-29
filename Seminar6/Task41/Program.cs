//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//- 1, -7, 567, 89, 223->
int Input()
{
    Console.Write("Введите количество чисел, с которым будет работать программа:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
void InputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число:\t");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}
void PrintArray(int[] arr)
{
    Console.Write("Вы ввели числа:\t");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int AboveZero(int[] arr)
{
    int a = 0;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] > 0)
            a++;
        i++;
    }
    return a;
}
void Task41()
{
    int number = Input();
    int[] array = new int[number];
    InputArray(array);
    PrintArray(array);
    Console.WriteLine();
    int result = AboveZero(array);
    Console.WriteLine($"Среди введенных чисел {result} чисел больше 0");
}
Task41();