//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212->нет
//12821->да
//23432->да
Console.Write("Введите пятизначное число:\t");
string s = Console.ReadLine();
char[] s1 = s.ToCharArray();
Array.Reverse(s1);
string f = new string(s1);
if (s == f)
{
    Console.WriteLine($"Да, число {s} является полиндромом");
}
else
{
    Console.WriteLine($"Нет, число {s} не является полиндромом");
}
