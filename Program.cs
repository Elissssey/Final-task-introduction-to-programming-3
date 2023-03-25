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

