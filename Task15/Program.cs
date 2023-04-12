// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите цифру, которая обозначает день недели:\t");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
    Console.WriteLine("Понедельник не выходной");
    break;
    case 2:
    Console.WriteLine("Вторник не выходной");
    break;
    case 3:
    Console.WriteLine("Среда не выходной");
    break;
    case 4:
    Console.WriteLine("Четверг не выходной");
    break;
    case 5:
    Console.WriteLine("Пятница не выходной");
    break;
    case 6:
    Console.WriteLine("Суббота ВЫХОДНОЙ");
    break;
    case 7:
    Console.WriteLine("Воскресение ВЫХОДНОЙ");
    break;
    default:
    Console.WriteLine("Эти данные не соответствуют ни одному дню недели");
    break;
}