// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
static void Main(string[] args)
{
Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Ackermann function({0}, {1}): {2}", m, n, Ackermann(m, n));
}
static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
