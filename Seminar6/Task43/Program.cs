//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
(int, int, int, int) Input()
{
    Console.WriteLine("Программа нахождения координат точки пересечения двух прямых,");
    Console.WriteLine("заданных линейными уравнениями: y = k1 * х + b1, y = k2 * x + b2");
    Console.WriteLine("Введите параметры первого уравнения k1 и b1");
    Console.Write("k1 = ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"уравнение первой прямой: y = {k1} * x + {b1}");
    Console.WriteLine();
    Console.WriteLine("Введите параметры второго уравнения k2 и b2");
    Console.Write("k2 = ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"уравнение второй прямой: y = {k2} * x + {b2}");
    return (k1, b1, k2, b2);
}
(int, int, bool, bool) Calculation(int k1, int b1, int k2, int b2)
{
    int x = 0;
    int y = 0;
    bool flag1 = false;
    bool flag2 = false;
    if (k1 != k2)
    {
        x = (b1 - b2) / (k1 - k2);
        y = k1 * x + b1;
    }
    else if (b1 != b2)
    {
        flag1 = true;
    }
    else
    {
        flag2 = true;
    }
    return (x, y, flag1, flag2);
}
void Task43()
{
    (int k1, int b1, int k2, int b2) = Input();
    Console.WriteLine();
    (int x, int y, bool flag1, bool flag2) = Calculation(k1, b1, k2, b2);
    if (flag1 == true)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if (flag2 == true)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine($"Координаты точки пересечения прямых x = {x}, y = {y}");
    }
}
Task43();
