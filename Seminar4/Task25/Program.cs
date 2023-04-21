//Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
//3, 5-> 243(3⁵)
//2, 4-> 16
int Input(string str)
{
    Console.Write(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int Output(int z1, int z2)
{
    int z3 = z1 * z1;
    for (int i = 2; i != z2; i++)
    {
       z3 *= z1;
    }
    int result = z3;
    return result;
}
string s1 = "Введите первое число для возведения в степень в степень:\t";
string s2 = "Введите второе число - степень первого числа:\t";
int b = Input(s1);
int c = Input(s2);
Console.WriteLine($"Результат возведения числа {b} в степень {c} -> {Output(b, c)}");
