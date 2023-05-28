//Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
(int, int) Input()
{
    Console.WriteLine("Введите меньшее и большее значение, в промежутке которых нужно найти сумму чисел");
    Console.Write("Введите первое число:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число число:\t");
    int b = Convert.ToInt32(Console.ReadLine());
    return (a, b);
}
void OutputNumbers(int m, int n, int sum)
{
    sum += m;
    m++;
    if (m <= n)
    {
        OutputNumbers(m, n, sum);
    }
    else
    {
        Console.Write($"Сумма чисел равна: {sum}");
    }
}
void Task66()
{
    (int m, int n) = Input();
    if (m > n)
    {
        m = n;
        n = m;
    }
    int sum = 0;
    OutputNumbers(m, n, sum);
}
Task66();
