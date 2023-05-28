//Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
//N = 5-> "5, 4, 3, 2, 1"
//N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"
int Input()
{
    Console.Write("Введите число:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
void OutputNumbers(int n)
{
    Console.Write(n + " ");
    n--;
    if (n >= 1)
    {
        OutputNumbers(n);
    }
}
void Task64()
{
    int n = Input();
    OutputNumbers(n);
}
Task64();
