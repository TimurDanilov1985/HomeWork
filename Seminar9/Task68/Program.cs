//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
(int, int) Input()
{
    Console.WriteLine("Введите два неотрицательных целых числа");
    Console.Write("Введите первое число:\t");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число число:\t");
    int b = Convert.ToInt32(Console.ReadLine());
    return (a, b);
}
int Acker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Acker(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Acker(m - 1, Acker(m, n - 1));
    }
    else
        return n + 1;
}
void Task68()
{
    (int m, int n) = Input();
    int result = Acker(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана равен: {result}");
}
Task68();
