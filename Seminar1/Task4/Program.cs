//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число:\t");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:\t");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:\t");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное из введенных чисел: {max}");
