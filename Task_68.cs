﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m, n;
Console.WriteLine("Введите число M:");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите число N:");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"M = {m}; N = {n} -> ");
Console.Write($"A(m,n) = {Akker(m, n)}");


int Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akker(m - 1, 1);
    else
        return Akker(m - 1, Akker(m, n - 1));
}