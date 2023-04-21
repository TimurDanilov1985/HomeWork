//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452-> 11
//82-> 10
//9012-> 12
int Leng(int l)
{
    int ind = 0;
    while (l != 0)
    {
        l /= 10;
        ind++;
    }
    return ind;
}
int Sum(int n, int i)
{
    int sum = 0;
    for (int j = 0; j != i; j++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
Console.Write("Введите число:\t");
int a = int.Parse(Console.ReadLine());
int count = Leng(a);
Console.WriteLine($"Сумма цифр в числе {a} равна {Sum(a, count)}");