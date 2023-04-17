//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A(3, 6, 8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
Console.Write("Введите координату по оси Х первой точки:\t");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по оси Y первой точки:\t");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по оси Z первой точки:\t");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по оси Х второй точки:\t");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по оси Y второй точки:\t");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по оси Z второй точки:\t");
double z2 = Convert.ToDouble(Console.ReadLine());
double Dist(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double dist = Math.Sqrt(
        Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2)
    );
    return dist;
}
double d = Dist(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками в декартовых координатах (3D) {d}");
